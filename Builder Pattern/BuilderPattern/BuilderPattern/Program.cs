using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorHamburger createHamburger = new DirectorHamburger();
            
            IHamburgerBuilder chickenBurger = new ChickenBurger();
            IHamburgerBuilder beefBurger = new BeefBurger();
            
            createHamburger.CreateBurger(chickenBurger);
            createHamburger.CreateBurger(beefBurger);

            Console.WriteLine(chickenBurger.ToString());
            Console.WriteLine(beefBurger.ToString());
            Console.ReadKey();

        }
    }
}