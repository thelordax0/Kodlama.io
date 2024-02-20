using Entities.Concretes;

namespace Business.Abstracts
{
    interface IInstructorService
    {

        void Create(Instructor instructor);
        List<Instructor> GetAll();
        void Delete(int id);
        void Update(Instructor course);
    }
}