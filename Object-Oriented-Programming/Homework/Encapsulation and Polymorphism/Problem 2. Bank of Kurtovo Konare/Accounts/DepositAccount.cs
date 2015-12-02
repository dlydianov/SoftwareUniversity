using System;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class DepositAccount: Accounts, IWidthraw
    {
        public DepositAccount(Customer customer, decimal moneyTransaction, decimal interestRate)
            : base(customer, moneyTransaction, interestRate)
        {

        }      

        public void Widthraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal InterestRateForAPeriodCalculation(int months)
        {
             if (this.Balance < 1000)
            {
                return 0;
            }

            return base.InterestRateForAPeriodCalculation(months);

        }
    }
}
