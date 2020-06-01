using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public class Filtre : Coffee, ICoffeeMaker
    {
        public async Task<Coffee> MakeCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small,
            bool takeAWay = false)
        {
            CoffeeName = "Filtre";
            CustomerName = customerName;
            Sugar = sugar;
            WithMilk = withMilk;
            Size = size;
            CoffeeRatio = CoffeeRatio.Medium;
            TakeAWay = takeAWay;
            CookingTime = withMilk ? CookingTime.MediumCoffeeWithMilk : CookingTime.MediumCoffee;
            ReadingInfo();
            await Task.Delay((int) (CookingTime));
            ReadyInfo();
            return this;
        }
    }
}