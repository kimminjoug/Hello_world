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

            int[] nums = { 11, 10, 50, 27, 30 };
            foreach (var item in nums) // var대신 int 사용해도 됨
                Console.WriteLine(item);


        for (int i = 0; i< 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - 1; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}
