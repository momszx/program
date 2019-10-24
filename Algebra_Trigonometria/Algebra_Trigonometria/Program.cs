using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_Trigonometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a fügvény 1. felét ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a fügvény 2. felét ");
            double b = Convert.ToInt32(Console.ReadLine());
            double r = Math.Sqrt(a * a + b * b);
            double c = Math.Atan(b / a);
            double degrees = c * (180 / Math.PI);
            if (a == 0 && b == 0)
            {
                degrees = 0;
            }
            
            if (degrees < 0)
            {
                degrees = degrees + 180;
            }
            if(a<0&&b < 0)
            {
                degrees = degrees + 180;
            }
            else if(a > 0 && b < 0)
            {
                degrees = degrees + 180;
            }

            Console.Clear();
            Console.WriteLine(r+"(cos"+degrees+'°'+b+"*i*(sin"+degrees+'°'+"))");
            Console.ReadLine();

        }
    }
}
