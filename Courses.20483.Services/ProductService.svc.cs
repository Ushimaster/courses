namespace Courses._20483.Services
{
    using System.Collections.Generic;
    using Courses._20483.Application.Dtos;

    public class ProductService: IProductService
    {
        private readonly Application.IProductService applicationService;

        public ProductService()
            : this( new Application.ProductService() )
        {
        }

        public ProductService( Application.IProductService applicationService  )
        {
            this.applicationService = applicationService;
        }

        public IEnumerable<Category> GetCategories()
        {
            return this.applicationService.GetCategories();
        }

        public void CreateProduct( Product dto )
        {
            this.applicationService.CreateProduct( dto );
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.applicationService.GetProducts();
        }
    }
}