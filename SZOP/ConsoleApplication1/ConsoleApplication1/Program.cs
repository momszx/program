using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {

        static int sum = 0;

        static void Counter1()
        {
            for (int i = 0; i < 50; i++)
            {
                lock (typeof(Program))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    sum += i;
                }
            }
        }

        static void Counter2()
        {
            for (int i = 50; i < 100; i++)
            {
                lock (typeof(Program))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(i);
                    sum += i;
                }
            }
        }

        static void Main(string[] args)
        {
            Counter1();
            Counter2();
            sum = 0;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Thread: ");
            Thread th1 = new Thread(Counter1);
            Thread th2 = new Thread(Counter2);
            th2.Priority = ThreadPriority.Highest;


            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
