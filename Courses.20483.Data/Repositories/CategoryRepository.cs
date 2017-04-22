namespace Courses._20483.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Courses._20483.Core;
    using Courses._20483.Core.Repositories;
    using Courses._20483.Data;

    public class CategoryRepository: ICategoryRepository
    {
        private UnitOfWork context;

        public CategoryRepository()
        {
            this.context = new UnitOfWork();
        }

        public IEnumerable<Category> GetCategories()
        {
            return ( from category in this.context.Categories orderby category.Name select category ).ToList();
        }
    }
}
