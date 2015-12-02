using System;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class MortgageAccount: Accounts
    {
        public MortgageAccount(Customer customer, decimal moneyTransaction, decimal interestRate)
            : base(customer, moneyTransaction, interestRate)
        {
        }

        public override decimal InterestRateForAPeriodCalculation(int months)
        {
            if (Customer == Customer.Companies)
            {
                if (months <= 12)
            {
                return base.InterestRateForAPeriodCalculation(months) / 2;
            }

                int firstYear = 12;
                decimal interest = this.Balance * (1 + ((this.InterestRate / 100) * months) / 2);
                decimal interestRateForThePeriod = interest * (1 + ((this.InterestRate / 100) * (months - firstYear)));
                return interestRateForThePeriod - this.Balance;
            }

            if (months < 6)
            {
                return 0;
            }
            return base.InterestRateForAPeriodCalculation(months - 6);
        }
    }
}
