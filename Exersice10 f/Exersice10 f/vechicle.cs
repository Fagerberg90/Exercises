using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises10
{
    public class Vehicle
    {
        private string description;

        public Vehicle(string description)
        {
            this.description = description;
        }

        public string DescribeVehicle()
        {
            return string.Format ($"This vehicle is a {description}");
        }

    }
}

