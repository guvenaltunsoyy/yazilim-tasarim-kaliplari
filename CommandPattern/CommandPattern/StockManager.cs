using System;

namespace CommandPattern
{
    public class StockManager
    {
        private string _name;
        private int _quantity;

        public StockManager(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Buy()
        {
            _quantity++;
            Console.WriteLine($"Stock: {_name}, {_quantity} bought!");
        }

        public void Sell()
        {
            _quantity--;
            Console.WriteLine($"Stock: {_name}, {_quantity} sold!");
        }
    }
}