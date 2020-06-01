using System;

namespace Open_closed_Principle
{
    public abstract class Coffee
    {
        public string CoffeeName { get; set; }
        public string CustomerName { get; set; }
        public bool TakeAWay { get; set; }
        public int Sugar { get; set; }
        public bool WithMilk { get; set; }
        public CoffeeRatio CoffeeRatio { get; set; }
        public Size Size { get; set; }
        public CookingTime CookingTime { get; set; }
        public void ReadingInfo()
        {
            int time = (int) CookingTime;
            Console.WriteLine($"Kahvenizin hazirlanma suresi {time/1000} saniyedir. Lutfen bekleyiniz..");
        }
        public void ReadyInfo()
        {
            Console.WriteLine($"Kahven {CoffeeName}, {Size} boyutunda ve {CoffeeRatio} orani ile hazir {CustomerName}!");
        }
    }
}