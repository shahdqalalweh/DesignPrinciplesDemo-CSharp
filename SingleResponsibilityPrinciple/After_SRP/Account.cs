﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.After_SRP
{
    // فرق تسد
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
        }
    }
}
