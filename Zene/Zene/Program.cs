using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zene
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szereted a Super Mariot ? (igen/nem)");
            string a = Console.ReadLine();
            if (a == "igen")
            {
                Console.WriteLine("Akkor tesék ");
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
            }
            else if (a == "nem")
            {
                Console.WriteLine("Akkor így jártál :P");
            }
            

            Console.ReadLine();
        }
    }
}
