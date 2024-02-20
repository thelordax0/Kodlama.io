using Business.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    class CourseManager : ICourseService
    {
        public void Create(Course course)
        {
            System.Console.WriteLine($"{course.Name} created succesfully.");
        }

        public void Delete(int id)
        {
            System.Console.WriteLine($"{id} deleted succesfully.");
        }

        public List<Course> GetAll()
        {
            List<Course> _courses = new List<Course>();
            _courses.Add(new Course());
            _courses.Add(new Course());
            _courses.Add(new Course());
            return _courses;
        }

        public void Update(Course course)
        {
            System.Console.WriteLine($"{course.Name} Updated succesfully.");
        }
    }
}