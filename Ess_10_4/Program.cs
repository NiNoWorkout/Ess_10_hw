using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ess_10_4
{
    public static class ExtentionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] returningArray = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                returningArray[i] = list[i];
            }

            return returningArray;
        }
    }

    public class MyList<T>
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
                if (index < myList.Length && index >= 0) return myList[index];
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

            myList.GetArray();

            Console.WriteLine(myList[0] + " " + myList[1] + " " + myList[2]);

            // Delay.
            Console.ReadKey();
        }
    }
}
