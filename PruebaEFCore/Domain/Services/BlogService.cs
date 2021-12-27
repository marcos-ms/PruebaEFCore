using AutoMapper;
using PruebaEFCore.DataAccess.Intefaces;
using PruebaEFCore.DataAccess.Model;
using PruebaEFCore.Domain.Intefaces;
using PruebaEFCore.Domain.Model;

namespace PruebaEFCore.Domain.Services;

public class BlogService : IBlogService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlogService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public IEnumerable<BlogDto> GetAll()
    {
        return _unitOfWork.Blogs.GetAll().Select(b => _mapper.Map<BlogDto>(b));
    }

    public BlogDto? GetById(int id)
    {
        return _mapper.Map<BlogDto>(_unitOfWork.Blogs.GetById(id));
    }

    public BlogDto Create(BlogDto data)
    {
        _unitOfWork.Blogs.Add(_mapper.Map<Blog>(data));
        _unitOfWork.Save();

        return data;
    }

    public BlogDto Update(BlogDto data)
    {
        _unitOfWork.Blogs.Update(_mapper.Map<Blog>(data));
        _unitOfWork.Save();

        return data;
    }

    public bool Remove(BlogDto data)
    {
        return Remove(data.BlogId);
    }

    public bool Remove(int dataId)
    {
        _unitOfWork.Blogs.Delete(dataId);
        return _unitOfWork.Save() <= 0;
    }
}