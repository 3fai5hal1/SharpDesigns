using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[2];

            accounts[0] = new SavingAccount(1, "Saving Account", DateTime.Now, 0, 12);
            accounts[1] = new CurrentAccount(2, "Current Account", DateTime.Now, 2000, 500);

            Console.WriteLine("Initial Account Information:");
            foreach (var account in accounts)
            {
                account.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Performing Transactions:");
            accounts[0].Deposit(500);
            accounts[0].Withdraw(500);
            accounts[1].Deposit(1000);
            accounts[1].Withdraw(1500);

            Console.WriteLine("Updated Account Information:");
            foreach (var account in accounts)
            {
                account.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
