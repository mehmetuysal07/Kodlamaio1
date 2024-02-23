using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities.Concretes;

namespace Kodlamaio.Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDAL;

    public CategoryManager(ICategoryDal categoryDAL)
    {
        _categoryDAL = categoryDAL;
    }

    public CategoryManager()
    {
        throw new NotImplementedException();
    }

    public void Add(Category t)
    {
        _categoryDAL.Add(t);
    }

    public void Delete(Category t)
    {
        _categoryDAL.Delete(t);
    }

    public List<Category> GetAll()
    {
        return _categoryDAL.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _categoryDAL.GetByID(id);
    }

    public void Update(Category t)
    {
        _categoryDAL.Update(t);
    }
}
