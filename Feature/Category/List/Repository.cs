using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.List
{
    public class Repository
    {
        public async Task<IEnumerable<ViewModel.Category>> GetCategoriesAsync()
        {
            string connectionString = "Server=.; Database=Teacher.Database;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (var db = new SqlConnection(connectionString))
            {
                var sql = "SELECT [Id], [Name] FROM [dbo].[Category]";
                return await db.QueryAsync<ViewModel.Category>(sql);
            }
        }
    }
}
