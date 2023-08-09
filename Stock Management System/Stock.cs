using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    class Stock
    {
        private string name;
        private int quantity;
        private double price;

        public Stock(string _name, int _quantity, double _price)
        {
            this.name = _name;
            this.quantity = _quantity;
            this.price = _price;
        }

        public string GetName()
        {
            return name;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public double GetPrice()
        {
            return price;
        }
        public void removeQuantity(int quantityToRemove)
        {
            if (quantityToRemove <= quantity)
            {
                quantity -= quantityToRemove;
            }
            else
            {
                Console.WriteLine("Not enough quanity to remove.");
            }
        }
        public string toString()
        {
            return name + ", quantity: " + quantity + ", price: R" + price;
        }

    }
}
