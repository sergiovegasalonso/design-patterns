using AbstractFactory.Bank.Products.Account;
using AbstractFactory.Bank.Products.CreditCard;
using AbstractFactory.Bank.Products.DebitCard;

namespace AbstractFactory.Bank.Factories;

internal class SilverAccountFactory : IAbstractFactory
{
    public IAbstractAccount CreateAccount()
    {
        return new SilverAccount();
    }

    public IAbstractDebitCard CreateDebitCard()
    {
        return new SilverDebitCard();
    }

    public IAbstractCreditCard CreateCreditCard()
    {
        return new SilverCreditCard();
    }
}