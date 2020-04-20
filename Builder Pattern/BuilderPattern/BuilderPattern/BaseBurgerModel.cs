namespace BuilderPattern
{
    public class BaseBurgerModel
    {
        protected Hamburger _burger;
        public Hamburger Burger
        {
            get { return _burger; }
        }
        
        public override string ToString()
        {
            return $"{_burger.Name} hamburgeriniz {_burger.Bread} ile {_burger.MeatWeight} gram {_burger.TypeOfMeat.ToString()} eti ve {_burger.Garniture} {_burger.Cheese.ToString()} eşliğinde hazırlanmıştır.";
        }
    }
}