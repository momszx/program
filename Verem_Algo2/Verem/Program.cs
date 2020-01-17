using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    class Program
    {
        static void Main(string[] args)
        {
            Elem<int> szamok = new Elem<int>(3);
            Elem<string> szavak = new Elem<string>(3);
            szamok.Push(1);
            szamok.Push(2);
            szamok.Push(3);
            Console.WriteLine(szamok.Elemszam);
            Console.ReadLine();
            szamok.Peek();
            Console.WriteLine(szamok.Elemszam);
            Console.ReadLine();
            szavak.Push("Bela");
            szavak.Push("Bela");
            szavak.Push("Bela");
            Console.WriteLine(szavak.Elemszam);
            Console.ReadLine();
            szavak.Peek();
            Console.WriteLine(szavak.Elemszam);
            Console.ReadLine();
        }
    }
}
