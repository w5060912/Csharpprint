using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _99乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arg = true;
            while (arg)
            {
                Console.WriteLine("选择打印内容");
                Console.WriteLine("1.打印99乘法表");
                Console.WriteLine("2.打印三角形");

                string input = Console.ReadLine();
                string Patten = @"\d";
                bool judge = Regex.IsMatch(input, Patten);
                if (judge)
                {
                    switch (input)
                    {
                        case "1":
                            Program.Print99cfb();
                            break;
                        case "2":
                            Program.Print3jx();
                            break;


                    }
                }
                else
                {

                }


            }



            Console.ReadKey();

        }

      static void Print99cfb()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine();
                Console.Write("  ");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}x{1}={2}", i, j, i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Print3jx()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 1; i <= 9; i++)//输出9行的三角形
            {
                for (int j = 9; j >i; j--) //控制对空格的输出
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <(i*2)-1; k++) //控制输出*
                {
                    Console.Write("*");
                }
                Console.Write("\r\n");

            }
            //for (int i = 9; i >0; i--)
            //{
            //    for (int k = 0; k < 9-i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("a");
            //    }
            //    Console.Write("\r\n");

            //}
        }

        static void Printyx()
        {
            Console.Write("*");
        }

    }
}
