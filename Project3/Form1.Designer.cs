namespace Project3
{
    partial class aCraps
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.nRollsBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.winlose = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rollHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rngLabel = new System.Windows.Forms.Label();
            this.nRollsLabel = new System.Windows.Forms.Label();
            this.wlChartLabel = new System.Windows.Forms.Label();
            this.histLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winlose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(12, 22);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(138, 20);
            this.seedBox.TabIndex = 0;
            this.seedBox.Text = "RNG seed";
            this.seedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seedBox.Enter += new System.EventHandler(this.seedBox_Enter);
            // 
            // nRollsBox
            // 
            this.nRollsBox.Location = new System.Drawing.Point(183, 22);
            this.nRollsBox.Name = "nRollsBox";
            this.nRollsBox.Size = new System.Drawing.Size(138, 20);
            this.nRollsBox.TabIndex = 1;
            this.nRollsBox.Text = "10000";
            this.nRollsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRollsBox.Enter += new System.EventHandler(this.nRollsBox_Enter);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(366, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(124, 30);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // winlose
            // 
            chartArea13.Name = "ChartArea1";
            this.winlose.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.winlose.Legends.Add(legend13);
            this.winlose.Location = new System.Drawing.Point(12, 78);
            this.winlose.Name = "winlose";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.winlose.Series.Add(series13);
            this.winlose.Size = new System.Drawing.Size(225, 182);
            this.winlose.TabIndex = 3;
            this.winlose.Text = "chart1";
            // 
            // rollHistogram
            // 
            this.rollHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea14.Name = "ChartArea1";
            this.rollHistogram.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.rollHistogram.Legends.Add(legend14);
            this.rollHistogram.Location = new System.Drawing.Point(243, 78);
            this.rollHistogram.Name = "rollHistogram";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.rollHistogram.Series.Add(series14);
            this.rollHistogram.Size = new System.Drawing.Size(273, 182);
            this.rollHistogram.TabIndex = 4;
            this.rollHistogram.Text = "chart1";
            // 
            // rngLabel
            // 
            this.rngLabel.AutoSize = true;
            this.rngLabel.Location = new System.Drawing.Point(12, 9);
            this.rngLabel.Name = "rngLabel";
            this.rngLabel.Size = new System.Drawing.Size(57, 13);
            this.rngLabel.TabIndex = 5;
            this.rngLabel.Text = "RNG seed";
            // 
            // nRollsLabel
            // 
            this.nRollsLabel.AutoSize = true;
            this.nRollsLabel.Location = new System.Drawing.Point(180, 9);
            this.nRollsLabel.Name = "nRollsLabel";
            this.nRollsLabel.Size = new System.Drawing.Size(113, 13);
            this.nRollsLabel.TabIndex = 6;
            this.nRollsLabel.Text = "# of games to simulate";
            // 
            // wlChartLabel
            // 
            this.wlChartLabel.AutoSize = true;
            this.wlChartLabel.Location = new System.Drawing.Point(12, 62);
            this.wlChartLabel.Name = "wlChartLabel";
            this.wlChartLabel.Size = new System.Drawing.Size(75, 13);
            this.wlChartLabel.TabIndex = 7;
            this.wlChartLabel.Text = "Wins / Losses";
            // 
            // histLabel
            // 
            this.histLabel.AutoSize = true;
            this.histLabel.Location = new System.Drawing.Point(243, 62);
            this.histLabel.Name = "histLabel";
            this.histLabel.Size = new System.Drawing.Size(75, 13);
            this.histLabel.TabIndex = 8;
            this.histLabel.Text = "Roll Histogram";
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Location = new System.Drawing.Point(12, 282);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(504, 202);
            this.resultBox.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(9, 268);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(148, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Results of the first five games:";
            // 
            // aCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 490);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.histLabel);
            this.Controls.Add(this.wlChartLabel);
            this.Controls.Add(this.nRollsLabel);
            this.Controls.Add(this.rngLabel);
            this.Controls.Add(this.rollHistogram);
            this.Controls.Add(this.winlose);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.nRollsBox);
            this.Controls.Add(this.seedBox);
            this.Name = "aCraps";
            this.Text = "Craps Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.winlose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.TextBox nRollsBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart winlose;
        private System.Windows.Forms.DataVisualization.Charting.Chart rollHistogram;
        private System.Windows.Forms.Label rngLabel;
        private System.Windows.Forms.Label nRollsLabel;
        private System.Windows.Forms.Label wlChartLabel;
        private System.Windows.Forms.Label histLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

