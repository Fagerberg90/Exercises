using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Logger
    {
        public List<string> LogPosts { get; private set; }

        public Logger()
        {
            LogPosts = new List<string>();
        }

        public void Log(string message)
        {
            DateTime tid = new DateTime();
            tid = DateTime.Now;
            LogPosts.Add(message + " " + tid);
        }

        public void readLogBook()
        {
            foreach (var item in LogPosts)
            {
                Console.WriteLine(item + "\n---------");
            }
        }
    }
}

