namespace Courses._20483.Core.Data
{
    using System.Data.Entity;

    public class DbInitializer: CreateDatabaseIfNotExists<UnitOfWork>
    {
        protected override void Seed( UnitOfWork context )
        {
            CreateCategories( context );

            base.Seed( context );
        }

        private static void CreateCategories( UnitOfWork context )
        {
            var sports = new Category { Name = "Sports" };
            var gaming = new Category { Name = "Gaming" };
            var books = new Category { Name = "Books" };

            context.Categories.Add( books );
            context.Categories.Add( gaming );
            context.Categories.Add( sports );

            context.SaveChanges();
        }
    }
}
