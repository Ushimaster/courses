namespace Courses._20483.Data
{
    using System.Data.Entity;
    using Courses._20483.Core;

    public class UnitOfWork: DbContext
    {
        public UnitOfWork()
            : base( "20483ConnectionString" )
        {
            Database.SetInitializer( new DbInitializer() );
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            modelBuilder.Configurations.Add( new CategoryMapping() );
            modelBuilder.Configurations.Add( new ProductMapping() );

            base.OnModelCreating( modelBuilder );
        }
    }
}
