using Kodlamaio.Entities.Concretes;

namespace Kodlamaio.DataAccess.Abstracts;

public interface IGenericDal <T> where T : class
{
    List<Category> GetAll();
    Instructor GetByID(int id);
    void Add(Category t);
    void Update(Category t);
    void Delete(Category t); 
}