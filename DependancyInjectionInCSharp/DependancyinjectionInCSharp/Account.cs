namespace DependancyinjectionInCSharp;

internal class Account
{
    public IAccount account { set; get; }

    #region Constructor Injection
    //public Account(IAccount account)
    //{
    //    this.account = account;
    //}


    //public void PrintAccount()
    //{
    //    account.PrintDetails();
    //}

    #endregion

    #region Setter or Property Injection
    public void PrintAccount()
    {
        account.PrintDetails();
    }
    #endregion

    #region Method Injection
    public void PrintAccount(IAccount account)
    {
        account.PrintDetails();
    }
    #endregion
}
