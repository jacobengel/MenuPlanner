namespace MenuPlanner.Domain
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMenuPlannerRepository<T>
    {
        Task<T> GetAsync(string id);

        Task<List<T>> GetAsync();

        Task<string> CreateAsync(T ingredient);

        Task UpdateAsync(T ingredient);

        Task DeleteAsync(string id);
    }
}