namespace Courses._20483.Application
{
    using System.Collections.Generic;
    using Courses._20483.Application.Dtos;
    using Courses._20483.Core.Repositories;
    using Courses._20483.Data.Repositories;

    public class ProductService: IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductService()
            : this( new ProductRepository(), new AdoNetCategoryRepository() )
        {
        }

        public ProductService( IProductRepository productRepository,
                               ICategoryRepository categoryRepository )
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categories = this.categoryRepository.GetCategories();
            return Mapper.MapToServiceCategories( categories );
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = this.productRepository.GetProducts();
            return Mapper.MapToServiceProducts( products );
        }

        public void CreateProduct( Product dto )
        {
            Core.Product product = Mapper.MapToDomainProduct( dto );
            this.productRepository.CreateProduct( product );
        }
    }
}
