using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            string numberAsString = number.ToString();

            bool flag = true;
            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
