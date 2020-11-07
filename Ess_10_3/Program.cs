using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ess_10_3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyArray;
        TValue[] valueArray;
        private int counter = 0;

        public MyDictionary()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            counter++;
            TKey[] tmpKey = new TKey[counter];
            TValue[] tmpValue = new TValue[counter];

            for (int i = 0; i < keyArray.Length; i++)
            {
                tmpKey[i] = keyArray[i];
                tmpValue[i] = valueArray[i];
            }

            tmpKey[counter - 1] = key;
            tmpValue[counter - 1] = value;

            keyArray = tmpKey;
            valueArray = tmpValue;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < counter)
                    return keyArray[index].ToString() + " - " + valueArray[index].ToString();
                else
                    return "Wrong index / out of array";
            }
        }

        public int Counter
        {
            get { return counter; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, char> myD = new MyDictionary<int, char>();

            myD.Add(1, 'a');
            myD.Add(2, 'b');
            myD.Add(3, 'c');

            Console.WriteLine(myD.Counter + " <== counter");

            Console.WriteLine(myD[1]);
            Console.WriteLine(myD[3]);

            // Delay.
            Console.ReadKey();
        }
    }
}
