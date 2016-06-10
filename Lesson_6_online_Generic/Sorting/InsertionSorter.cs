using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_online_Generic.Sorting
{
    class InsertionSorter<T> : Sorter<T>
    {
        public override T[] Sort(T[] arrayToSort)
        {
            if (!(arrayToSort[0] is IComparable))
            {
                Console.WriteLine("Error! Type {0} doesn`t implement iComparable interface. \n Array was NOT sorted", arrayToSort[0].GetType().Name);
                return arrayToSort;
            }
            else
            {
                bool swaped;
                do
                {
                    swaped = false;
                    for (int i = 0; i < arrayToSort.Length - 1; i++)
                    {
                        IComparable iCurrentIndex = (IComparable)arrayToSort[i];
                        IComparable iNextIndex = (IComparable)arrayToSort[i + 1];

                        if (iCurrentIndex.CompareTo(iNextIndex) > 0)
                        {
                            Swap(arrayToSort, i, i + 1);
                            swaped = true;
                        }
                    }
                } while (swaped);
                return arrayToSort;
            }
        }
    }
}
