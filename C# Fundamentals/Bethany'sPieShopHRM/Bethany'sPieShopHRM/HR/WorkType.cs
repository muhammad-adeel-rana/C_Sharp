using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bethany_sPieShopHRM.HR
{
    internal struct WorkType
    {
        public string description;
        public int numberOfHours;

        public void PerformTask()
        {
            Console.WriteLine($"The work {description} has been done in {numberOfHours} hour(s).");
        }
    }
}
