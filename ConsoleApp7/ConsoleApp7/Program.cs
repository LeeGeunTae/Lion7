using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "==== 캐릭터 능력치 ====";
            float moveSpeed = 5.5f;
            double attackSpeed = 1.25;
            decimal itemPrice = 12.99m;

            Console.WriteLine(title);
            Console.WriteLine($"이동속도 : {moveSpeed}");
            Console.WriteLine($"공격속도 : {attackSpeed}");
            Console.WriteLine($"아이템 가격 : {itemPrice}");
        }
    }
}
