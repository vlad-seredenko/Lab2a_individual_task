namespace Lab2alibs

{
    public class Tablet
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Memory;
        public double Year;
        public double SizeDisplay;
        public bool Bluetooth;
        public bool NFC;
        public int Number;
        public double TotalPrice;


        public double GetYearIncomePerInhabitant()
        {
            return TotalPrice / Number;
        }
        static void Main(string[] args)
        {

        }

    }
}
