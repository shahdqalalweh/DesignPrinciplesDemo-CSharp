

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Liskov_Substitution_Principle.Before_LSP.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000); 

            var account = new Liskov_Substitution_Principle.After_LSP.CheckingAccount("Issam", 10_000);
            account.Withdraw(10000);

            //var account = new Liskov_Substitution_Principle.Before_LSP.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000); // won't work
            Console.ReadKey();
        }
    }
}