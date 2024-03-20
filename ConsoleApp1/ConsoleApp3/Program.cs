using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(6) + 1;
            
            /*
            switch(num)
            {
                case 1:
                case 2:
                    Console.WriteLine("1아님2나옴");
                    break;
                case 3:
                    Console.WriteLine("3이 나옴");
                    break;
                case 4:
                    Console.WriteLine("4가 나옴");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("5~6");
                    break;
                default:
                  breake;

            }
            */

            Console.WriteLine("숫자를 입력하세요:[1~12]");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:                
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:               
                    Console.WriteLine("여름입니다");
                    break;
                case 9: 
                case 10:
                case 11:
                    Console.WriteLine("가을입니다");
                    break;
                default:
                    Console.WriteLine("잘못입력하였습니다.");
                    break;
                    

            } 



           



        }
    }
}
