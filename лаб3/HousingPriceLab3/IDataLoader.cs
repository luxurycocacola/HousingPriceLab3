using System.Collections.Generic;

namespace HousingPriceLab3
{
    public interface IDataLoader
    {
        List<HousingData> Load(string path);
    }
}
