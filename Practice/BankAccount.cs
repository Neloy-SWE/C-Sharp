using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOOP.Practice
{
    internal class BankAccount
    {
        private int balance;
        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if(balance>=amount)
            {
                balance-=amount;
            }
            else
            {
                Console.WriteLine("Not enough money !!");
            }
        }

        public int GetBalance() { return balance; }
    }
}
