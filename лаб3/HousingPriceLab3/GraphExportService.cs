using System.Windows.Forms.DataVisualization.Charting;

namespace HousingPriceLab3
{
    public class GraphExportService
    {
        public void ExportToPng(Chart chart, string path)
        {
            chart.SaveImage(path, ChartImageFormat.Png);
        }
    }
}
