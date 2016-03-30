using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        public string fName = string.Empty;
        public string lName = string.Empty;
        public string socialSN = string.Empty;
        public int hourlyWage;

        public Employee(string fName, string lName, string socialSN, int hourlyWage)
        {
            this.fName = fName;
            this.lName = lName;
            this.socialSN = socialSN;
            this.hourlyWage = hourlyWage;
        }
        public string fullName
        {
            get { return fName + " " + lName + " " + socialSN + " " + hourlyWage  ; }

        }
        

    }
}

