using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {


            BankAccount firstAccount;

            firstAccount = new BankAccount();
            firstAccount.accountNumber = 10000001;
            firstAccount.Deposit(3000.00);

            Console.WriteLine("Acount {0} has balance {1}", firstAccount.accountNumber, firstAccount.Balance);
            Console.WriteLine(firstAccount.Withdraw(300));




            Console.WriteLine(firstAccount.Balance);





            Console.ReadLine();





        }
    }
}
