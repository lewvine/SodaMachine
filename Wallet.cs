using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Wallet
    {
        private List<Coin> change;

        public Wallet()
        {
            this.change = new List<Coin>();
            Coin quarters = new Coin("Quarter", .25, 16);
            Coin dimes = new Coin("Dime", .1, 5);
            Coin nickels = new Coin("Nickel", .05, 9);
            Coin pennys = new Coin("Penny", .01, 5);
            this.change.Add(quarters);
            this.change.Add(dimes);
            this.change.Add(nickels);
            this.change.Add(pennys);

        }


        //public double GetTotalChange()
        //{
        //    double totalChange = 0;
        //    foreach(Coin coin in change)
        //    {
        //        totalChange += coin.Value;
        //    }
        //    return totalChange;
        //}
    }
}
