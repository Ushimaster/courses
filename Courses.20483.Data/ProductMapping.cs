namespace Courses._20483.Data
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Courses._20483.Core;

    public class ProductMapping: EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            this.ToTable( "Products" );
            this.HasKey( product => product.Id )
                .Property( product => product.Id )
                .HasDatabaseGeneratedOption( DatabaseGeneratedOption.Identity );

            this.Property( product => product.Name ).IsRequired().HasMaxLength( 50 );
            this.Property( product => product.Description ).IsOptional().HasMaxLength( 500 );

            this.HasRequired( product => product.Category )
                .WithMany( category => category.Products )
                .HasForeignKey( product => product.CategoryId )
                .WillCascadeOnDelete( false );
        }
    }
}
