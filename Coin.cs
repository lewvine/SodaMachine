using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Coin
    {
        private double value;
        private string type;
        private int quantity;

        public double Value { get { return value;} set { this.value = value; } }
        public string Type { get { return type; } set { this.type = value; } }
        public int Quantity { get { return quantity; } set { this.quantity = value; } }

        public Coin(string type, double value, int quantity)
        {
            this.type = type;
            this.value = value;
            this.quantity = quantity;
        }
    }
}
