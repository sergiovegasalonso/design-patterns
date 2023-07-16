using AbstractFactory.Bank.Products.Account;
using AbstractFactory.Bank.Products.CreditCard;
using AbstractFactory.Bank.Products.DebitCard;

namespace AbstractFactory.Bank.Factories;

internal class BronzeAccountFactory : IAbstractFactory
{
    public IAbstractAccount CreateAccount()
    {
        return new BronzeAccount();
    }

    public IAbstractDebitCard CreateDebitCard()
    {
        return new BronzeDebitCard();
    }

    public IAbstractCreditCard CreateCreditCard()
    {
        return new BronzeCreditCard();
    }
}
