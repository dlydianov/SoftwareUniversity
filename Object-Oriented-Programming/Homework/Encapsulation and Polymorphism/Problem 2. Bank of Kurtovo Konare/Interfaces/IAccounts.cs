using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare.Interfaces
{
    interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; }
        decimal InterestRate { get; set; }
    }

}
