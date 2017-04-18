namespace Courses._20483.Core.Data
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class CategoryMapping: EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            this.ToTable( "Categories" );

            this.HasKey( category => category.Id )
                .Property( category => category.Id )
                .HasDatabaseGeneratedOption( DatabaseGeneratedOption.Identity );

            this.Property( category => category.Name ).IsRequired().HasMaxLength( 50 );
        }
    }
}
