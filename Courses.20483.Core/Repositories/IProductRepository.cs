namespace Courses._20483.Core.Repositories
{
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        void CreateProduct( Product product );
    }
}
