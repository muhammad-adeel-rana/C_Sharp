using DependancyinjectionInCSharp;

#region Constructor Injection
//IAccount savingAccount = new SavingAccount();
//Account account = new Account(savingAccount);
//account.PrintAccount();

//IAccount currentAccount = new CurrentAccount();
//Account account1 = new Account(currentAccount);
//account.PrintAccount();
#endregion

#region Setter or Property Injection
//Account account = new Account();
//account.account = new SavingAccount();
//account.PrintAccount();

//Account account1 = new Account();
//account1.account = new CurrentAccount();
//account1.PrintAccount();
#endregion

#region Method Injection
Account account = new Account();
account.PrintAccount(new CurrentAccount());

Account account1 = new Account();
account1.PrintAccount(new SavingAccount());
#endregion