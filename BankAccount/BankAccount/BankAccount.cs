using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public int accountNumber;
        private double balance;



        public BankAccount()
        {

        }

        public double Balance { get => balance; set => balance = value; }



        public double Deposit(double _value)
        {
            return this.balance += _value;


        }

        public bool Withdraw(double amount)
        {
            bool result = true;
            if (balance >= amount)
            {
                balance = balance - amount;

            }
            else
            {
                return false;

            }

            return result;

        }
    }
}
