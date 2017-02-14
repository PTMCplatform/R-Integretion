using System;
using System.Windows.Forms;
using RDotNet;
using com.pfsoft.proftrading.commons.external;
using System.Drawing;
using PTLRuntime.NETScript;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace RIntegretion
{
    [Exportable]
    public partial class mainForm : Form, IExternalComponent, ITradeComponent
    {
        REngine engine;
        TradeData TD;
        Instrument curInstrument;

        string scriptName;

        #region Interfaces

        public Icon IconImage
        {
            get
            {
                return Icon;
            }
        }

        public string ComponentName
        {
            get
            {
                return"RIntegration";
            }
        }

        public string PanelHeader
        {
            get
            {
                return "RIntegration";
            }
        }

        public Control Content
        {
            get
            {
                return this;
            }
        }

        public NETSDK PlatformEngine
        {
            get;
            set;
        }

        #endregion

        public mainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// R script in  c# code & filling grid
        /// </summary>
        /// <param name="TD"></param>
        void Rscript(TradeData TD)
        {
            // check trade history
            if (TD.Count == 0)
                return;

            // perform input data
            int count = TD.Count;

            double[] price = new double[count];
            string[] time = new string[count];
            string[] side = new string[count];

            for (int i = 0; i < count - 1; i++)
            {
                price[i] = TD.Price(i);
                time[i] = TD.Time(i).ToString();
                side[i] = TD.Aggressor(i).ToString();
            }

            // R-input
            engine.SetSymbol("rows", engine.CreateInteger((int)biggestValue.Value));
            engine.SetSymbol("price", engine.CreateNumericVector(price));
            engine.SetSymbol("time", engine.CreateCharacterVector(time));
            engine.SetSymbol("side", engine.CreateCharacterVector(side));

            // load external script
            engine.Evaluate(@"source('"+scriptName+"')");

            // R-output
            var table = engine.GetSymbol("table").AsDataFrame();

            FillGrid(table);
        }

        public void Populate()
        {
            if (PlatformEngine != null)
            {
                StartEngine();

                var insts = PlatformEngine.Instruments.GetSortedInstruments();
                bool isShowRoutes = insts.GroupBy(p => p.Route).Count() > 1;

                //show instruments only with feature type
                var onlyFeatures = insts.Where(i => i.Type == InstrumentType.Future).ToList();

                //populating comboBox
                foreach (Instrument ins in onlyFeatures)
                {
                    instrumentCB.Items.Add(ins);
                }

            }
            
        }

        #region Misc

        /// <summary>
        /// starts R engine 
        /// </summary>
        void StartEngine()
        {
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();
        }

        /// <summary>
        /// fills DataGrid
        /// </summary>
        /// <param name="table"></param>
        void FillGrid(DataFrame table)
        {
            foreach (var dataFrameRow in table.GetRows())
            {
                DataGridViewCell price = new DataGridViewTextBoxCell();
                DataGridViewCell side = new DataGridViewTextBoxCell();
                DataGridViewCell volume = new DataGridViewTextBoxCell();
                DataGridViewRow row = new DataGridViewRow();

                price.Value = curInstrument.FormatPrice(
                    (double)dataFrameRow.DataFrame["price"][dataFrameRow.RowIndex]
                    );
                side.Value = dataFrameRow.DataFrame["side"][dataFrameRow.RowIndex].ToString();
                volume.Value = (int)dataFrameRow.DataFrame["count"][dataFrameRow.RowIndex];
                row.Cells.AddRange(price, side, volume);
                resultsGV.Rows.Add(row);
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        #endregion

        #region Events

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            // Check current instrument
            curInstrument = instrumentCB.SelectedItem as Instrument;
            if (curInstrument == null)
                return;

            resultsGV.Rows.Clear();

            // Load trade history
            TD = PlatformEngine.GetHistoricalData(new HistoricalDataRequest(curInstrument, Period.Tick, DataType.Trade)) as TradeData;
            TD.Load(DateTime.UtcNow.AddDays(-1));

            // Send to R for processing
            Rscript(TD);
        }

        private void instrumentCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            proceedBtn.Enabled = instrumentCB.SelectedItem != null && scriptName != null;
        }

        #endregion

        private void openScriptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "r script (*.r)|*.r";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                scriptName = ofd.FileName.Trim().Replace("\\", "/");
            }

            proceedBtn.Enabled = instrumentCB.SelectedItem != null && scriptName != null;
        }
    }
}
