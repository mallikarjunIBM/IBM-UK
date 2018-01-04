using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            InitiateConnector();
        }

        public static void InitiateConnector()
        {
            Console.WriteLine("Initiating The Cognos Reader...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Wait, while we connect to the Cognos");
            Console.ReadKey();
            // Calling the Connector API to Query the TM1 sever
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("TM1 - Read 197/197 Dimensions");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Querying Dimension from TM1 Server");
            Console.WriteLine("Reading Dimension and Subsets from TM1 Server");
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Call the Connector API
            Console.WriteLine("TM1 - Read 197/197 Cubes");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();          
        }
    }
}
