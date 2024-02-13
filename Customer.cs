using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Customer
    {
        public Backpack backpack;
        private Wallet wallet;
        private List<double> moneyInHand;

        public Customer()
        {
            this.backpack = new Backpack();
            this.wallet = new Wallet();
            this.moneyInHand = new List<double>();
        }
        //public List<Coin>()
        //{
        //    List<Coin> coins = new List<Coin>();
        //    return coins;
        //}
        public double SelectCoin()
        {
            int selection = 0;
            Console.Clear();
            DisplayMoneyInHand();
            this.wallet.DisplayCoins();
            this.wallet.DisplayCoinMenu();
            bool validInt = false;
            while (!validInt && (selection != 1 || selection != 2 || selection != 3 || selection != 4))
            {
                Console.WriteLine("Please make a valid choice");
                validInt = Int32.TryParse(Console.ReadLine(), out selection);
                if(validInt)
                {
                    Console.WriteLine($"You selected {this.wallet.Change[selection - 1].Type}.");
                }
            }
            if (this.wallet.Change[selection - 1].Quantity == 0)
            {
                Console.WriteLine("You don't have any of those in your wallet.");
                Console.WriteLine("Please make another choice");
                Console.ReadLine();
                SelectCoin();
            }
            this.wallet.Change[selection - 1].Quantity--;
            return this.wallet.Change[selection - 1].Value;
        }

        public Soda SelectSoda(SodaMachine sodaMachine)
        {
            int selection = 0;
            sodaMachine.DisplaySodas();
            bool validInt = false;
            while (!validInt || !(selection == 1 || selection == 2 || selection == 3))
            {
                Console.WriteLine("Please make a valid choice");
                validInt = Int32.TryParse(Console.ReadLine(), out selection);
                Console.WriteLine($"You selected {sodaMachine.sodas[selection - 1].Flavor}.");
            }
            if (sodaMachine.sodas[selection - 1].Quantity == 0)
            {
                Console.WriteLine("That soda is out of stock.");
                Console.WriteLine("Please make another choice");
                Console.ReadLine();
                SelectSoda(sodaMachine);
            }
            Soda soda = new Soda(
                sodaMachine.sodas[selection - 1].Flavor,
                sodaMachine.sodas[selection - 1].Price,
                1
            );
            return soda;
        }

        public void DisplayMoneyInHand()
        {
            Console.WriteLine($"You have {moneyInHand.Sum()} money in hand.");
        }

        public void DepositCoin(SodaMachine sodaMachine, double value)
        {
            switch(value)
            {
                case .01:
                    sodaMachine.coins.Find(c => c.Type == "Penny").Quantity++;
                    moneyInHand.Remove(value);
                    break;
                case .05:
                    sodaMachine.coins.Find(c => c.Type == "Nickel").Quantity++;
                    moneyInHand.Remove(value);
                    break;
                case .1:
                    sodaMachine.coins.Find(c => c.Type == "Dime").Quantity++;
                    moneyInHand.Remove(value);
                    break;
                case .25:
                    sodaMachine.coins.Find(c => c.Type == "Quarter").Quantity++;
                    moneyInHand.Remove(value);
                    break;
            }
        }
        public List<double> GetCoins(double price)
        {
            while (moneyInHand.Sum() < price)
            {
                if (this.wallet.IsEmpty())
                {
                    Console.WriteLine("You don't have any more coins!");
                    Console.ReadLine();
                }
                else
                {
                    double value = SelectCoin();
                    moneyInHand.Add(value);
                }
            }
            return moneyInHand;
        }

        public void AddToWallet(Coin coin)
        {
            double value = coin.Value;

            if (value == .25)
            {
                Console.WriteLine("A quarter was added to your wallet");
                if (this.wallet.Change.Exists(c => c.Value == value))
                {
                    this.wallet.Change.Find(c => c.Value == value).Quantity++;
                }
                else
                {
                    Coin quarter = new Coin("Quarter", .25, 1);
                    this.wallet.Change.Add(quarter);
                }

            }
            else if (value == .10)
            {
                Console.WriteLine("A dime was added to your wallet");
                if (this.wallet.Change.Exists(c => c.Value == value))
                {
                    this.wallet.Change.Find(c => c.Value == value).Quantity++;
                }
                else
                {
                    Coin dime = new Coin("Dime", .10, 1);
                    this.wallet.Change.Add(dime);
                }
            }
            else if (value == .05)
            {
                Console.WriteLine("A nickel was added to your wallet");
                if (this.wallet.Change.Exists(c => c.Value == value))
                {
                    this.wallet.Change.Find(c => c.Value == value).Quantity++;
                }
                else
                {
                    Coin nickel = new Coin("Nickel", .05, 1);
                    this.wallet.Change.Add(nickel);
                }
            }
            else
            {
                Console.WriteLine("A penny was added to your wallet");
                if (this.wallet.Change.Exists(c => c.Value == value))
                {
                    this.wallet.Change.Find(c => c.Value == value).Quantity++;
                }
                else
                {
                    Coin penny = new Coin("Penny", .01, 1);
                    this.wallet.Change.Add(penny);
                }
            }
        }
    }
}
