namespace BuilderPattern
{
    public class ChickenBurger: BaseBurgerModel, IHamburgerBuilder
    {
        public ChickenBurger()
        {
            _burger = new Hamburger();
        }
        
        public void SetMeat()
        {
            _burger.MeatWeight = 180;
        }

        public void SetName()
        {
            _burger.Name = "Tavuk Burger";
        }
        public void SetCheese()
        {
            _burger.Cheese = CheeseTypes.WhiteCheese;
        }

        public void SetBread()
        {
            _burger.Bread = "Buğdaylı ekmek";
        }

        public void SetGarniture()
        {
            _burger.Garniture = "Ketçap, mayonez, hardal, yeşillik";
        }

        public void SetTypeOfMeat()
        {
            _burger.TypeOfMeat = TypeOfMeat.Tavuk;
        }
    }
}