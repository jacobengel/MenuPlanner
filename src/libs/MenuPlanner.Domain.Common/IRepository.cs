namespace MenuPlanner.Domain.Common
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T> : IDisposable
    {
        T Get(string id);

        IList<T> GetAll();

        void Save(T item);

        void Delete(string id);
    }
}
