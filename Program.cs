using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            double Result = Generics.MaxNumber(10.10, 20.10, 30.10);
            Console.WriteLine("{0} is max number", Result);
            Console.ReadLine();
        }
    }
}
