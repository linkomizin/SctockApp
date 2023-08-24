using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorter
{
    public class SorterPallet : ISorter<Pallet>
    {
        public void GroupByMax(IEnumerable<Pallet> values)
        {
            var res = values
                .GroupBy(x => x.ExpirationDate, x => x)
                ;
        }

        public void GroupByMin(IEnumerable<Pallet> values)
        {
             
        }

        public void SortAB(IEnumerable<Pallet> values)
        {
            values.OrderBy(el=>el.Volume);
        }

        public void SortBA(IEnumerable<Pallet> values)
        {
            values.OrderByDescending(el => el.Volume);
        }
    }
}
