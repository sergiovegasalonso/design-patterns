using AbstractFactory.Bank.Products.Account;
using AbstractFactory.Bank.Products.CreditCard;
using AbstractFactory.Bank.Products.DebitCard;

namespace AbstractFactory.Bank.Factories;

internal class GoldPlanFactory : IAbstractFactory
{
    public IAbstractAccount CreateAccount()
    {
        return new GoldAccount();
    }

    public IAbstractDebitCard CreateDebitCard()
    {
        return new GoldDebitCard();
    }

    public IAbstractCreditCard CreateCreditCard()
    {
        return new GoldCreditCard();
    }
}
