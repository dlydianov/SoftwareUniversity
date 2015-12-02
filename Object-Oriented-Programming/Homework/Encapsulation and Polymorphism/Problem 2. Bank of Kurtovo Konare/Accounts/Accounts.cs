using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class Accounts : IAccount, IInterestRateForAPeriodCalculation, IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Accounts(Customer customer, decimal moneyTransaction, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = moneyTransaction;
            this.InterestRate = interestRate;
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("InterestRate", "Interest Rate cannot be a negative number!");
                }
                this.interestRate = value;
            }
        }
        public virtual decimal InterestRateForAPeriodCalculation(int months)
        {
            decimal interestRateForThePeriod = this.Balance * (1 + ((this.InterestRate / 100) * months));
            return interestRateForThePeriod - this.Balance;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }


    }
}
