namespace BuilderPattern
{
    public class DirectorHamburger
    {
        public void CreateBurger(IHamburgerBuilder builder)
        {
            builder.SetBread();
            builder.SetCheese();
            builder.SetGarniture();
            builder.SetMeat();
            builder.SetTypeOfMeat();
            builder.SetName();
        }
    }
}