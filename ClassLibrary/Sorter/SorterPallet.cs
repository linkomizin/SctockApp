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
        public Dictionary<DateOnly, List<Pallet>> GroupByMax(IEnumerable<Pallet> values)
        {
            var res = values
                .GroupBy(x => x.ExpirationDate)
                .OrderByDescending(el => el.Key)
                .ToDictionary(k => k.Key, pa => pa
                                                .Select(el => el)
                                                .OrderByDescending(el => el.Volume)
                                                .ToList());
            return res;
        }

        public Dictionary<DateOnly, List<Pallet>> GroupByMin(IEnumerable<Pallet> values)
        {
            var res = values
               .GroupBy(x => x.ExpirationDate)
               .OrderBy(el => el.Key)
               .ToDictionary(
                                k => k.Key,
                                 pa => pa
                                 .Select(el => el)
                                    .OrderByDescending(el => el.Volume)
                                    .ToList());
            return res;
        }
        public void SortAB(IEnumerable<Pallet> values)
        {
            values.OrderBy(el => el.Volume);
        }

        public void SortBA(IEnumerable<Pallet> values)
        {
            values.OrderByDescending(el => el.Volume);
        }

        public List<Pallet> TakeCountPalletByMaxDate(int count, IEnumerable<Pallet> values)
        {
            var res = values
                .OrderByDescending(x=>x.ExpirationDate)
                .Take(count)
                .ToList();
            return res;
        }
    }
}
