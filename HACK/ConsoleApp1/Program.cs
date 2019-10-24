using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static bool exit = false;
        static void menu(string text1, string text2 ,string text3,string text4 ,string text5 ,string text6)
        {
            Console.Clear();
            Console.Write(new string(' ', (Console.WindowWidth - text1.Length) / 2));
            Console.WriteLine(text1);
            Console.Write(new string(' ', (Console.WindowWidth - text2.Length) / 2));
            Console.WriteLine(text2);
            Console.Write(new string(' ', (Console.WindowWidth - text3.Length) / 2));
            Console.WriteLine(text3);
            Console.Write(new string(' ', (Console.WindowWidth - text4.Length) / 2));
            Console.WriteLine(text4);
            Console.Write(new string(' ', (Console.WindowWidth - text5.Length) / 2));
            Console.WriteLine(text5);
            Console.Write(new string(' ', (Console.WindowWidth - text6.Length) / 2));
            Console.WriteLine(text6);
            
        }

        static void menukezelo()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    VBUCK_ADD();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    nulazas();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    torles();
                    break;
                case ConsoleKey.Escape:
                    exit = true;
                    break;

            }
        }
        static void VBUCK_ADD()
        {
            string menu1 = "Add meg a felhasználó nevet ahova mennyen az ingyenes VBUCK :";
            Console.Write(new string(' ', (Console.WindowWidth - menu1.Length) / 2));
            Console.WriteLine(menu1);
            string jatekos_neve = Console.ReadLine();
            string menu4 = "Add meg mennyi ingyenes VBUCK-ott szeretnél:";
            Console.Write(new string(' ', (Console.WindowWidth - menu4.Length) / 2));
            Console.WriteLine(menu4);
            int szam;
            szam = int.Parse(Console.ReadLine());
            Console.Clear();
            string menu2 = "Kapcsolodás az EPICK szervereihez:";
            Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
            Console.WriteLine(menu2);
            string menu3="";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
                Console.WriteLine(menu2);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            Console.Clear();
            string menu5 = "Kapcsolódás sikeres";
            Console.Write(new string(' ', (Console.WindowWidth - menu5.Length) / 2));
            Console.WriteLine(menu5);
            string menu6 = (szam+" VBUCK jóváírás "+jatekos_neve+" számára folyamatban van");
            Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
            Console.WriteLine(menu6);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu6);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            string menu7 = ("Remélem tudod hogy nem szép dolog csalni !");
            Console.Write(new string(' ', (Console.WindowWidth - menu7.Length) / 2));
            Console.WriteLine(menu7);
            System.Threading.Thread.Sleep(900);
            string menu8 = ("Hogy megtanuld elrontom a számítógéped!");
            Console.Write(new string(' ', (Console.WindowWidth - menu8.Length) / 2));
            Console.WriteLine(menu8);
            System.Threading.Thread.Sleep(900);
            string menu9 = ("Számítógép elrontása folymatban HAHA");
            Console.Write(new string(' ', (Console.WindowWidth - menu9.Length) / 2));
            Console.WriteLine(menu9);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu9);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(100);
            }
            
            Process.Start("shutdown", "/s /t 0");
            
        }
        static void nulazas()
        {
            string menu1 = "Add meg a felhasználó nevét annak akit nulázni szeretnél:";
            Console.Write(new string(' ', (Console.WindowWidth - menu1.Length) / 2));
            Console.WriteLine(menu1);
            string jatekos_neve = Console.ReadLine();
            Console.Clear();
            string menu2 = "Kapcsolodás az EPICK szervereihez:";
            Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
            Console.WriteLine(menu2);
            string menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
                Console.WriteLine(menu2);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            Console.Clear();
            string menu5 = "Kapcsolódás sikeres";
            Console.Write(new string(' ', (Console.WindowWidth - menu5.Length) / 2));
            Console.WriteLine(menu5);
            string menu6 = (jatekos_neve + " nullázása");
            Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
            Console.WriteLine(menu6);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu6);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            string menu7 = ("Remélem tudod hogy nem szép dolog csalni !");
            Console.Write(new string(' ', (Console.WindowWidth - menu7.Length) / 2));
            Console.WriteLine(menu7);
            System.Threading.Thread.Sleep(900);
            string menu8 = ("Hogy megtanuld elrontom a számítógéped!");
            Console.Write(new string(' ', (Console.WindowWidth - menu8.Length) / 2));
            Console.WriteLine(menu8);
            System.Threading.Thread.Sleep(900);
            string menu9 = ("Számítógép elrontása folymatban HAHA");
            Console.Write(new string(' ', (Console.WindowWidth - menu9.Length) / 2));
            Console.WriteLine(menu9);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu9);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(100);
            }
            
            Process.Start("shutdown", "/s /t 0");
        }
        static void torles()
        {
            string menu1 = "Add meg a felhasználó nevét annak akit törölni szeretnél:";
            Console.Write(new string(' ', (Console.WindowWidth - menu1.Length) / 2));
            Console.WriteLine(menu1);
            string jatekos_neve = Console.ReadLine();
            Console.Clear();
            string menu2 = "Kapcsolodás az EPICK szervereihez:";
            Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
            Console.WriteLine(menu2);
            string menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu2.Length) / 2));
                Console.WriteLine(menu2);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            Console.Clear();
            string menu5 = "Kapcsolódás sikeres";
            Console.Write(new string(' ', (Console.WindowWidth - menu5.Length) / 2));
            Console.WriteLine(menu5);
            string menu6 = (jatekos_neve + " törlése");
            Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
            Console.WriteLine(menu6);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu6);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(200);
            }
            string menu7 = ("Remélem tudod hogy nem szép dolog amit művelsz !");
            Console.Write(new string(' ', (Console.WindowWidth - menu7.Length) / 2));
            Console.WriteLine(menu7);
            System.Threading.Thread.Sleep(900);
            string menu8 = ("Hogy megtanuld elrontom a számítógéped!");
            Console.Write(new string(' ', (Console.WindowWidth - menu8.Length) / 2));
            Console.WriteLine(menu8);
            System.Threading.Thread.Sleep(900);
            string menu9 = ("Számítógép elrontása folymatban HAHA");
            Console.Write(new string(' ', (Console.WindowWidth - menu9.Length) / 2));
            Console.WriteLine(menu9);
            menu3 = "";
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.Write(new string(' ', (Console.WindowWidth - menu6.Length) / 2));
                Console.WriteLine(menu9);
                menu3 += "*";
                Console.Write(new string(' ', (Console.WindowWidth - menu3.Length) / 2));
                Console.WriteLine(menu3);
                System.Threading.Thread.Sleep(100);
            }
            
            Process.Start("shutdown", "/s /t 0");
        }
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 10;
            Console.WindowWidth = 70;
            string menu1= "*************FOJTNÁJT VBUCK HACK************";
            string menu2= "*            1- VBUCK HACKELÉSE            *";
            string menu3= "*2- VBUCK NULLÁZÁSA KIVÁLASZTOTT JÁTÉKOSNÁL*";
            string menu4= "*      3- JÁTÉKOS FELHASZNÁLÓ TÖRLÉSE      *";
            string menu5= "*               ECS- KILÉPÉS               *";
            string menu6 = "********************************************";

            do
            {
                menu(menu1,menu2,menu3,menu4,menu5,menu6);
                menukezelo();
                

            } while (!exit);
        }
    }
}
