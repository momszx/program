using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzivBinKereeses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int keresett = 7;
            bool valasz= RekurzivBKereses(lista, keresett, 0, lista.Count);
            if (valasz)
            {
                Console.WriteLine("igaz");
            }
            else
            {
                Console.WriteLine("hamis");
            }
            Console.ReadLine();
            
        }

        static bool RekurzivBKereses(List<int> lista, int keresett, int elso, int utolso)
        {
            if (elso > utolso)
            {
                return false;
            }
            else
            {
                int k = (elso + utolso) / 2;
                if (lista[k] > keresett)
                {
                    return RekurzivBKereses(lista, keresett, elso, k - 1);
                }
                else
                {
                    if (lista[k] < keresett)
                    {
                        return RekurzivBKereses(lista, keresett, k + 1, utolso);
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
