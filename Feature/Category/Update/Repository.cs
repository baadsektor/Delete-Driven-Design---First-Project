using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.Update
{
    public class Repository
    {
        const string connectionString = "Server=.; Database=Teacher.Database;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<ViewModel.CategoryReadModel> GetCategoryAsync(int id)
        {
            
            using (var db = new SqlConnection(connectionString))
            {
                var sql = $"SELECT [Id], [Name] FROM [dbo].[Category] WHERE [Id] = @id";
                return await db.QueryFirstAsync<ViewModel.CategoryReadModel>(sql, new { id});
            }
        }

        public async Task UpdateCategoryAsync(ViewModel.CategoryInputModel category)
        {
            using (var db = new SqlConnection(connectionString))
            {
                var sql = $"UPDATE [dbo].[Category] SET [Name] = @name WHERE [Id]=@id";
                await db.ExecuteAsync(sql, new { name = category.Name, id = category.Id });
            }
        }
    }
}
