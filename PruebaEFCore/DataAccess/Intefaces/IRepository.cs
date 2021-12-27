namespace PruebaEFCore.DataAccess.Intefaces;

public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    void Add(T data);
    void Update(T data);
    void Delete(int id);

}