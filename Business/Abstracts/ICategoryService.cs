using Entities.Concretes;

namespace Business.Abstracts
{
    interface ICategoryService
    {
        void Create(Category category);
        List<Category> GetAll();
        void Delete(int id);
        void Update(Category category);
    }
}