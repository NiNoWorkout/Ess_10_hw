using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ess_10_1
{
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i);

            char s = MyClass<char>.FactoryMethod();
            Console.WriteLine(i);

            // Delay.
            Console.ReadKey();
        }
    }
}
