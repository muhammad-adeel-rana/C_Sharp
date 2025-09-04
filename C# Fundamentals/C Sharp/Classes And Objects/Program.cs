using Classes_And_Objects.Account;
//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

#region Object Calling
//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime
//    (1979, 1, 16), 25, EmployeeType.Manager);

//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();

//double receivedWagebethany = bethany.RecieveWage();
//Console.WriteLine($"Wage paid(message from system): {receivedWagebethany}");


//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//var jhon = new Employee("Jhon", "Smith", "Jhon@snowball.be", new DateTime
//    (1984, 3, 28), null, EmployeeType.Research);

//jhon.DisplayEmployeeDetails();

//jhon.PerformWork();
//jhon.PerformWork();
//jhon.PerformWork(5);
//jhon.PerformWork();
//jhon.PerformWork(3);
//jhon.PerformWork();

//double receivedWagejhon = jhon.RecieveWage();
//Console.WriteLine($"Wage paid(message from system): {receivedWagejhon}");
#endregion

#region Value Type & Reference Type
//Value Types and Reference Types
//Value Type
//int a = 42;
//int aCopy = a;
//aCopy++;
//Console.WriteLine($"Value of a: {a}, Value of copy of a: {aCopy}");

//Referenced Type
//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime
//    (1979, 1, 16), 25, EmployeeType.Manager);

//bethany.PerformWork(25);

//int minimumBonus = 100;
//int recievedBonus = bethany.CalculateBonus(minimumBonus);

//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {recievedBonus}");

//int minimumBonus = 100;
//int bonusTax ;
//int recievedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);

//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {recievedBonus}");
#endregion

//Fully Qualified Name
//Bethany_sPieShopHRM.Accounting.Customer customer = new Bethany_sPieShopHRM.Accounting.Customer();

#region Reference Type Null Values
//Employee mystryEmployee;
//mystryEmployee.DisplayEmployeeDetails;

#endregion

#region Garbagge Collection
//List<Employee> employees= new List<Employee>();
//for (int i= 0; i < 10000000; i++)
//{
//    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
//        Guid.NewGuid().ToString(), new DateTime(1979, 1, 23), null, EmployeeType.StoreManager); 
//    employees.Add(randomEmployee);
//}

//employees.Clear();
//employees = null;

//GC.Collect();

//Console.ReadLine();
#endregion

#region Calling a record
Account_record account = new Account_record("12345678");

//account.AccountNumber = "65341734";//Value cannot change
#endregion