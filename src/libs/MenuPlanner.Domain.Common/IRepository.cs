namespace MenuPlanner.Domain.Common
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        T Get(string id);

        IList<T> GetAll();

        void Save(T item);

        void Delete(string id);
    }
}
