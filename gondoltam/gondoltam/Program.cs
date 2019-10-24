using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gondoltam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia kérlek gondolj egy számra 0 és 100 között én meg megpróbálom kitalálni. ");
            System.Threading.Thread.Sleep(1600);
            Console.WriteLine("Megvan a szám ? (igen/nem)");
            String x = Console.ReadLine();
            if ("igen" == x)
            {
                Console.WriteLine("Rendben akkor gondolkozok");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("A szám 50?(igen/nem)");
                String a = Console.ReadLine();
                if ("igen" == a)
                {
                    Console.WriteLine("De jó vagyok ");
                }
                else if ("nem" == a)
                {
                    Console.WriteLine("Kissebb mint 50 ? (igen/nem)");
                    #region
                    String b = Console.ReadLine();
                    if ("igen" == b)
                    {
                        Console.WriteLine("26?(igen/nem)");
                        String d = Console.ReadLine();
                        if ("igen" == d)
                        {
                            Console.WriteLine("Profizmus");
                        }
                        else if ("nem" == d)
                        {
                            Console.WriteLine("hmm kissebb mint 26?(igen/nem)");
                            String c = Console.ReadLine();
                            if ("igen" == c)
                            {
                                Console.WriteLine("Kissebb mint 13?(igen/nem)");
                                String s1 = Console.ReadLine();
                                if ("igen" == s1)
                                {
                                    for (int i = 0; i < 13; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else if ("nem" == s1)
                                {
                                    for (int i = 14; i < 26; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else Console.WriteLine("Valamit elírtál");
                            }
                            else if ("nem" == c)
                            {
                                Console.WriteLine("Kissebb mint 39?(igen/nem)");
                                String s1 = Console.ReadLine();
                                if ("igen" == s1)
                                {
                                    for (int i = 28; i < 39; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else if ("nem" == s1)
                                {
                                    for (int i = 40; i < 49; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }

                                }
                                else Console.WriteLine("Valamit elírtál");
                            }
                            else Console.WriteLine("Valamit elírtál");

                        }
                        else Console.WriteLine("Valamit elírtál");

                    }
                    #endregion
                    else if ("nem" == b)
                    {
                        Console.WriteLine("76?(igen/nem)");
                        String d = Console.ReadLine();
                        if ("igen" == d)
                        {
                            Console.WriteLine("Profizmus");
                        }
                        else if ("nem" == d)
                        {
                            Console.WriteLine("hmm kissebb mint 76?(igen/nem)");
                            String c = Console.ReadLine();
                            if ("igen" == c)
                            {
                                Console.WriteLine("Kissebb mint 63?(igen/nem)");
                                String s1 = Console.ReadLine();
                                if ("igen" == s1)
                                {
                                    for (int i = 52; i < 63; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else if ("nem" == s1)
                                {
                                    for (int i = 64; i < 75; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else Console.WriteLine("Valamit elírtál");
                            }
                            else if ("nem" == c)
                            {
                                Console.WriteLine("Kissebb mint 89?(igen/nem)");
                                String s1 = Console.ReadLine();
                                if ("igen" == s1)
                                {
                                    for (int i = 78; i < 89; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else if ("nem" == s1)
                                {
                                    for (int i = 90; i < 101; i++)
                                    {
                                        Console.WriteLine(i + "? (igen/nem)");
                                        String s2 = Console.ReadLine();
                                        if ("igen" == s2)
                                        {
                                            break;
                                        }
                                        else if ("nem" == s2)
                                        {

                                        }
                                        else Console.WriteLine("Valamit elírtál");


                                    }
                                }
                                else Console.WriteLine("Valamit elírtál");
                            }
                            else Console.WriteLine("Valamit elírtál");

                        }
                        else Console.WriteLine("Valamit elírtál");

                    }
                    else Console.WriteLine("Valamit elírtál");


                }
                else Console.WriteLine("Valamit elírtál");
            }

            else if ("nem" == x)
            {
                Console.WriteLine("Jó amig gondolkozol kapsz zenét , ha megvan indíts újra :)");
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
            Console.WriteLine("Profizmus");
            Console.ReadLine();
        }
    }  }
