using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int level        = 10;
            int vigor        = 15;
            int mind         = 10;
            int endurance    = 11;
            int strength     = 14;
            int dextarity    = 13;
            int intelligence = 14;
            int faith        = 9;
            int arcane       = 7;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃              level        = {level       }              ┃");
            Console.WriteLine($"┃              vigor        = {vigor       }              ┃");
            Console.WriteLine($"┃              mind         = {mind        }              ┃");
            Console.WriteLine($"┃              endurance    = {endurance   }              ┃");
            Console.WriteLine($"┃              strength     = {strength    }              ┃");
            Console.WriteLine($"┃              dextarity    = {dextarity   }              ┃");
            Console.WriteLine($"┃              intelligence = {intelligence}              ┃");
            Console.WriteLine($"┃              faith        = {faith       }               ┃");
            Console.WriteLine($"┃              arcane       = {arcane}               ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
