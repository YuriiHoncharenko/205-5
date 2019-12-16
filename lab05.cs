using System;

namespace TestDemo
{
    class Program
    {
        class Tablet
        {
            public string Name;
            public string Manufacturer;
            public string Colour;
            public int Memory;
            public int Model;
            public int Amount;
            public double Cost;
            public int Users;
            public double GetYearIncomePerInhabitant()
            {
                double x;
                if (Amount > Users)
                {
                    x = Users;
                }
                else
                {
                    x = Amount;
                }
                return x * Cost;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть назву планшету: ");
            string sName = Console.ReadLine();
            Console.Write("Введiть iм'я виробника: ");
            string sManufacturer = Console.ReadLine();
            Console.Write("Введiть колiр планшету: ");
            string sColour = Console.ReadLine();
            Console.Write("Введiть обсяг пам'ятi: ");
            string sMemory = Console.ReadLine();
            Console.Write("Введiть номер моделi: ");
            string sModel = Console.ReadLine();
            Console.Write("Введiть кiлькiсть планшетiв: ");
            string sAmount = Console.ReadLine();
            Console.Write("Введiть цiну: ");
            string sCost = Console.ReadLine();
            Console.Write("Введiть кiлькiсть користувачiв: ");
            string sUsers = Console.ReadLine();
            Console.WriteLine();
            Tablet OurTablet = new Tablet();
            OurTablet.Name = sName;
            OurTablet.Manufacturer = sManufacturer;
            OurTablet.Colour = sColour;
            OurTablet.Model = int.Parse(sModel);
            OurTablet.Memory = int.Parse(sMemory);
            OurTablet.Amount = int.Parse(sAmount);
            OurTablet.Cost = double.Parse(sCost);
            OurTablet.Users = int.Parse(sUsers);
            double YearIncomePerInhabitant = OurTablet.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про планшет: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва: " + OurTablet.Name);
            Console.WriteLine("Виробник: " + OurTablet.Manufacturer);
            Console.WriteLine("Колiр: " + OurTablet.Colour);
            Console.WriteLine("Обсяг пам'ятi: " + OurTablet.Memory.ToString());
            Console.WriteLine("Кiлькiсть користувачiв: " + OurTablet.Users.ToString());
            Console.WriteLine("Кiлькiсть планшетiв: " + OurTablet.Amount.ToString());
            Console.WriteLine("Цiна: " + OurTablet.Cost.ToString("0.00"));
            Console.WriteLine();
            Console.WriteLine("Можливий дохiд: " + YearIncomePerInhabitant.ToString("0.00")); Console.ReadKey();
        }
    }
}
