using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {

        public static string GetGreetingMessage(string name, double salary)
        {
         salary++;
         return name + salary;

        }
        static void Main(string[] args)
        {
            string Lola = "Lola";
            double millioni = 999999999;
            GetGreetingMessage(Lola, millioni);
            Console.WriteLine(GetGreetingMessage(Lola, millioni));
            Console.ReadKey();
        }

       
    }
}
