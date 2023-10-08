using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Car
    {
        public string Name = "";
        public string model = "";
        public string countryCreator = "";
        public int ageOfCreating;
        public int hp;
        public int et;
        public double cost;

        public string Recomendation(string name)
        {
            string ret = "";

            if(name == "Y" | name == "y") 
            {
                ret = "Так";
            }
            else 
            {
                ret = "Ні";
            }
            
            return ret;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string result;

            Car Car = new Car();

            NumberFormatInfo NumberFormatInfo = new NumberFormatInfo();
            {
                NumberFormatInfo.NumberDecimalSeparator = ".";
            }

            Console.WriteLine("Введіть марку автомобіля");
            Car.Name =  Console.ReadLine();

            Console.WriteLine("Введіть модель автомобіля");
            Car.model = Console.ReadLine();

            Console.WriteLine("Введіть країну створення");
            Car.countryCreator = Console.ReadLine();

            Console.WriteLine("Введіть рік створення");
            Car.ageOfCreating = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть кількість кінських сил");
            Car.hp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть крутящий момент автомобіля");
            Car.et = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть ціну автомобіля");
            Car.cost = Convert.ToDouble(Console.ReadLine(), NumberFormatInfo);

            Console.WriteLine("Чи рекомендуєте цей автомобіль? Y-Так N-Ні");
            result = Car.Recomendation(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Дані про автомобіль");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Марка автомобіля: " + Car.Name);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Модель автомобіля: " + Car.model);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Країна створення автомобіля: " + Car.countryCreator);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Рік створення автомобіля: " + Car.ageOfCreating);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Кількість кінських сил автомобіля: " + Car.hp);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Кількість крутящого моменту автомобіля: " + Car.et);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ціна автомобіля: " + Car.cost + "$");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Чи рекомендую цей автомобіль? " + result);
        }
    }
}