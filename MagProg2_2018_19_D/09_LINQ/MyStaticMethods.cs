using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LINQ
{
    static class MyStaticMethods
    {
        //Kiterjesztő metódusok
        public static void WriteToConsole(this List<int> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
                Console.Write("{0}, ", lista[i]);
            Console.WriteLine(lista[lista.Count - 1]);
        }
        public static void WriteToConsole<T>(this List<T> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
                Console.WriteLine("{0}", lista[i]);
            Console.WriteLine(lista[lista.Count - 1]);
        }

        public static string AsName(this string name)
        {
            //"troll ede mátyás" -> "Troll Ede Mátyás"
            string[] parts = name.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < parts.Length; i++)
            {
                sb.Append(parts[i][0].ToString().ToUpper());
                sb.Append(parts[i].Substring(1).ToLower());
                if (i != parts.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
