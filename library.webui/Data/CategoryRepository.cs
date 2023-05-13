using System.Collections.Generic;
using System.Linq;

namespace shopapp.webui.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {Id=1,Name="Macera",},
                new Category {Id=2,Name="Deneme",},
                new Category {Id=3,Name="Kategori 3",},
                new Category {Id=4,Name="Kategori 4",}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }




    }
}