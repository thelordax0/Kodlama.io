using Business.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    class CategoryManager : ICategoryService
    {
        public void Create(Category category)
        {
            System.Console.WriteLine($"{category.Name} created succesfully.");
        }

        public void Delete(int id)
        {
            System.Console.WriteLine($"{id} deleted succesfully.");
        }

        public List<Category> GetAll()
        {
            var _categories = new List<Category>();
            _categories.Add(new Category());
            _categories.Add(new Category());
            _categories.Add(new Category());
            return _categories;
        }

        public void Update(Category category)
        {
            System.Console.WriteLine($"{category.Name} updated succesfully.");
        }
    }
}