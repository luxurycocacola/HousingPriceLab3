namespace HousingPriceLab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView gridHousing;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBuildChart;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForecastYears;
        private System.Windows.Forms.Label lblAveragePeriod;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numForecastYears;
        private System.Windows.Forms.NumericUpDown numAveragePeriod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrices;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.gridHousing = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBuildChart = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnForecast = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForecastYears = new System.Windows.Forms.Label();
            this.lblAveragePeriod = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numForecastYears = new System.Windows.Forms.NumericUpDown();
            this.numAveragePeriod = new System.Windows.Forms.NumericUpDown();
            this.chartPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridHousing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAveragePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridHousing
            // 
            this.gridHousing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHousing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHousing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHousing.Location = new System.Drawing.Point(292, 86);
            this.gridHousing.Name = "gridHousing";
            this.gridHousing.Size = new System.Drawing.Size(868, 210);
            this.gridHousing.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(24, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(220, 42);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить данные";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBuildChart
            // 
            this.btnBuildChart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuildChart.Location = new System.Drawing.Point(24, 80);
            this.btnBuildChart.Name = "btnBuildChart";
            this.btnBuildChart.Size = new System.Drawing.Size(220, 42);
            this.btnBuildChart.TabIndex = 1;
            this.btnBuildChart.Text = "Построить графики";
            this.btnBuildChart.UseVisualStyleBackColor = true;
            this.btnBuildChart.Click += new System.EventHandler(this.btnBuildChart_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnalysis.Location = new System.Drawing.Point(24, 136);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(220, 42);
            this.btnAnalysis.TabIndex = 2;
            this.btnAnalysis.Text = "Анализ изменения цен";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnForecast
            // 
            this.btnForecast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnForecast.Location = new System.Drawing.Point(24, 282);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(220, 42);
            this.btnForecast.TabIndex = 7;
            this.btnForecast.Text = "Построить прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(24, 340);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(220, 42);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Экспорт графика PNG";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(515, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Анализ цен на первичное жилье в России";
            // 
            // lblForecastYears
            // 
            this.lblForecastYears.AutoSize = true;
            this.lblForecastYears.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblForecastYears.Location = new System.Drawing.Point(24, 205);
            this.lblForecastYears.Name = "lblForecastYears";
            this.lblForecastYears.Size = new System.Drawing.Size(105, 15);
            this.lblForecastYears.TabIndex = 3;
            this.lblForecastYears.Text = "Лет для прогноза:";
            // 
            // lblAveragePeriod
            // 
            this.lblAveragePeriod.AutoSize = true;
            this.lblAveragePeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAveragePeriod.Location = new System.Drawing.Point(24, 243);
            this.lblAveragePeriod.Name = "lblAveragePeriod";
            this.lblAveragePeriod.Size = new System.Drawing.Size(100, 15);
            this.lblAveragePeriod.TabIndex = 5;
            this.lblAveragePeriod.Text = "Период средней:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(24, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 90);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Состояние: программа готова к работе.";
            // 
            // numForecastYears
            // 
            this.numForecastYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numForecastYears.Location = new System.Drawing.Point(168, 200);
            this.numForecastYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numForecastYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numForecastYears.Name = "numForecastYears";
            this.numForecastYears.Size = new System.Drawing.Size(76, 25);
            this.numForecastYears.TabIndex = 4;
            this.numForecastYears.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numAveragePeriod
            // 
            this.numAveragePeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numAveragePeriod.Location = new System.Drawing.Point(168, 238);
            this.numAveragePeriod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAveragePeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAveragePeriod.Name = "numAveragePeriod";
            this.numAveragePeriod.Size = new System.Drawing.Size(76, 25);
            this.numAveragePeriod.TabIndex = 6;
            this.numAveragePeriod.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // chartPrices
            // 
            this.chartPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "MainArea";
            this.chartPrices.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.chartPrices.Legends.Add(legend1);
            this.chartPrices.Location = new System.Drawing.Point(292, 315);
            this.chartPrices.Name = "chartPrices";
            this.chartPrices.Size = new System.Drawing.Size(868, 382);
            this.chartPrices.TabIndex = 3;
            this.chartPrices.Text = "chart1";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 64);
            this.panelTop.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panelButtons.Controls.Add(this.btnLoad);
            this.panelButtons.Controls.Add(this.btnBuildChart);
            this.panelButtons.Controls.Add(this.btnAnalysis);
            this.panelButtons.Controls.Add(this.lblForecastYears);
            this.panelButtons.Controls.Add(this.numForecastYears);
            this.panelButtons.Controls.Add(this.lblAveragePeriod);
            this.panelButtons.Controls.Add(this.numAveragePeriod);
            this.panelButtons.Controls.Add(this.btnForecast);
            this.panelButtons.Controls.Add(this.btnExport);
            this.panelButtons.Controls.Add(this.lblStatus);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 64);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(270, 657);
            this.panelButtons.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.chartPrices);
            this.Controls.Add(this.gridHousing);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ цен на первичное жилье";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHousing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAveragePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
