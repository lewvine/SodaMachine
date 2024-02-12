using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

        public void Transaction(List<Coin> money, int sodaCoice)
        {

        }

        public void DisplaySodas()
        {
            Console.WriteLine("Welcome to the Soda Machine.");
            Console.WriteLine("Please make a choice from the following:");
            int selection = 0;
            int count = 1;
            foreach(Soda soda in this.sodas)
            {
                Console.WriteLine($"Select ({count}) for {soda.Flavor} - {soda.Price} - # Left {soda.Quantity}");
                count++;
            }
        }



        public void SelectSoda()
        {
            DisplaySodas();

        }
    }
}
