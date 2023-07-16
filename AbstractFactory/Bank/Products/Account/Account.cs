namespace AbstractFactory.Bank.Products.Account;

internal class BronzeAccount : IAbstractAccount
{
    public string UsefulAccountFunction()
    {
        return "The result of the product \"Bronze Account\".";
    }
}

internal class SilverAccount : IAbstractAccount
{
    public string UsefulAccountFunction()
    {
        return "The result of the product \"Silver Account\".";
    }
}

internal class GoldAccount : IAbstractAccount
{
    public string UsefulAccountFunction()
    {
        return "The result of the product \"Gold Account\".";
    }
}