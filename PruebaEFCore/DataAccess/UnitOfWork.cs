using PruebaEFCore.DataAccess.Intefaces;
using PruebaEFCore.DataAccess.Repositories;

namespace PruebaEFCore.DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseDbContext _context;
    private BlogRepository? _blogs;

    public IBlogRepository Blogs => _blogs ??= new BlogRepository(_context);

    public UnitOfWork(DatabaseDbContext context)
    {
        _context = context;
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}