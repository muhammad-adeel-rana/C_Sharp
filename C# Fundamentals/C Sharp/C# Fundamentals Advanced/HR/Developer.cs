using Classes_And_Objects.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals_Advanced.HR
{
    internal class Developer : Employee
    {
        private string pojectType;

        public string ProjectType
        {
            get { return ProjectType; }
            set { ProjectType = value; }
        }

        public Developer(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
    }
}
