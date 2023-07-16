using AbstractFactory.Bank.Products.Account;

namespace AbstractFactory.Bank.Products.DebitCard;

internal interface IAbstractDebitCard
{
    // Debit card is able to do its own thing...
    string UsefulDebitCardFunction();

    // ...but it also can collaborate with the Account.
    //
    // The Abstract Factory makes sure that all products it creates are of
    // the same variant and thus, compatible.
    string AnotherUsefulDebitCardFunction(IAbstractAccount collaborator);
}
