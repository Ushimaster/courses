namespace Courses._20483.Services
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using Courses._20483.Application.Dtos;

    [ServiceContract( Namespace = "http://course20483.com" )]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Category> GetCategories();

        [OperationContract]
        void CreateProduct( Product dto );

        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}
