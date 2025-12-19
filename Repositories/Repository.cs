using FitnessTracker.Interface;
using FitnessTracker.Data;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DataContext _context;
    private readonly DbSet<T> _dbSet;
    public Repository(DataContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();

    }
    public async Task<IEnumerable<T>> GetValuesAsync(Func<IQueryable<T>, IQueryable<T>>? func = null)
    {
        IQueryable<T> dbTable = _dbSet;
        if (func is not null)
        {
            dbTable = func(dbTable);
        }
        return await dbTable.ToListAsync();
    }

    public Task<T> GetValue()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }
}