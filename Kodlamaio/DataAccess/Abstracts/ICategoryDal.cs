using Kodlamaio.Entities.Concretes;

namespace Kodlamaio.DataAccess.Abstracts;

public abstract class ICategoryDal : IGenericDal<Category>
{
    public abstract void Add(Category t);
    public abstract void Delete(Category t);
    public abstract List<Category> GetAll();
    public abstract Instructor GetByID(int id);
    public abstract void Update(Category t);
}