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
            // creating object of method and sorting into variable
            Generics<int> obj = new Generics<int>(3, 2, 6);
            Generics<double> obj1 = new Generics<double>(1.2, 5.3, 10.1);
            Generics<string> obj2 = new Generics<string>("Sonu", "sanny", "sana");

            //display result

            Console.WriteLine("Maximum integer number : " + obj.MaximumValue());
            Console.WriteLine("maximum float number : " + obj1.MaximumValue());
            Console.WriteLine("maximum string value : " + obj2.MaximumValue());
            Console.ReadLine();

        }
    }
}
