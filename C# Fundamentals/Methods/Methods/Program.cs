using Methods;

int month = 12;
int monthlyWage = 5432;
int bonus = 5340;

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