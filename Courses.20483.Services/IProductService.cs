namespace Courses._20483.Services
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract( Namespace = "http://course20483.com" )]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Category> GetCategories();

        [OperationContract]
        void CreateProduct( Product product );

        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}
