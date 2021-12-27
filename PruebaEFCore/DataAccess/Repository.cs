using Microsoft.EntityFrameworkCore;
using PruebaEFCore.DataAccess.Intefaces;

namespace PruebaEFCore.DataAccess;

public abstract class Repository<T> : IRepository<T> where T : class, new()
{
    private readonly DatabaseDbContext _context;
    private DbSet<T> _dbSet;

    private DbSet<T> DbSet => _dbSet ??= _context.Set<T>();

    public Repository(DatabaseDbContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll()
    {
        //OPCION 1
        //return DbSet.ToList();
        //OPCION 2
        return DbSet.AsNoTracking().ToList();
    }

    public T? GetById(int id) => DbSet.Find(id);

    public void Add(T data) => DbSet.Add(data);

    public void Update(T data)
    {
        DbSet.Attach(data);
        _context.Entry(data).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        var toDelete = _dbSet.Find(id);
        if (toDelete != null) _dbSet.Remove(toDelete);
    }
}