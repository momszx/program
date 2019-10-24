using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki7_teglalapl_generelos_f
{
    class Teglalap
    {
        public int x;
        public int y;
        public double width;
        public double height;
    }
    //.....................................................................................
    class Program
    {
        static void Main(string[] args)
        {
            List<Teglalap> L = new List<Teglalap>();
            Random rnd = new Random();
            Console.Write("Lista generalas indul: ");
            while (L.Count < 30)
            {
                Console.Write("{0} ", L.Count);
                Teglalap p = new Teglalap(); ;
                p.x = rnd.Next(-20, 20);
                p.y = rnd.Next(-20, 20);
                p.width = rnd.Next(10, 999) / 10.0;
                p.height = rnd.Next(10, 999) / 10.0;
                if (egyikbeSemLogBele(L, p)) L.Add(p);
            }
            Console.Write("Lista generalas kesz !!");
            // --
            foreach (Teglalap p in L)
                Console.WriteLine("x={0}, y={1}, w={2}, h={3}", p.x, p.y, p.width, p.height);
            // --
            Console.Write("<Enter> a befejezéshez");
            Console.ReadLine();
        }
        //.....................................................................................
        static bool egyikbeSemLogBele(List<Teglalap> L, Teglalap r)
        {
            foreach (Teglalap p in L)
            {
                if (belelog_e(p, r)) return false;
            }
            return true;
        }
        //.....................................................................................
        static bool belelog_e(Teglalap t1, Teglalap t2)
        {
            bool v = bv(t1, t2.x, t2.y) ||
                bv(t1, t2.x, t2.y - t2.height) ||
                bv(t1, t2.x + t2.width, t2.y) ||
                bv(t1, t2.x + t2.width, t2.y - t2.height) ||
                bv(t2, t1.x, t1.y) ||
                bv(t2, t1.x, t1.y - t1.height) ||
                bv(t2, t1.x + t1.width, t1.y) ||
                bv(t2, t1.x + t1.width, t1.y - t1.height);
            return v;
        }
        //.....................................................................................
        static bool bv(Teglalap t, double x, double y)
        {
            bool vx = (t.x <= x && x <= t.x + t.width);
            bool vy = (t.y - t.height <= y && y <= t.y);
            return (vx && vy);
        }
    }
    
}
