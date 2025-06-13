using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Before_LSP
{
    class SavingAccount : Account
    {
        public SavingAccount(string name, decimal balance)
            : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
