using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WorkerHub.Infrastructure
{
    public interface IAsyncRepository<T>
    {
        Task<T> GetSingleBySpecAsync(Expression<Func<T, bool>> spec);
        Task<List<T>> ListAllAsync();
        Task<List<T>> ListBySpecAsync(Expression<Func<T, bool>> spec);
        Task<T> AddAsync(T entity);
        Task<List<T>> AddListAsync(List<T> entity);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteListAsync(List<T> entity);
        Task<List<T>> ExecQueryAsync(string query, params object[] parameters);
        Task<int> ExecuteProcedureWithoutResultAsync(string procedureName, params object[] parameters);


    }
}
