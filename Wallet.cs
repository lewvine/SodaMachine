﻿using System;
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

        public void DisplayCoins()
        {
            Console.WriteLine("Your wallet contains:");
            foreach (Coin coin in this.change)
            {
                Console.WriteLine($"{coin.Quantity} - {coin.Type}(s)");
            }
            DisplayCoinMenu();

        }

        public void DisplayCoinMenu()
        {
            Console.WriteLine("PLEASE CHOOSE A COIN:");
            Console.WriteLine("Select (1) for a Quarter");
            Console.WriteLine("Select (2) for a Dime");
            Console.WriteLine("Select (3) for a Nickel");
            Console.WriteLine("Select (4) for a Penny");;
        }

        public int SelectCoin()
        {
            int selection = 0;
            DisplayCoins();
            DisplayCoinMenu();
            bool validInt = false;
            while (!validInt || (selection != 1 || selection != 2 || selection != 3 || selection != 4))
            {
                Console.WriteLine("Please make a valid choice");
                validInt = !Int32.TryParse(Console.ReadLine(), out selection);
            }
            return selection;
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
