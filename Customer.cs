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


        public Customer()
        {
            this.backpack = new Backpack();
            this.wallet = new Wallet();
        }
        public List<Coin>SelectCoins()
        {
            List<Coin> coins = new List<Coin>();
            return coins;
        }

        public DisplayWallet()
        {

        }
    }
}
