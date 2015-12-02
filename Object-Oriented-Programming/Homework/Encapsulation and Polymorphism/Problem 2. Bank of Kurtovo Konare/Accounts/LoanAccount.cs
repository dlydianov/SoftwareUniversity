using System;
using BankOfKurtovoKonare.Customers;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    class LoanAccount: Accounts
    {
        public LoanAccount(Customer customer, decimal moneyTransaction, decimal interestRate)
            : base(customer, moneyTransaction, interestRate)
        {
        }

        public override decimal InterestRateForAPeriodCalculation(int months)
        {
            if (Customer == Customer.Companies)
            {
                if (months <= 2)
                {
                    return 0;
                }
                return base.InterestRateForAPeriodCalculation(months - 2);
            }
            if (months <= 3)
            {
                return 0;
            }
            return base.InterestRateForAPeriodCalculation(months - 3);
        }
    }
}
