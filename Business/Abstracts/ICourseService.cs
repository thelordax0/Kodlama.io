using Entities.Concretes;

namespace Business.Abstracts
{
    interface ICourseService
    {
        void Create(Course course);
        List<Course> GetAll();
        void Delete(int id);
        void Update(Course course);
        
    }
}