namespace Courses._20483.Core
{
    using System;

    public class Product
    {
        protected Product()
        {
        }

        public Product( string name, decimal price, int stock, int categoryId )
        {
            if( stock == 0 )
            {
                throw new InvalidOperationException( "The stock cannot be zero." );
            }

            CategoryId = categoryId;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
