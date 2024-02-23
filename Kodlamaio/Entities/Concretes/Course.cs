namespace Kodlamaio.Entities.Concretes;

public class Course
{
    public int CourseID { get; set; }
    public int CategoryID { get; set; }
    public int InstructorID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CompletionRate { get; set; }
    public string FirstName { get; set; }

    public override string ToString()
    {
        return $"Course ID: {CourseID} - Course Name: {Name} - Description: {Description} - Completion Rate: %{CompletionRate}";
    }
}