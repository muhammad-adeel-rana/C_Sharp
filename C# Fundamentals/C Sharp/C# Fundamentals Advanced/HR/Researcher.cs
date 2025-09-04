using Classes_And_Objects.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals_Advanced.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        private int numberOfNewPieTastesInvented = 0;

        public int NumberOfNewTastesInvented 
        {
            get { return numberOfNewPieTastesInvented; }
            set
            {
                numberOfNewPieTastesInvented = value;
            }
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            if (new Random().Next(100) > 50)
            {
                numberOfNewPieTastesInvented++;
                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new Pie Taste! Total number of pies invented till now" +
                    $" is {numberOfNewPieTastesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is still working on a new Pie Taste!");
            }

        }
    }
}
