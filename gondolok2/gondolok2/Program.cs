﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gondolok2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Szia kérlek gondolj egy számra 1 és 100 között én meg megpróbálom kitalálni. ");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine("Megvan a szám ? (igen/nem)");
            String x = Console.ReadLine();
            if ("igen" == x)
            {
                
                for (int i = 2; i < 13; i++ )
                {
                    Console.WriteLine(i+"?");
                    String y = Console.ReadLine();
                    if ("igen" == y)
                    {
                        break;
                    }
                    else if ("nem" == y)
                    {

                    }
                    else Console.WriteLine("Valamit elírtál");

                    i++;
                }
            }
            else if ("nem" == x)
            {
                Console.WriteLine("Jó amig gondolkozol kapsz zenét  :)");
                Console.Beep(659, 125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(523, 125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(375);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(375);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(330, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(466, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(880, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(330, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(466, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Environment.Exit(1);
            }
            else Console.WriteLine("Valamit elírtál");

            Console.WriteLine("haha kitaláltam");



            Console.ReadLine();
        }
    }
}
