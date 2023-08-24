namespace ClassLibrary.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        T Get(string id);
        T Add(T item);
        void Update(T item);
        void Delete(string id);

        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);

        bool Any(Func<T, bool> predicate);

    }
}
