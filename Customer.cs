using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Customer
    {
        private Backpack backpack;
        private Wallet wallet;
        private List<double> moneyInHand;

        public Customer()
        {
            this.backpack = new Backpack();
            this.wallet = new Wallet();
        }
        //public List<Coin>()
        //{
        //    List<Coin> coins = new List<Coin>();
        //    return coins;
        //}
        public void SelectCoin()
        {
            int selection = 0;
            Console.Clear();
            this.wallet.DisplayCoins();
            this.wallet.DisplayCoinMenu();
            bool validInt = false;
            while (!validInt || !(selection == 1 || selection == 2 || selection == 3 || selection == 4))
            {
                Console.WriteLine("Please make a valid choice");
                validInt = !Int32.TryParse(Console.ReadLine(), out selection);
                Console.WriteLine($"You selected {this.wallet.Change[selection].Type}.");
            }
            if (this.wallet.Change[selection-1].Quantity == 0)
            {
                Console.WriteLine("You don't have any of those in your wallet.");
                Console.WriteLine("Please make another choice");
                Console.ReadLine();
                SelectCoin();
            }
            this.wallet.Change[selection-1].Quantity--;
            PutCoinInHand(this.wallet.Change[selection - 1].Value);
        }

        public void SelectSoda(SodaMachine sodaMachine)
        {
            int selection = 0;
            sodaMachine.DisplaySodas();
            bool validInt = false;
            while (!validInt || !(selection == 1 || selection == 2 || selection == 3))
            {
                Console.WriteLine("Please make a valid choice");
                validInt = !Int32.TryParse(Console.ReadLine(), out selection);
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
            double change = DepositMoney(soda.Price);
            sodaMachine.sodas[selection - 1].Quantity--;
            this.backpack.AddSoda(soda);
        }


        public double DepositMoney(double price)
        {
            double totalInHand = 0;
            foreach(double coinValue in moneyInHand)
            {
                totalInHand += coinValue;
            }
            while(totalInHand < price)
            {
                if (this.wallet.IsEmpty())
                {
                    Console.WriteLine("You don't have any more coins!");
                    Console.ReadLine();
                }
                else
                {
                    SelectCoin();
                }
            }
            return totalInHand - price;
        }
        public void PutCoinInHand(double value)
        {
            this.moneyInHand.Add(value);
            double total = 0;
            foreach(double coin in this.moneyInHand)
            {
                total += coin;
            }
            Console.WriteLine($"You now have {total} in hand.");
        }

}
