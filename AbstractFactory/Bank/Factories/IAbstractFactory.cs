using AbstractFactory.Bank.Products.Account;
using AbstractFactory.Bank.Products.CreditCard;
using AbstractFactory.Bank.Products.DebitCard;

namespace AbstractFactory.Bank.Factories;

internal interface IAbstractFactory
{
    internal IAbstractAccount CreateAccount();

    internal IAbstractDebitCard CreateDebitCard();

    internal IAbstractCreditCard CreateCreditCard();
}
