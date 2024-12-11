using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask
{
    internal class CurrentAccount : Account
    {
        private double yearlyCharge;

        public double YearlyCharge
        {
            get { return this.yearlyCharge; }
            set { yearlyCharge = value; }
        }

        internal CurrentAccount(int id, string title, DateTime openingdate, double balance, double yearlyCharge)
            : base(id, title, openingdate, balance)
        {
            this.yearlyCharge = yearlyCharge;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Yearly Charge: {yearlyCharge}");
        }

        public override void Withdraw(double amount)
        {
            double transactionFee = 10;
            if (Balance >= amount + transactionFee)
            {
                base.Withdraw(amount + transactionFee);
                Console.WriteLine($"Withdrawn: {amount}, Transaction Fee: {transactionFee}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance to cover the withdrawal amount and transaction fee.");
            }
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }
    }
}
