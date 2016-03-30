using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises10
{
    class Car : Vehicle
    {
        
        private bool engineIsRunning;
        public Car() : base ("Car")
        {
            
            this.engineIsRunning = engineIsRunning = false;
        }

        public void StartEngine()
        {
            engineIsRunning = true;
        }

        public void StopEngine()
        {
            engineIsRunning = false;
        }

    }
}

