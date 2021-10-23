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
            int Result = Generics.MaxNumber(15, 20, 25);
            Console.WriteLine("{0} is max number", Result);
            Console.ReadLine();
        }
    }
}
