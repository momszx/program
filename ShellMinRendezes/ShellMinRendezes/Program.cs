using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellMinRendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                int h = rnd.Next(200);
                Console.WriteLine(h);
                list.Add(h);
            }
            int[] tomb = list.ToArray();
            Console.WriteLine("");
            shellMinRendezes(tomb);
            Console.ReadLine();
        }
        static void shellMinRendezes(int[] a)
        {
            int i, j, minh, d, c;
            int n = a.Length;
            d = n;
            do
            {
                d = d / 3 + 1;
                for (int k = 0; k < d; k++)
                {
                    j = k;
                    while (j<n-d)
                    {
                        minh = j;
                        i = j + d;
                        while (i<n)
                        {
                            if (a[i]<a[minh])
                            {
                                minh = i;
                            }
                            i += d;
                        }
                        if (j!=minh)
                        {
                            c = a[j];
                            a[j] = a[minh];
                            a[minh] = c;
                        }
                        j += d;
                    }
                }
            } while (d != 1);
            for (int x = 0; x < a.Length; x++)
            {
                Console.WriteLine(a[x]);
            }
        }
    }
}
