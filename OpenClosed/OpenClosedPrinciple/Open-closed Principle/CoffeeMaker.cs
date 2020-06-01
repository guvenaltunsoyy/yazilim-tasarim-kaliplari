using System;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class CoffeeMaker
    {
        private ICoffeeMaker _coffeeMaker;

        public CoffeeMaker(ICoffeeMaker coffee)
        {
            _coffeeMaker = coffee;
        }
        public CoffeeMaker()
        {
            Console.WriteLine("Kahve secimi yapmadiniz.");
        }
        public async Task<Coffee> GetCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small, bool takeAWay = false)
        {
            return await _coffeeMaker.MakeCoffee(customerName, sugar, withMilk, size, takeAWay);
        }
    }
}