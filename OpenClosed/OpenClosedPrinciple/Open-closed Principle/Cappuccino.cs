using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class Cappuccino:Coffee, ICoffeeMaker
    {
        public async Task<Coffee> MakeCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small, bool takeAWay = false)
        {
            CoffeeName = "Cappuccino";
            CustomerName = customerName;
            Sugar = sugar;
            WithMilk = withMilk;
            Size = size;
            CoffeeRatio = CoffeeRatio.Medium;
            TakeAWay = takeAWay;
            CookingTime = withMilk ? CookingTime.LightCoffeeWithMilk : CookingTime.LightCoffee;
            ReadingInfo();
            await Task.Delay((int) (CookingTime));
            ReadyInfo();
            return this;
        }
    }
}