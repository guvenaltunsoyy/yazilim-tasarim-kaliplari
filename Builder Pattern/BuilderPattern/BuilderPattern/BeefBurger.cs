namespace BuilderPattern
{
    public class BeefBurger : BaseBurgerModel, IHamburgerBuilder
    {
        public BeefBurger()
        {
            _burger = new Hamburger();
        }
        
        public void SetName()
        {
            _burger.Name = "Dana Burger";
        }
        public void SetMeat()
        {
            _burger.MeatWeight = 150;
        }

        public void SetCheese()
        {
            _burger.Cheese = CheeseTypes.Cheddar;
        }

        public void SetBread()
        {
            _burger.Bread = "Aktif Karbonlu Ekmek";
        }

        public void SetGarniture()
        {
            _burger.Garniture = "Barbekü sos, hardal, mayonez";
        }

        public void SetTypeOfMeat()
        {
            _burger.TypeOfMeat = TypeOfMeat.Dana;
        }
    }
}