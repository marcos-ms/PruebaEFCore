using PruebaEFCore.DataAccess.Repositories;

namespace PruebaEFCore.DataAccess.Intefaces;

public interface IUnitOfWork
{
    IBlogRepository Blogs { get; }

    int Save();
}