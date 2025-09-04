#region Arrays
//int[] sampleArray = new int[5];
//int[] sampleArray1 = new int[] {1, 2, 3, 4, 5};
////int[] sampleArray2 = new int[5] {1, 2, 3, 4, 5, 6}; //Violation

//Console.WriteLine("How many employee Ids do you want to add?");
//int numberOfIds = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[numberOfIds];

//for (int i = 0; i < numberOfIds; i++)
//{
//    employeeIds[i] = i - 2*i;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine("Id of employee is: " + employeeIds[i]);
//}

//int[] employeeIds1 = new int[numberOfIds];

////Array.Sort(employeeIds1); // Array Sorting
//employeeIds.CopyTo(employeeIds1, 0);
//employeeIds1[4] = 1;
//Array.Reverse(employeeIds1);
//Console.WriteLine("After Reverse");
//for (int i = 0; i < employeeIds1.Length; i++)
//{
//    Console.WriteLine("Id of employee is: " + employeeIds1[i]);
//}

////Make list of employee class and apply foreach loop on it

//Array.Sort(employeeIds1);
#endregion

#region Collections and Lists
//using Classes_And_Objects.HR;

//List<int> employeeIds = new List<int>();
//employeeIds.Add(55);
//employeeIds.Add(43);
//employeeIds.Add(16);
//employeeIds.Add(53);
//employeeIds.Add(59);
//employeeIds.Add(05);

////employeeIds.Add("hey"); //violation

//if (employeeIds.Contains(53))
//{
//    Console.WriteLine("Woohoo! 53 Found");
//}

//Console.WriteLine("Current Number of Employee: " + employeeIds.Count);

//var employeeIdsArray = employeeIds.ToArray();

//employeeIds.Clear();

//int len = int.Parse(Console.ReadLine());   

//for (int i = 0; i < len; i++)
//{
//    Console.WriteLine("Enter employee Id");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds.Add(id);
//}

// Make list of employee class and apply foreach loop on it
#endregion

#region OOP
//using C__Fundamentals_Advanced;
//using C__Fundamentals_Advanced.HR;
//using Classes_And_Objects.HR;

//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime
//    (1979, 1, 16), 25);

//IEmployee jhon = new StoreManager("Jhon", "Smith", "Jhon@snowball.be", new DateTime
//    (1984, 3, 28), null);

//IEmployee mary = new Manager("Mary", "Jones", "mary@snowbell.com", new DateTime(1965, 1, 16), 30);
//IEmployee bobJuniour = new JuniourResearcher("Bob", "Spancer", "bob@snowbell.com",
//    new DateTime(1989, 1, 31), 24);

//IEmployee jake = new Employee("Jake", "Nicols", "jake@snowbell.com",
//    new DateTime(1995, 9, 7), 25, "New Street", "123", "42001", "Pie Ville");

//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(jake);
//employees.Add(bobJuniour);
//employees.Add(jhon);
//employees.Add(mary);  

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}



////mary.DisplayEmployeeDetails();
////mary.PerformWork();
////mary.PerformWork(4);
////mary.PerformWork();
////mary.PerformWork(2);
////mary.PerformWork();
////mary.PerformWork(5);
////mary.PerformWork(6);
////mary.PerformWork();
////mary.RecieveWage();
//////mary.AttendManagementMeetings();
////mary.RecieveWage();
////mary.GiveBonus();

////bobJuniour.ResearchNewPieTastes(5);
////bobJuniour.ResearchNewPieTastes(5);
////bobJuniour.ResearchNewPieTastes(5);

////string streetName = jake.Address.Street;
#endregion

#region Testing(Debugging)
//using C__Fundamentals_Advanced;
//using C__Fundamentals_Advanced.HR;

//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime
//    (1979, 1, 16), 25);

//Console.WriteLine($"How many hours do you want to register for Bethany");
//int numberOfHours = 0;
//string input = Console.ReadLine();
//numberOfHours = int.Parse(input);

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(numberOfHours);
#endregion

#region File Handling
//using C__Fundamentals_Advanced;
//using Classes_And_Objects.HR;

//List<Employee> employees = new List<Employee>();

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("***********************************");
//Console.WriteLine("* Bethany's Pie Shop Employee App *");
//Console.WriteLine("***********************************");
//Console.ForegroundColor= ConsoleColor.White;

//string userSelection;
//Console.ForegroundColor = ConsoleColor.Blue;

//Utilities.CheckForExistingEmployeeFile();

//do
//{
//    Console.ForegroundColor = ConsoleColor.Cyan;
//    Console.WriteLine($"Loaded {employees.Count} employees\n\n");

//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine("********************");
//    Console.WriteLine("* Select an Option *");
//    Console.WriteLine("********************");

//    Console.WriteLine("1: Register Employee");
//    Console.WriteLine("2: View all Employee");
//    Console.WriteLine("3: Save Data");
//    Console.WriteLine("4: Load Data");
//    Console.WriteLine("9: Quit Application");

//    Console.Write("Your Selection: ");
//    userSelection = Console.ReadLine();

//    switch (userSelection)
//    {
//        case "1":
//            Utilities.RegisterEmployee(employees);
//            break;
//        case "2":
//            Utilities.ViewAllEmployee(employees);
//            break;
//        case "3":
//            Utilities.SaveEmployee(employees);
//            break;
//        case "4":
//            Utilities.LoadEmployee(employees);
//            break;
//        case "9":
//            break;
//        default:
//            Console.WriteLine("Invalid selection! Please try again.");
//            break;
//    }

//} while (userSelection != "9");
#endregion

#region Exception Handling
using C__Fundamentals_Advanced;
using Classes_And_Objects.HR;

List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employees\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an Option *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register Employee");
    Console.WriteLine("2: View all Employee");
    Console.WriteLine("3: Save Data");
    Console.WriteLine("4: Load Data");
    Console.WriteLine("5: Load Specific Employee");
    Console.WriteLine("9: Quit Application");

    Console.Write("Your Selection: ");
    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployee(employees);
            break;
        case "3":
            Utilities.SaveEmployee(employees);
            break;
        case "4":
            Utilities.LoadEmployee(employees);
            break;
        case "5":
            Utilities.LoadEmployeeById(employees);
            break;
        case "9":
            break;
        default:
            Console.WriteLine("Invalid selection! Please try again.");
            break;
    }

} while (userSelection != "9");

#endregion