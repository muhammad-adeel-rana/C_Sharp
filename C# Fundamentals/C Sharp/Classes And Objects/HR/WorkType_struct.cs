using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects.HR
{
    internal struct WorkType_struct
    {
        public string description;
        public int numberOfHours;

        public void PerformTask()
        {
            Console.WriteLine($"The work {description} has been done in {numberOfHours} hour(s).");
        }
    }

}
