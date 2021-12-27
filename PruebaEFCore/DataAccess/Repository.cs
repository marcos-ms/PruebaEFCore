using Microsoft.EntityFrameworkCore;
using PruebaEFCore.DataAccess.Intefaces;

namespace PruebaEFCore.DataAccess;

public abstract class Repository<T> : IRepository<T> where T : class, new()
{
    private readonly DatabaseDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DatabaseDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T? GetById(int id) => _dbSet.Find(id);

    public void Add(T data) => _dbSet.Add(data);

    public void Update(T data)
    {
        _dbSet.Attach(data);
        _context.Entry(data).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        var toDelete = _dbSet.Find(id);
        if (toDelete != null) _dbSet.Remove(toDelete);
    }
}