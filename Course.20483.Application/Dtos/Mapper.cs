namespace Courses._20483.Application.Dtos
{
    using System.Collections.Generic;

    public class Mapper
    {
        public static IEnumerable<Category> MapToServiceCategories( IEnumerable<Core.Category> categories )
        {
            var dtos = new List<Category>();
            
            foreach( Core.Category category in categories )
            {
                var dto = new Category
                {
                    Id = category.Id,
                    Name = category.Name,
                };

                dtos.Add( dto );
            }

            return dtos;
        }

        public static Core.Product MapToDomainProduct( Product dto )
        {
            var product = new Core.Product( dto.Name, dto.Price, dto.Stock, dto.CategoryId );
            product.Description = product.Description;

            return product;
        }

        public static IEnumerable<Product> MapToServiceProducts( IEnumerable<Core.Product> products )
        {
            var dtos = new List<Product>();

            foreach( Core.Product product in products )
            {
                var dto = new Product
                {
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category.Name,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                };

                dtos.Add( dto );
            }

            return dtos;
        }
    }
}