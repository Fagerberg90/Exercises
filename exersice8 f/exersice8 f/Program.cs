using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();

            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("Third post");
            myLogger.Log("Fourth post");

            var minLista = new Logger();
            myLogger.log2("Fifth post");
            myLogger.log2("sixth post");


            foreach (var item in myLogger.LogPosts1)
            {
                Console.WriteLine("Here is the Logpost1: " + item);
            }

            Console.WriteLine("\n----------------------------------");

            foreach (var item in myLogger.logPosts2)
            {
                Console.WriteLine("proceeding of Logpost2 : " + item);
            }

            Console.ReadKey();
        }
    }
}

