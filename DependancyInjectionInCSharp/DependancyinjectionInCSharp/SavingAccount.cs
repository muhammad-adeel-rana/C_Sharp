namespace DependancyinjectionInCSharp;

internal class SavingAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Details of Saving account!");
    }
}
