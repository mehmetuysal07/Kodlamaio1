namespace Kodlamaio.Entities.Concretes;

public class Instructor
{
    public int InstructorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"Instructor ID: {InstructorID} - First Name: {FirstName} - Last Name: {LastName}";
    }
}