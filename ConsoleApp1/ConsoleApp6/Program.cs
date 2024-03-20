using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //피라미드

            int florr = 5;

            for (int i = 0; i < florr; i++)
            {
                //공백
                for(int j = florr-i; j>1;  j--)
                    Console.Write('@');
                //별 
                for(int j =0; j<2*i+1; j++)
                    Console.Write("*");
                Console.WriteLine(); // 줄띄우기
            
            }

            int[] numbers = new int[5];
            for(int i = 0; i<numbers.Length;i++)
            {
                Console.WriteLine(i+1+"번째 값 입력");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //가장 첫번째 값이 최댓값, 최솟값이라고 가정
            int max = numbers[0];
            int min = numbers[0];
            for(int i = 1; i<numbers.Length; i++)
            {
                if(max < numbers[i])
                    max = numbers[i];
                if(min > numbers[i])
                    min = numbers[i];
            }
            // if if 대신 if else를 쓰게 되면 안 됨
            // 다만 if else if를 쓸 경우에는 된긴 함
            // if를 사용하면 if문 마다 비교하지만 if else문을 쓰게 되면 if가 참일 경우 else문을 검사안함
            Console.WriteLine("최댓값:" + max);
            Console.WriteLine("최솟값:"+min);
                
        }
    }
}
