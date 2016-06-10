using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_online_Generic.Sorting
{
    abstract class Sorter<T>: iSortable<T>
    {
        public void Print(T[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.WriteLine(" {0} ", arrayToPrint[i]);
            }            
        }

        public abstract T[] Sort(T[] arrayToSort);
        protected T[] Swap (T[] arrayToPrint, int a1, int a2)
        {          
            T Temp = arrayToPrint[a1];
            arrayToPrint[a1] = arrayToPrint[a2];
            arrayToPrint[a2] = Temp;
            return arrayToPrint;
        }
             
    }
}
