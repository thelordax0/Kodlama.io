using Business.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    class InstructorManager : IInstructorService
    {
        public void Create(Instructor instructor)
        {
            System.Console.WriteLine($"{instructor.Name} created succesfully.");
        }

        public void Delete(int id)
        {
            System.Console.WriteLine($"{id} deleted succesfully.");
        }

        public List<Instructor> GetAll()
        {
            List<Instructor> _instructors = new List<Instructor>();
            _instructors.Add(new Instructor());
            _instructors.Add(new Instructor());
            _instructors.Add(new Instructor());
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            System.Console.WriteLine($"{instructor.Name} updated succesfully.");
        }
    }
}