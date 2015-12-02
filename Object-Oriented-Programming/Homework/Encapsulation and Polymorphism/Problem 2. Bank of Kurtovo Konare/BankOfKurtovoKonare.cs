using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Accounts;
using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main()
        {
            Console.WriteLine("DEPOSIT ACCOUNT");
            DepositAccount depositAccount = new DepositAccount(Customer.Companies, 5000.50m, 4.5m);
            Console.WriteLine(depositAccount.InterestRateForAPeriodCalculation(5));
            Console.WriteLine(depositAccount.Balance);
            depositAccount.Deposit(1000m);
            Console.WriteLine(depositAccount.Balance);
            Console.WriteLine(depositAccount.InterestRateForAPeriodCalculation(5));
            depositAccount.Widthraw(5500m);
            Console.WriteLine(depositAccount.Balance);
            Console.WriteLine(depositAccount.InterestRateForAPeriodCalculation(5));
            Console.WriteLine();

            Console.WriteLine("LOAN ACCOUNT");
            LoanAccount loanAccount = new LoanAccount(Customer.Individual, 5000, 10);
            Console.WriteLine(loanAccount.InterestRateForAPeriodCalculation(3));

            loanAccount.Customer = Customer.Companies;
            Console.WriteLine(loanAccount.InterestRateForAPeriodCalculation(3));
            Console.WriteLine();

            Console.WriteLine("MORTGAGE ACCOUNT");
            MortgageAccount mortgageAccount = new MortgageAccount(Customer.Companies, 4000m, 5.45m);
            Console.WriteLine(mortgageAccount.InterestRateForAPeriodCalculation(6));

        }
    }
}
