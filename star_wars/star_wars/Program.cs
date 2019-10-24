using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace star_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Erofelhasznalo f = new Erofelhasznalo(100, "Dark Béla", 69000 , false, Kardszin.PIROS);
            Tanitvany t = new Tanitvany(110, "Joci", 5001, true, Kardszin.FEHER, 15, 99);
            //Erofelhasznalo f = new Erofelhasznalo();
            StreamWriter writer = new StreamWriter("Erofelhasznalok.txt",true);
            writer.WriteLine(f);
            writer.Close();
            Console.WriteLine(f);
            Console.WriteLine(" ");
            Console.WriteLine(t);

            List<Erofelhasznalo> lista = new List<Erofelhasznalo>();
            StreamReader reader = new StreamReader("Erofelhasznalok.txt");
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] elemek = sor.Split(';');
                Erofelhasznalo temp = new Erofelhasznalo(int.Parse(elemek[0]), elemek[1], uint.Parse(elemek[2]), bool.Parse(elemek[3]),(Kardszin) Enum.Parse(typeof(Kardszin), elemek[4]));
                lista.Add(temp);
            }

            
            Console.ReadLine();
        }
    }
}
