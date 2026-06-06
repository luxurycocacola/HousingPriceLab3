using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace HousingPriceLab3
{
    public class CsvHousingLoader : IDataLoader
    {
        public List<HousingData> Load(string path)
        {
            List<HousingData> result = new List<HousingData>();
            string[] lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');

                HousingData item = new HousingData
                {
                    Year = int.Parse(parts[0]),
                    OneRoom = double.Parse(parts[1], CultureInfo.InvariantCulture),
                    TwoRoom = double.Parse(parts[2], CultureInfo.InvariantCulture),
                    ThreeRoom = double.Parse(parts[3], CultureInfo.InvariantCulture),
                    FourRoom = double.Parse(parts[4], CultureInfo.InvariantCulture)
                };

                result.Add(item);
            }

            return result;
        }
    }
}
