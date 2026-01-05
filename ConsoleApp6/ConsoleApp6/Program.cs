using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 상수 : 값을 변경할 수 없다. 키워드 : const

            //const double Pi = 3.141592; // 상수 Pi 선언 및 초기화
            //const int MaxScore = 100; // 정수형 상수 선언

            //Console.WriteLine("Pi : " + Pi);
            //Console.WriteLine("MaxScore : " + MaxScore);

            const int people = 4;
            const string startgold = "1000G";
            const string version = "1.0.0";

            Console.WriteLine("'''");
            Console.WriteLine($"최대 플레이어 : {people}");
            Console.WriteLine($"시작 골드 : {startgold}");
            Console.WriteLine($"버전 : {version}");
            Console.WriteLine("'''");


        }
    }
}
