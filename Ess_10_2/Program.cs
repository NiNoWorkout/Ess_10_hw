using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ess_10_2
{
    class MyList<T>
    {
        private T[] instance;

        public MyList()
        {
            instance = new T[0];
        }

        public void Add(T adder)
        {
            T[] prom = new T[instance.Length + 1];

            for (int i = 0; i < instance.Length; i++)
            {
                prom[i] = instance[i];
            }

            prom[instance.Length] = adder;
            instance = prom;
        }

        public int GetNumbers
        {
            get { return instance.Length; }
        }

        public T this[int i]
        {
            get
            {
                if (i < instance.Length)
                {
                    return instance[i];
                }
                else
                {
                    return default;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> my1 = new MyList<int>();

            my1.Add(0);
            my1.Add(1);
            my1.Add(2);
            my1.Add(3);

            int i = 3;

            Console.WriteLine($"The numbers: {my1.GetNumbers}");
            Console.WriteLine($"my1[{i}] = {my1[i]}");

            // Delay.
            Console.ReadKey();
        }
    }
}
