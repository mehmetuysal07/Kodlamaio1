using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities.Concretes;

namespace Kodlamaio.Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public CourseManager()
    {
        throw new NotImplementedException();
    }

    public void Add(Course t)
    {
        _courseDal.Add(t);
    }

    public void Delete(Course t)
    {
        _courseDal.Delete(t);
    }

    public List<Category> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _courseDal.GetByID(id);
    }

    public void Update(Course t)
    {
        _courseDal.Update(t);
    }
}
