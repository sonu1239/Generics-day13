using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    
    
        class Generics<T> where T : IComparable
        {
            private T first, second, third;                //instance variable
            public Generics(T first, T second, T third)   //constructor
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }
            public static T MaxValue(T first, T second, T third)
            {

                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                {
                    return first;                                  ////returning value if condition is true
                }
                if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                {
                    return second;
                }
                if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                {
                    return third;
                }
                return default;
            }
            public T MaximumValue()
            {
                Generics<T>.MaxValue(this.first, this.second, this.third);
                T max = Generics<T>.MaxValue(this.first, this.second, this.third);
                return max;
            }


        }
    
}