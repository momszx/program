using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzalkezelesAlapok4
{
    class Összeadás
    {
        public int osszeg = 0;
        private int[] szamok = new int[50000];
        public void Alsofele(){
            for (int x = 0; x < szamok.Length/2-1; x++)
			{
                lock (szamok) 
                {
                    osszeg += szamok[x];
                }
			  
			}
        }
        public void felsofele(){
            for (int y = 0; y >= szamok.Length/2; y--)
			{
                lock (szamok)
                {
                    osszeg += szamok[y];
                }
			}
        }
        public Összeadás()
        {
            for (int i = 0; i < szamok.Length; i++)
			{
			  szamok[i]=1;
			}
        }
    }
}
