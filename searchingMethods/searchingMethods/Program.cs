using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
           
            Console.ReadLine();
                     
        }

        public static string GetLastHalf(string text)

        {
            int length = text.Length / 2;
            text = text.Substring(length);
            text = text.Replace(" ", "");
            return text;

            //return text.Substring(text.Length / 2).Replace(" ", "");  Ответ преподавателя

        }






    }




}
