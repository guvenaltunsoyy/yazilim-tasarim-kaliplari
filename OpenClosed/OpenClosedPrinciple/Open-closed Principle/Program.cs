using System;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CoffeeMaker _coffeeMaker;
            Coffee _coffee;

            Console.WriteLine("Kahve dukkanina hosgeldiniz! Isminiz nedir?");
            string customerName = Console.ReadLine();

            Console.WriteLine(
                "Lutfen almak istediginiz kahve turunu seciniz.\n1.Espresso\n2.Cappuccino\n3.Cafe Latte\n4.Macchiato\n5.Filtre");
            int coffeeType = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Kahve boyutu seciniz.\n1.Small\n2.Medium\n3.Large");
            Size size = (Size) int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Sut ister misiniz? Evet => 1 | Hayir => 0");
            int withMilk = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Kac seker istersiniz?");
            int sugar = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("Paket ister misiniz? Evet => 1 | Hayir => 0");
            int takeAWay = int.Parse(Console.ReadLine() ?? "0");
            
            switch (coffeeType)
            {
                case 1:
                    _coffeeMaker = new CoffeeMaker(new Espresso());
                    break;
                case 2:
                    _coffeeMaker = new CoffeeMaker(new Cappuccino());
                    break;
                case 3:
                    _coffeeMaker = new CoffeeMaker(new CafeLatte());
                    break;
                case 4:
                    _coffeeMaker = new CoffeeMaker(new Macchiato());
                    break;
                case 5:
                    _coffeeMaker = new CoffeeMaker(new Filtre());
                    break;
                default:
                    _coffeeMaker = new CoffeeMaker();
                    break;
            }
             _coffee = await _coffeeMaker.GetCoffee(customerName, sugar, withMilk != 0, size, takeAWay != 0);
             Console.WriteLine("Iyi gunler!");
        }
    }
}