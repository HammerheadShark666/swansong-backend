using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<T> ByIdAsync(int id);
    Task<IEnumerable<T>> AllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity); 
}