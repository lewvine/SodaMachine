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

        public void DispenseSoda(Soda soda)
        {
            Soda selectedVariety = this.sodas.Find(s => s.Flavor == soda.Flavor);
            selectedVariety.Quantity--;
        }

        public List<Coin> DispenseChange(double deposit, double price)
        {
            Console.WriteLine($"You deposited {deposit} and the price was {price}.");
            double totalChange = deposit - price;
            List<double> change = new List<double>();
            while(totalChange > 0)
            {
                if(totalChange >= .25)
                {
                    totalChange -= .25;
                    change.Add(.25);
                }
                else if(totalChange >= .10)
                {
                    totalChange -= .10;
                    change.Add(.10);
                }
                else if(totalChange >= .05)
                {
                    totalChange -= .05;
                    change.Add(.05);
                }
                else
                {
                    totalChange -= .01;
                    change.Add(.01);
                }
            }
            return ConvertToCoins(change); 
        }

        public List<Coin> ConvertToCoins(List<double> changeInDoubles)
        {
            List<Coin> changeInCoins = new List<Coin>();
            foreach(double value in changeInDoubles)
            {
                if (value == .25)
                {
                    if(changeInCoins.Exists(c => c.Value == value))
                    {
                        changeInCoins.Find(c => c.Value == value).Quantity++;
                    } 
                    else
                    {
                        Coin quarter = new Coin("Quarter", .25, 1);
                        changeInCoins.Add(quarter);
                    }

                }
                else if (value == .10)
                {
                    if (changeInCoins.Exists(c => c.Value == value))
                    {
                        changeInCoins.Find(c => c.Value == value).Quantity++;
                    }
                    else
                    {
                        Coin dime = new Coin("Dime", .10, 1);
                        changeInCoins.Add(dime);
                    }
                }
                else if (value == .05)
                {
                    if (changeInCoins.Exists(c => c.Value == value))
                    {
                        changeInCoins.Find(c => c.Value == value).Quantity++;
                    }
                    else
                    {
                        Coin nickel = new Coin("Nickel", .05, 1);
                        changeInCoins.Add(nickel);
                    }
                }
                else
                {
                    if (changeInCoins.Exists(c => c.Value == value))
                    {
                        changeInCoins.Find(c => c.Value == value).Quantity++;
                    }
                    else
                    {
                        Coin penny = new Coin("Penny", .01, 1);
                        changeInCoins.Add(penny);
                    }
                }
            }
            return changeInCoins;
        }

        public void SelectSoda()
        {
            DisplaySodas();

        }
    }
}
