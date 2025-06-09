using System.Diagnostics.Metrics;
using System;
namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP(); 
            TestWithSRP();
            Console.ReadKey();
        }


        private static void TestWithoutSRP()
        {
            var account =
                new Befor_SRP.Account("Ali", "Ali2025@example.com", 30000m);
            account.MakeTransaction(700);
            account.MakeTransaction(-17000);
        }

        private static void TestWithSRP()
        {
            var account =
                new After_SRP.Account("Ali", "2025@example.com", 30000m);

            var accountService = new After_SRP.AccountService();
            accountService.Deposit(account, 700);
            accountService.WithDraw(account, 17000);
        }


    }
}