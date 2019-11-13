using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Termelo_Fogyszto_problema
{
    class Program
    {
        static string[] aruk = new string[] { "Alma","Körte","Cigány gyerek","Alig használt nem lopott halál csillag"};
        static Random rnd = new Random();
        static List<Aruk> Aruks = new List<Aruk>();



        static void Main(string[] args)
        {
            Termelo ter1 = new Termelo(aruk[rnd.Next(0,4)],rnd.Next(1,1000));
            Termelo ter2 = new Termelo(aruk[rnd.Next(0, 4)], rnd.Next(1, 1000));

            Thread t1 = new Thread(ter1.Berak);
            Thread t2 = new Thread(ter2.Berak);
            
            Fogyszto c1 = new Fogyszto(rnd.Next(1, 1000));
            
            Thread t3 = new Thread(c1.kivesz);
            
            t1.Start(); t2.Start(); t3.Start();
            Console.ReadKey();
        }
        class Termelo
        {
            string aru;
            int ar;
            public Termelo(string aru, int ar)
            {
                this.aru = aru;
                this.ar = ar;
            }
            
            Aruk aruk = new Aruk(aru, ar);
            
            int alma = 0;
            int korte = 0;
            int Cigány_gyerek = 0;
            int Alig_használt_nem_lopott_halál_csillag = 0;
            int db=50;
            
            public void Berak()
            {
                Console.WriteLine("Termelő elindult");
                int count = 0;
                while (this.db != count)
                {
                    lock (Aruks)
                    {
                        Aruks.Add(aruk);
                        Monitor.PulseAll(Aruks);
                    }
                }
                Console.WriteLine("Termelő megált");
            }
        }
        class Fogyszto
        {
            
            int zsebpenz;

            public Fogyszto(int ar)
            {
                zsebpenz = ar;
                
            }
            public void kivesz()
            {
                Console.WriteLine("Fogasztó elindult");
                bool end = false;
                
                while (!end)
                {
                    
                    lock (Aruks)
                    {
                       
                        Aruks.RemoveAt(0);
                        
                        Monitor.PulseAll(Aruks);
                    }
                    
                }
                Console.WriteLine("Fogasztó megált");
            }
        }
        class Aruk
        {
            string neve;
            int ara;
            public Aruk(string neve, int ara)
            {
                this.neve = neve;
                this.ara = ara;
            }
           
        }
    }
}
