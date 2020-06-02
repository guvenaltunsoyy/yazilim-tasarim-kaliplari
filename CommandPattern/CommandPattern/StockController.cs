using System.Collections.Generic;

namespace CommandPattern
{
    public class StockController
    {
        private List<IOrderCommand> _orderCommands;

        public StockController()
        {
            _orderCommands = new List<IOrderCommand>();
        }

        public void TakeOrder(IOrderCommand command)
        {
            _orderCommands.Add(command);
        }
        public void RemoveOrder(IOrderCommand command)
        {
            _orderCommands.Remove(command);
        }

        public void PlaceOrders()
        {
            foreach (var command in _orderCommands)
            {
                command.Execute();
            }
            _orderCommands.Clear();
        }
    }
}