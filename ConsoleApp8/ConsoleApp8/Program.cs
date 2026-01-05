using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char symbol = '★';
            //char grade = 'A';

            //string name = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어 : {name}");
            //Console.WriteLine($"등급 : {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);

            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            bool isRunning = true;
            bool isPause = false;
            bool hasKey = false;
            bool doorOpen = false;
            bool isAlive = true;

            int hp = 80;
            bool health = true;
            bool danger = false;

            Console.WriteLine("=== 게임 상태 === ");
            Console.WriteLine($"게임 실행 중 : {isRunning}");
            Console.WriteLine($"일시 정지 : {isPause}");
            Console.WriteLine($"열쇠 소지 : {hasKey}");
            Console.WriteLine($"문 열림 : {doorOpen}");
            Console.WriteLine($"플레이어 생존 : {isAlive}");

            Console.WriteLine("=== 캐릭터 상태 ===");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"건강 상태 : {health}");
            Console.WriteLine($"위험 상태 : {danger}");

        }
    }
}
