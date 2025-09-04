namespace DependancyinjectionInCSharp;

internal class CurrentAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Details of current account!");
    }
}
