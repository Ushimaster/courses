namespace Courses._20483.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Courses._20483.Core.Data;

    public class ProductService: IProductService
    {
        private UnitOfWork context;

        public ProductService()
        {
            this.context = new UnitOfWork();
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = from category in context.Categories select category;
            return Mapper.MapToServiceCategories( categories );
        }

        public void CreateProduct( Product product )
        {
            Core.Product dto = Mapper.MapToDomainProduct( product );
            this.context.Products.Add( dto );
            this.context.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = ( from product in context.Products select product ).ToList();
            return Mapper.MapToServiceProducts( products );
        }
    }
}