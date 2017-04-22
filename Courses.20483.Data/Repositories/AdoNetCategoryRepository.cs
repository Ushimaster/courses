namespace Courses._20483.Data.Repositories
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using Courses._20483.Core;
    using Courses._20483.Core.Repositories;

    public class AdoNetCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            var categories = new List<Category>();
            string connectionString = GetConnectionString();

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection( connectionString );

                string sql = "SELECT [Id], [Name] FROM [dbo].[Categories] ORDER BY [Name]";

                using( var command = new SqlCommand( sql, connection ) )
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while( reader.Read() )
                    {
                        var category = new Category
                        {
                            Id = (int) reader["Id"],
                            Name = (string) reader["Name"],
                        };

                        categories.Add( category );
                    }
                }

                return categories;
            }
            finally
            {
                if( connection != null )
                {
                    if( connection.State == ConnectionState.Open )
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                }
            }
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["20483ConnectionString"].ConnectionString;
        }
    }
}
