using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class SodaMachine
    {
        public List<Soda> sodas;
        public List<Coin> coins;

        public SodaMachine()
        {
            //Add coins
            this.coins = new List<Coin>();
            Coin quarters = new Coin("Quarter", .25, 20);
            Coin dimes = new Coin("Dime", .1, 10);
            Coin nickels = new Coin("Nickel", .05, 20);
            Coin pennys = new Coin("Penny", .01, 50);
            this.coins.Add(quarters);
            this.coins.Add(dimes);
            this.coins.Add(nickels);
            this.coins.Add(pennys);

            //Add sodas
            this.sodas = new List<Soda>();
            Soda orange = new Soda("Orange", .06, 30);
            Soda cola = new Soda("Cola", .35, 30);
            Soda rootBeer = new Soda("Root Beer", .60, 30);
            this.sodas.Add(orange);
            this.sodas.Add(cola);
            this.sodas.Add(rootBeer);

        }
    }
}
