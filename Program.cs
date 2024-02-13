namespace SodaMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            SodaMachine sodaMachine = new SodaMachine();

            Soda selectedSoda = customer.SelectSoda(sodaMachine);

            List<double> deposit = customer.GetCoins(selectedSoda.Price);
            double totalDeposit = deposit.Sum();
            while(deposit.Count > 0)
            {
                customer.DepositCoin(sodaMachine, deposit[0]);
            }

            sodaMachine.DispenseSoda(selectedSoda);
            List<Coin> change = sodaMachine.DispenseChange(totalDeposit, selectedSoda.Price);
            foreach(Coin coin in change)
            {
                customer.AddToWallet(coin);
            }
            customer.backpack.AddSoda(selectedSoda);
        }

    }
}