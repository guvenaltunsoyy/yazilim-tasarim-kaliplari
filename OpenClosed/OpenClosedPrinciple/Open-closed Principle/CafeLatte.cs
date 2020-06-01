using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class CafeLatte:Coffee, ICoffeeMaker
    {
        public async Task<Coffee> MakeCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small, bool takeAWay = false)
        {
            CoffeeName = "Cafe Latte";
            CustomerName = customerName;
            Sugar = sugar;
            WithMilk = true;
            Size = size;
            CoffeeRatio = CoffeeRatio.Light;
            TakeAWay = takeAWay;
            CookingTime = withMilk ? CookingTime.LightCoffeeWithMilk : CookingTime.LightCoffee;
            ReadingInfo();
            await Task.Delay((int) (CookingTime));
            ReadyInfo();
            return this;
        }
    }
}