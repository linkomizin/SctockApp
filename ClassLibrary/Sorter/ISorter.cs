using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorter
{
    public interface ISorter<T> where T : class
    {
        void SortAB(IEnumerable<T> values);
        void SortBA(IEnumerable<Pallet> values);
        void GroupByMin(IEnumerable<Pallet> values);
        void GroupByMax(IEnumerable<Pallet> values);
    }
}
