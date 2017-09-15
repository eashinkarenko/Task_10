using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static KList beg;
        static int size;
        static int VvodChisla() //проверка числа 0-30
        {
            Console.WriteLine("Введите размер списка");
            bool ok;
            int n;
            do
            {
                string vvod = Console.ReadLine();
                ok = int.TryParse(vvod, out n);
                
            } while (!ok);           
            return n;
        }
        static void Main(string[] args)
        {
            size = VvodChisla();
            beg = KList.CreateList(size);
            beg.Print();
            beg.Sort(size);
            beg.Print();
            Console.ReadLine();
        }
    }
}
