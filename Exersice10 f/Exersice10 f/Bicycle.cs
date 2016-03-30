using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises10
{
    class Bicycle : Vehicle
    {
        public bool lightsOn { get; set; } = false;
        public Bicycle() : base("bicycle")
        {


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

