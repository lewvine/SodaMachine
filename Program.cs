namespace SodaMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            SodaMachine sodaMachine = new SodaMachine();

            int selection = customer.SelectSoda(sodaMachine);

            //The selected Soda;
            Soda selectedSoda = new Soda(
                sodaMachine.sodas[selection - 1].Flavor,
                sodaMachine.sodas[selection - 1].Price,
                1
            );
            List<double> deposit = customer.GetCoins(selectedSoda.Price);

            customer.DepositCoins(sodaMachine, deposit);
            //sodaMachine.DispenseSoda(selectedSoda);
            //List<double> change = sodaMachine.DispenseChange(deposit, selectedSoda.Price);
            //customer.wallet.AddCoins(change);
            customer.backpack.AddSoda(selectedSoda);

            sodaMachine.sodas[selection - 1].Quantity--;
            //this.backpack.AddSoda(soda);
            //PutCoinInHand(this.wallet.Change[selection - 1].Value);
        }

    }
}