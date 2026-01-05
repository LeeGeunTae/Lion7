using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10, y = 20, z = 30; //정수형 x,y,z 선언하고 초기화

            //Console.WriteLine(x); //출력: 10
            //Console.WriteLine(y); //출력: 20
            //Console.WriteLine(z); //출력: 30

            //int age = 10;
            //Console.WriteLine("나이 : {0}", age);

            //string name = "김철수";
            //Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);

            //Console.WriteLine($"이름 : {name}");

            //Console.WriteLine($"이름");

            // 3D 좌표 표시
            int posX = 0, posY = 50, posZ = 100;

            Console.WriteLine("x 좌표 : {0}, y 좌표 : {1}, z 좌표 : {2}", posX, posY, posZ);

            Console.WriteLine("x 좌표 : " + posX + ", y좌표 : " + posY + ", z좌표 : " + posZ);

            Console.WriteLine($"x 좌표 : {posX}, y 좌표 : {posY}, z 좌표 : {posZ}");

            // RGB 색상 예시
            int red = 255, green = 128, blue = 0;

            Console.WriteLine("red : {0}, green : {1}, blue : {2}", red, green, blue);

            Console.WriteLine("red : " + red + ", green : " + green + ", blue : " + blue);

            Console.WriteLine($"red : {red}, green : {green}, blue : {blue}");

        }
    }
}
