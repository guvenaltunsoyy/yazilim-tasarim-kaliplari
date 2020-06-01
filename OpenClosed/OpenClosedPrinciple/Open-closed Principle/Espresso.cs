using System;
using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class Espresso :Coffee, ICoffeeMaker
    {
        public async Task<Coffee> MakeCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small, bool takeAWay = false)
        {
            CoffeeName = "Espresso";
            CustomerName = customerName;
            Sugar = sugar;
            WithMilk = withMilk;
            Size = size;
            CoffeeRatio = CoffeeRatio.Dark;
            TakeAWay = takeAWay;
            CookingTime = withMilk ? CookingTime.DarkCoffeeWithMilk : CookingTime.DarkCoffee;
            ReadingInfo();
            await Task.Delay((int) (CookingTime));
            ReadyInfo();
            return this;
        }
    }
}