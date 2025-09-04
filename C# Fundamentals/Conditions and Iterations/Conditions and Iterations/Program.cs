//Decisions by IF-ELSE 


//Console.WriteLine("Please, enter your name.");
//string name = Console.ReadLine();

//Console.WriteLine("Please, Enter your age.");
//int age = int.Parse(Console.ReadLine());
/*
if (age < 18)
{
    Console.WriteLine("You are too young to apply, Mr. " + name);
}
else if (age >= 65)
{
    Console.WriteLine("You are too old to apply, Mr. " + name);
}
else
{
    Console.WriteLine("Thank You very much for applying, Mr. " + name);
}

//Another

DateTime today = DateTime.Now;
bool endOfMonthPaymentStarted = false;

if (today.Date.Day == 20)
{
    Console.WriteLine("Please start end-of-month employee payments");
}
else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
{
    Console.WriteLine("Payments will be late");
}
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Switches
//switch (age)
//{
//    case < 18:
//        Console.WriteLine("You are too young to apply");
//        break;
//    case >= 65:
//        Console.WriteLine("You are too old to apply");
//        break;
//    default:
//        Console.WriteLine("Congrats, you are shortlisted");
//        break;
//}

//Bethany's Shop HRM
//string selectedOption;

//do
//{
//    Console.WriteLine("Choose the action do you want to do: ");
//    Console.WriteLine("1. Add Employee");
//    Console.WriteLine("2. Update Employee");
//    Console.WriteLine("3. Delete Employee");
//    Console.WriteLine("99. Exit Application");

//    selectedOption = Console.ReadLine();

//    switch (selectedOption)
//    {
//        case "1":
//            Console.WriteLine("Adding new Employee ...");
//            break;
//        case "2":
//            Console.WriteLine("Updating Employee ...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting Employee ...");
//            break;
//        case "99":
//            Console.WriteLine("Closing Application ...");
//            break;
//        default:
//            Console.WriteLine("Invalid Input");
//            break;
//    }

//} while (selectedOption != "99") ;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//While Loop

//Console.WriteLine("Enter a number");
//int max = int.Parse(Console.ReadLine());
//int i = 0;

//while (i < max)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("Loop Finished");

//Nested While Loop
//Console.WriteLine("Enter a number");
//int max = int.Parse(Console.ReadLine());
//int i = 0;
//int j = 0;

//while (i < max)
//{
//    while(j < max) {
//        Console.WriteLine("i: " + i + "  j: "+ j);
//        j++;
//    }
//    j = 0;
//    i++;

//}

//Console.WriteLine("Loop Finished");

//Infinite Loop
//Console.WriteLine("Enter a number");
//int max = int.Parse(Console.ReadLine());

//while (true)
//{
//    Console.WriteLine(DateTime.Now);
//}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Do-While Loop
//do
//{
//    Console.WriteLine("Do While Loop");
//}while(false);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// For Loop
//for(int i=0; i<10;i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("Bingo! we have find " + i + " in the list");
//        continue;
//    }
//    Console.WriteLine(i);
//}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

