using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CommandPattern
{

    /// <summar>
    /// The Invoker Class
    /// </summar>

    public class Patron
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private FastFoodOrder _order;

        public Patron()
        {
            _order = new FastFoodOrder();
        }

        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _order.ExecuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }
    }

    /// <summary>
    /// The Reciever
    /// </summary>

    public class FastFoodOrder
    {
        public List<MenuItem> currentItems { get; set; }
        public FastFoodOrder()
        {
            currentItems = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.currentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach(var item in currentItems)
            {
                item.Display();
            }
            WriteLine("-----------------------");
        }
    }

    /// <summary>
    /// Represents an item being ordered from this restaurant.
    /// </summary>

    public class MenuItem
    {
        public string Name { set; get; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            WriteLine("\nName: {0}", Name);
            WriteLine("\nName: {0}", Amount.ToString());
            WriteLine("\nName: ${0}", Price.ToString());
        }
    }

    /// <summary>
    /// The Command Abstract Class
    /// </summary>
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }

    /// <summary>
    /// A Concerete Command
    /// </summary>

    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItem, MenuItem newItem)
        {
            currentItem.Add(newItem);
        }
    }

    /// <summary>
    /// A Concerete Command
    /// </summary>
    public class RemoveCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Remove(currentItems.Where(x => x.Name == newItem.Name).FirstOrDefault());
        }
    }

    /// <summary>
    /// A Concerete Command
    /// </summary>
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }

    public class CommandFactory
    {
        //Factory method
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                case 3:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }

}
