using System.Linq.Expressions;

namespace PruebaEFCore.Domain.Intefaces
{
    public interface IService<T>
    {
        public IEnumerable<T> GetAll();
        public T? GetById(int id);
        T Create(T data);
        T Update(T data);
        bool Remove(T data);
        bool Remove(int dataId);
    }
}
