namespace Courses._20483.Core.Repositories
{
    using System.Collections.Generic;

    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
