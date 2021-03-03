using System;

using Lab2alibs;



    class Program
    {
        static void Main()
        {
            Console.Write("Введiть марку планшета: ");
            string sBrand = Console.ReadLine();
            Console.Write("Введiть модель планшета: ");
            string sModel = Console.ReadLine();
            Console.Write("Введiть колiр планшета: ");
            string sColor = Console.ReadLine();
            Console.Write("Введiть об'єм пам'ятi: ");
            string sMemory = Console.ReadLine();
            Console.Write("Введiть рiк випуску: ");
            string sYear = Console.ReadLine();
            Console.Write("Введiть дiагональ екрану: ");
            string sSizeDisplay = Console.ReadLine();
            Console.Write("Чи є модуль Bluetooth  (y-так, n-нi): ");
            ConsoleKeyInfo keyHasPort = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Чи є модуль NFC (y-так, n-нi): ");
            ConsoleKeyInfo keyHasAirport = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Введiть кiлькiсть продукцiї на складi: ");
            string sNumber = Console.ReadLine();
            Console.Write("Введiть загальну суму вартостi товару: ");
            string sTotalPrice = Console.ReadLine();
            Tablet OurTablet = new Tablet();
            OurTablet.Brand = sBrand;
            OurTablet.Model = sModel;
            OurTablet.Color = sColor;
            OurTablet.Memory = int.Parse(sMemory);
            OurTablet.Year = double.Parse(sYear);
            OurTablet.SizeDisplay = double.Parse(sSizeDisplay);
            OurTablet.Bluetooth = keyHasPort.Key == ConsoleKey.Y ? true : false;
            OurTablet.NFC = keyHasAirport.Key == ConsoleKey.Y ? true : false;
            OurTablet.Number = int.Parse(sNumber);
            OurTablet.TotalPrice = double.Parse(sTotalPrice);

            double YearIncomePerInhabitant = OurTablet.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine(" ");
            Console.WriteLine("Данi про планшет: ");
            Console.WriteLine("");
            Console.WriteLine("Марка: " + OurTablet.Brand);
            Console.WriteLine("Модель: " + OurTablet.Model);
            Console.WriteLine("Колiр: " + OurTablet.Color);
            Console.WriteLine("Об'єм пам'ятi: " + OurTablet.Memory.ToString());
            Console.WriteLine("Рiк випуску: " + OurTablet.Year.ToString(""));
            Console.WriteLine("Дiагональ екрану: " + OurTablet.SizeDisplay.ToString(""));
            Console.WriteLine(OurTablet.Bluetooth ? "Bluetooth присутнiй у данiй партiї" :
            "Bluetooth вiдсутнiй у данiй партiї");
            Console.WriteLine(OurTablet.NFC ? "Модуль NFC присутнiй" :
            "Модуль NFC вiдсутнiй");
            Console.WriteLine("Кiлькiсть на складi: " + OurTablet.Number.ToString());
            Console.WriteLine("Загальна цiна товару: " + OurTablet.TotalPrice.ToString("0.00"));
            Console.WriteLine();
            Console.WriteLine("Середня цiна за одиницю товару: " +
            YearIncomePerInhabitant.ToString("0.00"));
            Console.ReadKey();

        }

    }

    

