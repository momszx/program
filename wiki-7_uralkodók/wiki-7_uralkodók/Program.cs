using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiki_7_uralkodók
{
    class Urakodojellemzok
    {
        public uint UralKezd;
        public uint UralEv;
        public uint Kedvelteg;
    }
    class Uralkodoegyezes
    {
        public int Egyikuralkodo;
        public int Masikuralkodo;
    }
    class Program
    {
        static int Max (List<Urakodojellemzok> uralkodok)
        {
            int max = 0;
            
            foreach (var item in uralkodok)
            {

                if (max < item.UralEv)
                {
                    max = (int) item.UralEv;

                }
            }

            return max; 
        }

        static List<Uralkodoegyezes> Egyezes(List<Urakodojellemzok> U3)
        {
            List<Uralkodoegyezes> uralkodoegy = new List<Uralkodoegyezes>();
            for (int i = 0; i < U3.Count; i++)
            {
                int seged = (int)U3[i].UralKezd;
                for (int n = 0; n < U3[n].UralEv; n++)
                {
                    seged = seged + n;
                    for (int x = 1; x < (U3.Count-1); x++)
                    {
                        int seged2 = (int)U3[x].UralKezd;
                        if (seged == seged2)
                        {
                            Uralkodoegyezes egy = new Uralkodoegyezes();
                            egy.Egyikuralkodo = i;
                            egy.Masikuralkodo = x;
                            uralkodoegy.Add(egy);
                        }
                    }
                }
            }

            return uralkodoegy;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Urakodojellemzok> U = new List<Urakodojellemzok>();
            Console.WriteLine("Uralkodok Generálása");
            while (U.Count < 30)
            {
                Urakodojellemzok U2 = new Urakodojellemzok();
                U2.UralEv =(uint) rnd.Next(100);
                U2.UralKezd = (uint)rnd.Next(2000);
                U2.Kedvelteg = (uint)rnd.Next(1, 11);
                U.Add(U2);
            }
            int max = Max(U);


            foreach (var item in U)
            {
                Console.WriteLine("Uralkodás Kezdete "+item.UralKezd);
                Console.WriteLine("Uralkodások éve "+item.UralEv);
                Console.WriteLine("Mennyire kedvelték "+item.Kedvelteg);
                Console.WriteLine(" ");
            }
            Console.WriteLine(max);
            List<Uralkodoegyezes> uralkodoegy2 = new List<Uralkodoegyezes>();
            uralkodoegy2= Egyezes(U);
            for (int i = 0; i < uralkodoegy2.Count; i++)
            {
                Console.WriteLine("xy Ekkortol uralkodot " + U[uralkodoegy2[i].Egyikuralkodo].UralKezd + " És yx egy idöben uralkodot aki " + U[uralkodoegy2[i].Masikuralkodo].UralKezd + "-tól.");
                Console.WriteLine("xy " + U[uralkodoegy2[i].Egyikuralkodo].UralEv + " évet uralkodot És yx pedig " + U[uralkodoegy2[i].Masikuralkodo].UralEv + " évet uralkodot.");
                Console.WriteLine("xy 10/" + U[uralkodoegy2[i].Egyikuralkodo].Kedvelteg + " volt kedvelt míg yx 10/" + U[uralkodoegy2[i].Masikuralkodo].Kedvelteg + " volt kedvelt");
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            

            Console.ReadLine();
        }
    }
}
