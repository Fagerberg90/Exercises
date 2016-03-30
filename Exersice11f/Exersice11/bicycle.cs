using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises11f
{
    class Bicycle : Vehicle
    {
        public bool lightsOn { get; set; } = false;
        public Bicycle() : base("bicycle")
        {


        }

        public override string DescribeVehicle()
         { 
             string currentStatus = lightsOn ? "and the bicycle light is on" : ",the bicycles light is off."; 
             return base.DescribeVehicle()+" "+currentStatus; 
        }

    public void LightOn()
        {
            lightsOn = true;
        }
        public void LightOff()
        {
            lightsOn = false;

        }
    }
}

