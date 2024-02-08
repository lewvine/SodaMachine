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
            FillWallet();

        }

        public void FillWallet()
        {
            Quarter quarter1 = new Quarter();
            Quarter quarter2 = new Quarter();
            Quarter quarter3 = new Quarter();
            Quarter quarter4 = new Quarter();
            Quarter quarter5 = new Quarter();
            Quarter quarter6 = new Quarter();
            Quarter quarter7 = new Quarter();
            Quarter quarter8 = new Quarter();
            Quarter quarter9 = new Quarter();
            Quarter quarter10 = new Quarter();
            Dime dime1 = new Dime();
            Dime dime2 = new Dime();
            Dime dime3 = new Dime();
            Dime dime4 = new Dime();
            Dime dime5 = new Dime();
            Dime dime6 = new Dime();
            Dime dime7 = new Dime();
            Dime dime8 = new Dime();
            Dime dime9 = new Dime();
            Dime dime10 = new Dime();
            Nickel nickel1 = new Nickel();
            Nickel nickel2 = new Nickel();
            Nickel nickel3 = new Nickel();
            Nickel nickel4 = new Nickel();
            Nickel nickel5 = new Nickel();
            Nickel nickel6 = new Nickel();
            Nickel nickel7 = new Nickel();
            Nickel nickel8 = new Nickel();
            Nickel nickel9 = new Nickel();
            Nickel nickel10 = new Nickel();
            Penny penny1 = new Penny();
            Penny penny2 = new Penny();
            Penny penny3 = new Penny();
            Penny penny4 = new Penny();
            Penny penny5 = new Penny();
            Penny penny6 = new Penny();
            Penny penny7 = new Penny();
            Penny penny8 = new Penny();
            Penny penny9 = new Penny();
            Penny penny10 = new Penny();
            this.change.Add(quarter1);
            this.change.Add(quarter2);
            this.change.Add(quarter3);
            this.change.Add(quarter4);
            this.change.Add(quarter5);
            this.change.Add(quarter6);
            this.change.Add(quarter7);
            this.change.Add(quarter8);
            this.change.Add(quarter9);
            this.change.Add(quarter10);
            this.change.Add(dime1);
            this.change.Add(dime2);
            this.change.Add(dime3);
            this.change.Add(dime4);
            this.change.Add(dime5);
            this.change.Add(dime6);
            this.change.Add(dime7);
            this.change.Add(dime8);
            this.change.Add(dime9);
            this.change.Add(dime10);
            this.change.Add(nickel1);
            this.change.Add(nickel2);
            this.change.Add(nickel3);
            this.change.Add(nickel4);
            this.change.Add(nickel5);
            this.change.Add(nickel6);
            this.change.Add(nickel7);
            this.change.Add(nickel8);
            this.change.Add(nickel9);
            this.change.Add(nickel10);
            this.change.Add(penny1);
            this.change.Add(penny2);
            this.change.Add(penny3);
            this.change.Add(penny4);
            this.change.Add(penny5);
            this.change.Add(penny6);
            this.change.Add(penny7);
            this.change.Add(penny8);
            this.change.Add(penny9);
            this.change.Add(penny10);
        }

        public double GetTotalChange()
        {
            double totalChange = 0;
            foreach(Coin coin in change)
            {
                totalChange += coin.Value;
            }
            return totalChange;
        }
    }
}
