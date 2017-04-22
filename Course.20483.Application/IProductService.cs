namespace Courses._20483.Application
{
    using System.Collections.Generic;
    using Courses._20483.Core;

    public interface IProductService
    {
        IEnumerable<Dtos.Category> GetCategories();

        IEnumerable<Dtos.Product> GetProducts();

        void CreateProduct( Dtos.Product dto );
    }
}
