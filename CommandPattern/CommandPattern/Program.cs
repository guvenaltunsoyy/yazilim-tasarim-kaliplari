using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager("Samsung Note 9", 10);

            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            StockController stockController = new StockController();

            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(sellStock);
            stockController.RemoveOrder(sellStock);


            stockController.PlaceOrders();
        }
    }
}