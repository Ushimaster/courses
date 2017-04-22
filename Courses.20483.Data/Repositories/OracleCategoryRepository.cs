namespace Courses._20483.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using Courses._20483.Core;
    using Courses._20483.Core.Repositories;

    public class OracleCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            // Se conecta a Oracle para obtener datos;
            throw new NotImplementedException();
        }
    }
}
