using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_online_Generic.Sorting
{
    interface iPrintable<T>
    {
        void Print(T[] arrayToPrint);
    }
}
