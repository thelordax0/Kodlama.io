namespace Entities.Concretes;

class Course
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int CategoryId { get; set; }
    public int InstructorId { get; set; }

    public string Description  { get; set; }

    public float Duration { get; set; }




}