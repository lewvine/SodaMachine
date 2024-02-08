using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Soda
    {
        private double price;
        private string? flavor;
        private int quantity;

        public double Price { get { return price; } set { this.price = value; } }
        public string Flavor { get { return flavor; } set { this.flavor = value; } }
        public int Quantity { get { return quantity; } set { this.quantity = value; } }

        public Soda(string flavor, double price, int quantity)
        {
            this.flavor = flavor;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
