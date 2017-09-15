using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class KList
    {        
            public int data;
            public KList next;

            public KList(int d, KList n)
            {
                data = d;
                next = n;
            }
        
        public KList Add(KList data)
        {
            KList t = this;
            while(t.next!=null)
            {
                t = t.next;
            }
            t.next = data;
            return this;
        }        
        public static KList CreateList (int size)
        {
            Random rnd = new Random();
            KList beg = new KList(rnd.Next(10), null);
            KList t = beg;
            int count = 1;
            while (count != size)
            {

                t = t.Add(new KList(rnd.Next(10), null));
                t = t.next;
                count++;
            }
            return beg;
        }
        public KList Sort(int size)
        {
            int[] arr = new int[size];
            int[] temp = new int[size];
            KList t = this;
            int i = 0;
            do
            {
                arr[i] = t.data;
                temp[i] = t.data;
                t = t.next;               
                i++;
            } while (i != size);
            
            Array.Sort(temp);
            int ok = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (temp[j] == arr[j]) ok++;
            }
            if (ok == size) return (this);
            Array.Reverse(arr);
                       
            i = 0;
            t = this;
            do
            {
                t.data = arr[i];
                t = t.next;
                i++;
            } while (i!= size);

            return this;
        }

        public void Print()
        {
            KList t = this;
            Console.Write(t.data);
            while (t.next != null)
            {
                t = t.next;
                Console.Write("-" + t.data);
                
            }
            Console.WriteLine();
        }
    }
}

