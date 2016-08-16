using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALPHA {0}", ConfigurationManager.AppSettings["ALPHA"]);
            Console.WriteLine("BETA {0}", ConfigurationManager.AppSettings["BETA"]);
            Console.WriteLine("GAMMA {0}", ConfigurationManager.AppSettings["GAMMA"]);
            Console.ReadLine();
        }
    }
}
