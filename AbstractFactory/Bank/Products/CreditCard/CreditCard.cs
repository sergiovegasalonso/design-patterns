namespace AbstractFactory.Bank.Products.CreditCard;

internal class BronzeCreditCard : IAbstractCreditCard
{
    public string UsefulCreditCardFunction()
    {
        return "The result of the product \"Bronze Credit Card\".";
    }
}

internal class SilverCreditCard : IAbstractCreditCard
{
    public string UsefulCreditCardFunction()
    {
        return "The result of the product \"Silver Credit Card\".";
    }
}

internal class GoldCreditCard : IAbstractCreditCard
{
    public string UsefulCreditCardFunction()
    {
        return "The result of the product \"Gold Credit Card\".";
    }
}
