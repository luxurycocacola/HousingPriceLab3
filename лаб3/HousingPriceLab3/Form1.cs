using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HousingPriceLab3
{
    public partial class Form1 : Form
    {
        private List<HousingData> housingData = new List<HousingData>();
        private readonly IDataLoader dataLoader = new CsvHousingLoader();
        private readonly ForecastService forecastService = new ForecastService();
        private readonly GraphExportService graphExportService = new GraphExportService();

        public Form1()
        {
            InitializeComponent();
            ConfigureChart();
        }

        private void ConfigureChart()
        {
            chartPrices.Series.Clear();
            chartPrices.ChartAreas.Clear();
            chartPrices.ChartAreas.Add(new ChartArea("MainArea"));
            chartPrices.Legends.Clear();
            chartPrices.Legends.Add(new Legend("Legend"));

            chartPrices.ChartAreas[0].AxisX.Title = "Год";
            chartPrices.ChartAreas[0].AxisY.Title = "Цена за кв. м, руб.";
            chartPrices.ChartAreas[0].AxisX.Interval = 1;

            chartPrices.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartPrices.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartPrices.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartPrices.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartPrices.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartPrices.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "housing_prices.csv");

            if (!File.Exists(path))
            {
                MessageBox.Show("Файл housing_prices.csv не найден рядом с программой.", "Ошибка");
                return;
            }

            housingData = dataLoader.Load(path);
            gridHousing.DataSource = null;
            gridHousing.DataSource = housingData;

            lblStatus.Text = "Данные загружены: " + housingData.Count + " строк.";
        }

        private void btnBuildChart_Click(object sender, EventArgs e)
        {
            if (!HasData()) return;

            ConfigureChart();
            chartPrices.Titles.Clear();
            chartPrices.Titles.Add("Динамика цен на первичное жильё в России");

            AddSeries("1-комнатные", item => item.OneRoom);
            AddSeries("2-комнатные", item => item.TwoRoom);
            AddSeries("3-комнатные", item => item.ThreeRoom);
            AddSeries("4-комнатные", item => item.FourRoom);

            lblStatus.Text = "Построен график изменения цен.";
        }

        private void AddSeries(string title, Func<HousingData, double> valueSelector)
        {
            Series series = new Series(title);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;

            foreach (HousingData item in housingData)
            {
                series.Points.AddXY(item.Year, valueSelector(item));
            }

            chartPrices.Series.Add(series);
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            Dictionary<string, double> changes = new Dictionary<string, double>
    {
        { "1-комнатные квартиры", housingData.Last().OneRoom - housingData.First().OneRoom },
        { "2-комнатные квартиры", housingData.Last().TwoRoom - housingData.First().TwoRoom },
        { "3-комнатные квартиры", housingData.Last().ThreeRoom - housingData.First().ThreeRoom },
        { "4-комнатные квартиры", housingData.Last().FourRoom - housingData.First().FourRoom }
    };

            double maxChange = changes.Values.Max();
            double minChange = changes.Values.Min();

            string maxApartments = string.Join(", ",
                changes.Where(x => x.Value == maxChange).Select(x => x.Key));

            string minApartments = string.Join(", ",
                changes.Where(x => x.Value == minChange).Select(x => x.Key));

            string resultText;

            if (maxChange == minChange)
            {
                resultText =
                    $"Анализ изменения цен за период {housingData.First().Year}–{housingData.Last().Year}:\n\n" +
                    $"Все категории квартир изменились одинаково.\n" +
                    $"Рост составил: {maxChange:N0} руб. за кв. м.";
            }
            else
            {
                resultText =
                    $"Анализ изменения цен за период {housingData.First().Year}–{housingData.Last().Year}:\n\n" +
                    $"Сильнее всего подорожали: {maxApartments}.\n" +
                    $"Рост составил: {maxChange:N0} руб. за кв. м.\n\n" +
                    $"Наименьший рост показали: {minApartments}.\n" +
                    $"Изменение составило: {minChange:N0} руб. за кв. м.";

                if (minChange < 0)
                {
                    resultText += "\n\nДанные категории подешевели за рассматриваемый период.";
                }
                else
                {
                    resultText += "\n\nСнижения цен за рассматриваемый период не наблюдалось.";
                }
            }

            MessageBox.Show(resultText, "Анализ цен");
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            if (!HasData()) return;

            int forecastYears = (int)numForecastYears.Value;
            int period = (int)numAveragePeriod.Value;

            if (period > housingData.Count)
            {
                MessageBox.Show("Период скользящей средней не может быть больше количества исходных значений.", "Ошибка");
                return;
            }

            List<double> values = housingData.Select(x => x.OneRoom).ToList();
            List<double> forecastValues = forecastService.MovingAverageForecast(values, period, forecastYears);

            ConfigureChart();
            chartPrices.Titles.Clear();
            chartPrices.Titles.Add("Прогноз цен на 1-комнатные квартиры методом скользящей средней");

            Series factSeries = new Series("Фактические данные");
            factSeries.ChartType = SeriesChartType.Line;
            factSeries.BorderWidth = 3;
            factSeries.MarkerStyle = MarkerStyle.Circle;

            foreach (HousingData item in housingData)
            {
                factSeries.Points.AddXY(item.Year, item.OneRoom);
            }

            Series forecastSeries = new Series("Прогноз");
            forecastSeries.ChartType = SeriesChartType.Line;
            forecastSeries.BorderWidth = 3;
            forecastSeries.MarkerStyle = MarkerStyle.Diamond;
            forecastSeries.BorderDashStyle = ChartDashStyle.Dash;

            int lastYear = housingData.Last().Year;
            for (int i = 0; i < forecastValues.Count; i++)
            {
                forecastSeries.Points.AddXY(lastYear + i + 1, forecastValues[i]);
            }

            chartPrices.Series.Add(factSeries);
            chartPrices.Series.Add(forecastSeries);

            lblStatus.Text = "Построен прогноз на " + forecastYears + " лет.";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (chartPrices.Series.Count == 0)
            {
                MessageBox.Show("Сначала постройте график.", "Экспорт");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Image|*.png";
            dialog.FileName = "housing_chart.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                graphExportService.ExportToPng(chartPrices, dialog.FileName);
                MessageBox.Show("График сохранен.", "Экспорт");
                lblStatus.Text = "График экспортирован в PNG.";
            }
        }

        private bool HasData()
        {
            if (housingData == null || housingData.Count == 0)
            {
                MessageBox.Show("Сначала нажмите кнопку 'Загрузить данные'.", "Нет данных");
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckData()
        {
            if (housingData == null || housingData.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные.");
                return false;
            }

            return true;
        }
    }
}
