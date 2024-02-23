namespace Kodlamaio.Entities.Concretes;

public class Category
{
    public int InstructorID;
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string FirstName { get; set; }

    public override string ToString()
    {
        return $"Category ID: {CategoryID} - Category Name: {CategoryName}";
    }
}