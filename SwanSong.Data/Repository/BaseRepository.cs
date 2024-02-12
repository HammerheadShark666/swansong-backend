using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly SwanSongContext _context;

    public BaseRepository(SwanSongContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
    {
        return await _context.Set<T>().Where(expression).ToListAsync();
    }

    public async Task<IEnumerable<T>> AllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> ByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    } 
} 