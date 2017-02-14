namespace RIntegretion
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.biggestValue = new System.Windows.Forms.NumericUpDown();
            this.instrumentCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsGV = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.openScriptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biggestValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Take biggest:";
            // 
            // biggestValue
            // 
            this.biggestValue.Location = new System.Drawing.Point(105, 56);
            this.biggestValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.biggestValue.Name = "biggestValue";
            this.biggestValue.Size = new System.Drawing.Size(120, 20);
            this.biggestValue.TabIndex = 3;
            this.biggestValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // instrumentCB
            // 
            this.instrumentCB.FormattingEnabled = true;
            this.instrumentCB.Location = new System.Drawing.Point(15, 25);
            this.instrumentCB.Name = "instrumentCB";
            this.instrumentCB.Size = new System.Drawing.Size(210, 21);
            this.instrumentCB.TabIndex = 4;
            this.instrumentCB.SelectionChangeCommitted += new System.EventHandler(this.instrumentCB_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrument";
            // 
            // resultsGV
            // 
            this.resultsGV.AllowUserToAddRows = false;
            this.resultsGV.AllowUserToDeleteRows = false;
            this.resultsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.Side,
            this.Volume});
            this.resultsGV.Location = new System.Drawing.Point(15, 96);
            this.resultsGV.Name = "resultsGV";
            this.resultsGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.resultsGV.Size = new System.Drawing.Size(444, 217);
            this.resultsGV.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // proceedBtn
            // 
            this.proceedBtn.Enabled = false;
            this.proceedBtn.Location = new System.Drawing.Point(362, 25);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(97, 51);
            this.proceedBtn.TabIndex = 6;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // openScriptBtn
            // 
            this.openScriptBtn.Location = new System.Drawing.Point(248, 25);
            this.openScriptBtn.Name = "openScriptBtn";
            this.openScriptBtn.Size = new System.Drawing.Size(96, 51);
            this.openScriptBtn.TabIndex = 7;
            this.openScriptBtn.Text = "Open Script";
            this.openScriptBtn.UseVisualStyleBackColor = true;
            this.openScriptBtn.Click += new System.EventHandler(this.openScriptBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 325);
            this.Controls.Add(this.openScriptBtn);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.resultsGV);
            this.Controls.Add(this.instrumentCB);
            this.Controls.Add(this.biggestValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "mainForm";
            this.Text = "R Pivot Prices";
            ((System.ComponentModel.ISupportInitialize)(this.biggestValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown biggestValue;
        private System.Windows.Forms.ComboBox instrumentCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Button openScriptBtn;
    }
}

