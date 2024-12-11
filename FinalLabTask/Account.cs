using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask
{
    internal class Account
    {
        private int id;
        private string title;
        private DateTime openingdate;
        private double balance;

        public int Id
        {
            get { return this.id; }
            set { id = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { title = value; }
        }
        public DateTime OpeningDate
        {
            get { return this.openingdate; }
            set { openingdate = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { balance = value; }
        }

        internal Account(int id, string title, DateTime openingdate, double balance)
        {
            this.id = id;
            this.title = title;
            this.openingdate = openingdate;
            this.balance = balance;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID: {id}, Title: {title}, Opening Date: {openingdate}, Balance: {balance}");
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
