using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ess_10_2
{
    class MyList<T>
    {
        T[] myList;
        private int counter = 0;

        public MyList()
        {
            myList = new T[counter];
        }

        public void Add(T adder)
        {
            counter++;
            T[] tmp = new T[counter];

            for (int i = 0; i < myList.Length; i++)
            {
                tmp[i] = myList[i];
            }

            tmp[counter - 1] = adder;

            myList = new T[counter];
            myList = tmp;
        }

        public int Count
        {
            get { return myList.Length; }
        }

        public T this[int index]
        {
            get
            {
                if(index < myList.Length && index >= 0) return myList[index];
                else return default(T);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            Console.WriteLine(myList.Count + "  <== property");
            myList.Add(5);
            Console.WriteLine(myList.Count + "  <== property");
            myList.Add(55);
            Console.WriteLine(myList.Count + "  <== property");
            myList.Add(555);

            Console.WriteLine(myList[1] + "  <== indexator");
            Console.WriteLine(myList.Count + "  <== property");

            // Delay.
            Console.ReadKey();
        }
    }
}
