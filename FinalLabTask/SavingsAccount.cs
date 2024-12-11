using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask
{

    internal class SavingAccount : Account
    {
        private int duration;

        public int Duration
        {
            get { return this.duration; }
            set { duration = value; }
        }

        internal SavingAccount(int id, string title, DateTime openingdate, double balance, int duration)
            : base(id, title, openingdate, balance)
        {
            this.duration = duration;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Duration: {duration}");
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500)
            {
                base.Withdraw(amount);
                Console.WriteLine($"Withdrawn: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Cannot withdraw. Minimum balance of 500 must be maintained.");
            }
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }
    }
}
