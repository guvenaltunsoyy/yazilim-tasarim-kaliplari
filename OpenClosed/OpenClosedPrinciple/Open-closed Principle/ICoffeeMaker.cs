using System.Threading.Tasks;

namespace Open_closed_Principle
{
    public interface ICoffeeMaker
    {
        Task<Coffee> MakeCoffee(string customerName = null, int sugar = 0, bool withMilk = false, Size size = Size.Small, bool takeAWay = false);
    }
}