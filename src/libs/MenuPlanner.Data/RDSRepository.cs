namespace MenuPlanner.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;

    using Common;
    using Dapper;

    public abstract class RDSRepository<T> : IRepository<T> where T : Identifiable
    {
        protected readonly IDbConnection _connection;

        public RDSRepository(IDbConnection connection)
        {
            this._connection = connection;

            this._connection.Open();
        }

        public void Dispose()
        {
            this._connection.Close();
            this._connection.Dispose();
        }

        public T Get(string id)
        {
            return this._connection.QuerySingle<T>($"exec Get{nameof(T)}", new { Id = id }, commandType: CommandType.StoredProcedure);
        }

        public IList<T> GetAll()
        {
            return this._connection.Query<T>($"exec Get{nameof(T)}s").ToList();
        }

        public void Save(T t)
        {
            if (string.IsNullOrEmpty(t.Id))
            {
                t.Id = Guid.NewGuid().ToString();

                this._connection.Execute($"exec SaveNew{nameof(T)}", GetParameters(t), commandType: CommandType.StoredProcedure); 
            }
            else 
            {
                this._connection.Execute($"exec Save{nameof(T)}", GetParameters(t), commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(string id)
        {
            this._connection.Execute($"exec Delete{nameof(T)}", new { Id = id }, commandType: CommandType.StoredProcedure);
        }

        protected abstract Dictionary<string, string> GetParameters(T t);
    }
}
