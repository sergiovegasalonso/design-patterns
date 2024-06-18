using AbstractFactory.Bank.Factories;

namespace AbstractFactory;

// The client code works with factories and products only through abstract
// types: AbstractFactory and AbstractProduct. This lets you pass any
// factory or product subclass to the client code without breaking it.
class Client
{
    public void Main()
    {
        // The client code can work with any concrete factory class.
        ClientMethod(new BronzePlanFactory());
        Console.WriteLine();

        ClientMethod(new SilverPlanFactory());
        Console.WriteLine();

        ClientMethod(new GoldPlanFactory());
        Console.WriteLine();
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var account = factory.CreateAccount();
        var debitCard = factory.CreateDebitCard();
        var creditCard = factory.CreateCreditCard();

        Console.WriteLine(account.UsefulAccountFunction());
        Console.WriteLine(debitCard.UsefulDebitCardFunction());
        Console.WriteLine(debitCard.AnotherUsefulDebitCardFunction(account));
        Console.WriteLine(creditCard.UsefulCreditCardFunction());
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}