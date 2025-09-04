using C__Fundamentals_Advanced.HR;
using Classes_And_Objects.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals_Advanced
{
    internal class Utilities
    {
        private static string directory = @"D:\C#\C# Fundamentals\C Sharp\C# Fundamentals Advanced\";
        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an Employee");

            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("1: Employee\n2: Manager\n3: Store Manager\n4: " +
                "Register\n5: Juniour Researcher");
            Console.WriteLine("Your Selection");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4"
                && employeeType != "5")
            {
                Console.WriteLine("Invalid Selection");
                return;
            }

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the birth day ex. 16/02/2008: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the houly rate");
            double hourlyRate = double.Parse(Console.ReadLine());

            Employee employee = null;
            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                    break;
                case "5":
                    employee = new JuniourResearcher(firstName, lastName, email, birthDay, hourlyRate);
                    break;
            }

            employees.Add(employee);
            Console.WriteLine("Employee Created! \n\n");
        }

        internal static void ViewAllEmployee(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }
        }

        internal static void CheckForExistingEmployeeFile()
        {
            string path = $"{directory}{fileName}";
            bool existingFileFound = File.Exists(path);

            if (existingFileFound)
            {
                Console.WriteLine("An existing file with Employee data is found.");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory is ready for saving files");
                    Console.ResetColor();
                }
            }
        }

        internal static void SaveEmployee(List<Employee> employees)
        {
            string path = $"{directory}{fileName}";
            StringBuilder sb = new StringBuilder();

            foreach (Employee employee in employees)
            {
                string type = GetEmployeeType(employee);
                sb.Append($"firstName:{employee.FirstName};");
                sb.Append($"lastName:{employee.LastName};");
                sb.Append($"email:{employee.Email};");
                sb.Append($"birthDay:{employee.BirthDay.ToShortDateString()};");
                sb.Append($"hourlyRate:{employee.HourlyRate};");
                sb.Append($"type:{type};");
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved Employees Successfully");
            Console.ResetColor();
        }

        private static string GetEmployeeType(Employee employee)
        {
            if (employee is Manager)
                return "2";
            else if (employee is StoreManager) return "3";
            else if (employee is Researcher) return "4";
            else if (employee is JuniourResearcher) return "5";
            else if (employee is Employee) return "1";
            else return "0";
        }

        internal static void LoadEmployee(List<Employee> employees)
        {
            #region Exception Handling
            try
            {
                string path = $"{directory}{fileName}";
                if (File.Exists(path))
                {
                    employees.Clear();

                    string[] employeesAsString = File.ReadAllLines(path);
                    foreach (string emp in employeesAsString)
                    {
                        string[] employeeInfo = emp.Split(';');
                        string firstName = employeeInfo[0].Substring(employeeInfo[0].IndexOf(':') + 1);
                        string lastName = employeeInfo[1].Substring(employeeInfo[1].IndexOf(':') + 1);
                        string email = employeeInfo[2].Substring(employeeInfo[2].IndexOf(':') + 1);
                        DateTime birthDay = DateTime.Parse(employeeInfo[3].Substring(employeeInfo[3].IndexOf(':') + 1));
                        Double hourlyRate = Double.Parse(employeeInfo[4].Substring(employeeInfo[4].IndexOf(':') + 1));
                        string employeeType = employeeInfo[5].Substring(employeeInfo[5].IndexOf(':') + 1);

                        Employee employee = null;

                        switch (employeeType)
                        {
                            case "1":
                                employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "2":
                                employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "3":
                                employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "4":
                                employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "5":
                                employee = new JuniourResearcher(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                        }

                        employees.Add(employee);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Loaded {employees.Count} employees!\n\n");
                    //Console.ResetColor();
                }
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong parsing the file, please check data!");
                Console.WriteLine(iex.Message);
                //Console.ResetColor();
            }
            catch(FileNotFoundException fnfex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The file didn't found");
                Console.WriteLine(fnfex.Message);
                Console.WriteLine(fnfex.StackTrace);
                //Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong while loading the file!");
                Console.WriteLine(ex.Message);
                //Console.ResetColor();
            }
            finally
            {
                Console.ResetColor();
            }

            #endregion
        }

        internal static void LoadEmployeeById(List<Employee> employees)
        {
            try
            {
                Console.WriteLine("Enter the Employee ID you want to visualize: ");

                int selectedId = int.Parse(Console.ReadLine());
                Employee selectedEmployee = employees[selectedId - 1];
                selectedEmployee.DisplayEmployeeDetails();
            }
            catch (FormatException fex)
            {
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That's not the correct format to enter an ID!\n\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
