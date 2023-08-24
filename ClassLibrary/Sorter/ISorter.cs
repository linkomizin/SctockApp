using ClassLibrary.Model;

namespace ClassLibrary.Sorter
{
    public interface ISorter<T> where T : class
    {
        void SortAB(IEnumerable<T> values);
        void SortBA(IEnumerable<Pallet> values);
        Dictionary<DateOnly, List<T>> GroupByMin(IEnumerable<Pallet> values);
        Dictionary<DateOnly, List<T>> GroupByMax(IEnumerable<Pallet> values);
        List<Pallet> TakeCountPalletByMaxDate(int count, IEnumerable<Pallet> values);
    }
}
