using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindEmployer
{
    internal class Program
    {
        public static string GetGreetingMessage(string name, double salary)
        {
            salary = (int)Math.Ceiling(salary);
            return name + salary;
           
        }

        public static string GetSquare(double theNumber)
        {
            string fourtyTwo = theNumber.ToString();
            return "The main answer is " + fourtyTwo;
            
        }
        static void Main(string[] args)
        {
            string Lola = "Lola";
            double millioni = 999999999.000001;
            //GetGreetingMessage(Lola, millioni);

            int odin = 1;
            string Histch = "n" + odin.ToString();

            double unswer2 = Math.Pow(5, 2);

            Console.WriteLine(GetGreetingMessage(Lola, millioni));
            Console.WriteLine(Histch);
            Console.ReadKey();
        }










    }
}
