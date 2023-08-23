using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorter
{
    public interface ISorter<T> where T : class
    {
        void SortAB(Func<T,bool> predicate);
        void SortBA(Func<T,bool> predicate);
        void GroupBy(Func<T, bool> func);
    }
}
