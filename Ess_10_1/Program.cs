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
            int a = MyClass<int>.FactoryMethod();
            Console.WriteLine(a.GetType().Name);

            Program p = MyClass<Program>.FactoryMethod();
            Console.WriteLine(p.GetType().Name);

            // Delay.
            Console.ReadKey();
        }
    }
}
