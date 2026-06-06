using System.ComponentModel;

namespace HousingPriceLab3
{
    public class HousingData
    {
        [DisplayName("Год")]
        public int Year { get; set; }

        [DisplayName("1-комнатные")]
        public double OneRoom { get; set; }

        [DisplayName("2-комнатные")]
        public double TwoRoom { get; set; }

        [DisplayName("3-комнатные")]
        public double ThreeRoom { get; set; }

        [DisplayName("4-комнатные")]
        public double FourRoom { get; set; }
    }
}