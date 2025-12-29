namespace FitnessTracker.Interface.IRepository;

public interface IRepository<T>
{
    /* await _context.Workout
        .Include(w => w.LoggedExercise)
            .ThenInclude(le => le.Exercse)
        .Include(w => w.LoggedExercise)
            .ThenInclude(le => le.Sets)
        .FirstOrDefaultAsync(w => w.id == id);
    */
    Task<IEnumerable<T>> GetValuesAsync(Func<IQueryable<T>, IQueryable<T>>? func = null);
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}