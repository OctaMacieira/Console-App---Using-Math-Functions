using System;
using System.Globalization;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, area, peri, diag;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = x * y;
            peri = (2 * x) + (2 * y);
            diag = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + peri.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diag.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
