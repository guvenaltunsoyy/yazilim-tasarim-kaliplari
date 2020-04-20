namespace BuilderPattern
{
    public interface IHamburgerBuilder
    {
        void SetMeat();
        void SetName();
        void SetCheese();
        void SetBread();
        void SetGarniture();
        void SetTypeOfMeat();
    }
}