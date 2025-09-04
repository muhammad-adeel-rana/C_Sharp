using C__Fundamentals_Basic;
using System.Globalization;
using System.Net.Http.Headers;


Console.WriteLine("Hello, Everybody!");
Console.WriteLine("Please Enter your name");

string name = Console.ReadLine();
Console.WriteLine("Hope So you would be doing great, Mr. " + name);


#region Variable Naming Convention

//string name = Console.ReadLine();

//string name_2 = Console.ReadLine();

//string name2 = Console.ReadLine();

//string Name = Console.ReadLine();

//string 2name = Console.ReadLine();
#endregion


/*
 Multi Line Comment
*/

#region Premittive Data Types

//int noOfHours = 10;
//bool isActive = false;
//byte data = 255;
//double num = 103.4534;
//float num2 = 34.43f;

//const keyword

//const int temp = 10;

//temp = 9;
#endregion

// Creating Strings

//string s1 = "ali";

#region Members of primitive data types

//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;

//char userSelection = 'a';
//char userSelection = char.ToUpper(userSelection)
//bool isDigit = char.IsDigit(userSelection);
//bool isUpper = char.IsUpper(userSelection);
//bool isPunctuation  = char.IsPunctuation(userSelection);

#endregion

#region Date and Time

//DateTime dateTime = new DateTime(2022, 8, 24, 14, 30, 0);

//DateTime next = dateTime.AddDays(1);

//DataTime now  = DateTime.Now;

#endregion

#region Type Conversion 
int noOFHours = 175;

long weak = noOFHours;

double d = 121324344242.0;

int i = (int)d;

#endregion


#region Decisions by IF-ELSE 


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

#endregion

#region Switches
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

#endregion

#region Do-While loop

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

#endregion

#region While Loop

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
#endregion


// Do-While Loop
//do
//{
//    Console.WriteLine("Do While Loop");
//}while(false);

#region For Loop
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
#endregion


#region String Methods
string s = "AllIsWellAllIsWell";
var str = "AllIsWellAllIsWell";

//Console.WriteLine(str);

//int length = str.Length;
//Console.WriteLine(length);

//string upper = str.ToUpper();
//Console.WriteLine(upper);

//string lower = str.ToLower();  
//Console.WriteLine(lower);

//bool isContain = str.Contains("All");
//Console.WriteLine(isContain);

//string replaced = str.Replace("All", "all");
//Console.WriteLine(replaced);

//string subString = str.Substring(2, 5);
//Console.WriteLine(subString);

//Concatination
//string str1 = s + str;
//Console.WriteLine(str1);

//string str2 = string.Concat(s, str);
//Console.WriteLine(str2);

//string name = "adeel";
//string str3 = string.Format("Hello, Mr. {0}", name);
//Console.WriteLine(str3);

//string str4 = $"Hello Mr. {name}";
//Console.WriteLine(str4);

#endregion

//Utilities.usingEscapeChar();

//Utilities.checkingEquality();

Utilities.parsingStrings();

int month = 12;
int monthlyWage = 5432;
int bonus = 5340;
#region Method Calling
//int yearlyWage = Utilities.calculateYearlyWage(month, monthlyWage);
//Console.WriteLine($"Yearly age: {yearlyWage}");

//yearlyWage = Utilities.calculateYearlyWage(month, monthlyWage, bonus);
//Console.WriteLine($"Yearly Wage: {yearlyWage}");

//With Optional Parameters
//int yearlyWage = Utilities.calculateYearlyWageWithOptionalParameters(month, monthlyWage);
//Console.WriteLine($"Yearly Wage: {yearlyWage}");

//With Named Arguments
//yearlyWage = Utilities.calculateYearlyWageWithOptionalParameters(monthlyWage: monthlyWage, month: month);
//Console.WriteLine($"Yearly Wage: {yearlyWage}");

//With Expression Bodied Method
int yearlyWage = Utilities.calculateYearlyWageExpressionBodied(month, monthlyWage, bonus);
Console.WriteLine($"Yearly Wage: {yearlyWage}");
#endregion