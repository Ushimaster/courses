namespace Courses._20483.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Courses._20483.Core;
    using Courses._20483.Core.Repositories;
    using Courses._20483.Data;

    public class ProductRepository: IProductRepository
    {
        private UnitOfWork context;

        public ProductRepository()
        {
            this.context = new UnitOfWork();
        }

        public IEnumerable<Product> GetProducts()
        {
            return ( from product in this.context.Products orderby product.Name select product ).ToList();
        }

        public void CreateProduct( Product product )
        {
            this.context.Products.Add( product );
            this.context.SaveChanges();
        }
    }
}
