using Kodlamaio.Business.Concretes;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities.Concretes;

public class Program
{
    private static InstructorManager newIInstructorDal()
    {
        throw new NotImplementedException();
    }

    {

        CategoryManager categoryManager = new CategoryManager();
        IInstructorDal instructorManager = new IInstructorDal() ;
        CourseManager courseManager = new CourseManager();

        List<Category> categories = categoryManager.GetAll();

        foreach (Category item in categories)
        {

            Console.WriteLine(item.ToString());
        }

        List<Category> instructors = instructorManager.GetAll();

        foreach (Category item in instructors)
        {
            Console.WriteLine(item.ToString());
        }

        List<Category> courses = courseManager.GetAll();

        foreach (Category item in courses)
        {
            Console.WriteLine(item.ToString());
        }

        var result = courseManager.GetById(4);
        Console.WriteLine(result.ToString());

        Category category = new Category
        {
            CategoryID = 10,
            CategoryName = "Test",
        };

        categoryManager.Add(category);
        Console.WriteLine(category.ToString());
        
        var data = instructors.FirstOrDefault(c => c.InstructorID == 2);
        if (data != null)
        {
            data.FirstName = "Halit";
            instructorManager.Update(data);
            Console.WriteLine(data.ToString());

        }



        var data2 = categories.FirstOrDefault(c => c.CategoryID == 1);
        if (data2 != null)
        {
            categoryManager.Delete(data2);
            foreach (Category item in categories)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}



