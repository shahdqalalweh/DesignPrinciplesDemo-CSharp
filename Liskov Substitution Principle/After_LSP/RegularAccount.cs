using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.After_LSP
{
    abstract class RegularAccount : Account
    {
        protected RegularAccount(string name, decimal balance)
            : base(name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public abstract void Withdraw(decimal amount);
    }
}
