using AbstractFactory.Bank.Products.Account;

namespace AbstractFactory.Bank.Products.DebitCard;

internal class BronzeDebitCard : IAbstractDebitCard
{
    public string UsefulDebitCardFunction()
    {
        return "The result of the product \"Bronze Debit Card\".";
    }

    public string AnotherUsefulDebitCardFunction(IAbstractAccount collaborator)
    {
        var result = collaborator.UsefulAccountFunction();

        return $"The result of the \"Bronze Debit Card\" collaborating with the ({result})";
    }
}

internal class SilverDebitCard : IAbstractDebitCard
{
    public string UsefulDebitCardFunction()
    {
        return "The result of the product \"Silver Debit Card\".";
    }

    public string AnotherUsefulDebitCardFunction(IAbstractAccount collaborator)
    {
        var result = collaborator.UsefulAccountFunction();

        return $"The result of the \"Silver Debit Card\" collaborating with the ({result})";
    }
}

internal class GoldDebitCard : IAbstractDebitCard
{
    public string UsefulDebitCardFunction()
    {
        return "The result of the product \"Gold Debit Card\".";
    }

    public string AnotherUsefulDebitCardFunction(IAbstractAccount collaborator)
    {
        var result = collaborator.UsefulAccountFunction();

        return $"The result of the \"Gold Debit Card\" collaborating with the ({result})";
    }
}
