using PruebaEFCore.DataAccess.Intefaces;
using PruebaEFCore.DataAccess.Model;

namespace PruebaEFCore.DataAccess.Repositories;

public class BlogRepository : Repository<Blog>, IBlogRepository
{
    public BlogRepository(DatabaseDbContext context) : base(context)
    {
    }
}