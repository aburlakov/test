using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal zelcena = decimal.Parse(Console.ReadLine());
            decimal plodcena = decimal.Parse(Console.ReadLine());
            int zel = int.Parse(Console.ReadLine());
            int plod = int.Parse(Console.ReadLine());

            decimal sum = zelcena*zel + plod*plodcena;
            decimal sum1 = sum / 1.94m;
            Console.WriteLine(sum1);
            Console.ReadLine();
        }
    }
}
