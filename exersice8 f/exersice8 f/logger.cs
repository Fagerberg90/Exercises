using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Logger
    {

        public void Log(string message)
        {   
            LogPosts1.Add(message);
        }

        public void log2(string message2)
        {
            logPosts2.Add(message2);
        }
        public List<string> LogPosts1 { get; private set; }
        public List<string> logPosts2 { get; set; }

        public Logger()
        {
            LogPosts1 = new List<string>();
            logPosts2 = new List<string>();

        }
    }
}

