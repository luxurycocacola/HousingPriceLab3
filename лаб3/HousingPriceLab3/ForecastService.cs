using System.Collections.Generic;
using System.Linq;

namespace HousingPriceLab3
{
    public class ForecastService
    {
        public List<double> MovingAverageForecast(List<double> values, int period, int yearsCount)
        {
            List<double> result = new List<double>();
            List<double> temporaryValues = new List<double>(values);

            for (int i = 0; i < yearsCount; i++)
            {
                double forecastValue = temporaryValues
                    .Skip(temporaryValues.Count - period)
                    .Take(period)
                    .Average();

                result.Add(forecastValue);
                temporaryValues.Add(forecastValue);
            }

            return result;
        }
    }
}
