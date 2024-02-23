using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities.Concretes;

namespace Kodlamaio.Business.Concretes;

public class InstructorManager : IInstructorService
{
    IInstructorDal _ınstructorDal;

    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _ınstructorDal = ınstructorDal;
    }

    public void Add(Course t)
    {
        _ınstructorDal.Add(t);
    }

    public void Delete(Course t)
    {
        _ınstructorDal.Delete(t);
    }

    public List<Category> GetAll()
    {
        return _ınstructorDal.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _ınstructorDal.GetByID(id);
    }

    public void Update(Course t)
    {
        _ınstructorDal.Update(t);
    }
}