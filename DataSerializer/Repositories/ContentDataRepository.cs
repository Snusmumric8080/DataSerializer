using Dapper;
using DataSerializer.Models;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace DataSerializer.Repositories
{
    public class ContentDataRepository : IContentDataRepository
    {
        private readonly string _connectionString;
        public ContentDataRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<int> AddContentDataAsync(IContentData model)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@p_outer_id", model.OuterId);
                parameters.Add("@p_outer_user_id", model.OuterUserId);
                parameters.Add("@p_created", model.Created);
                parameters.Add("@p_content", model.Content);
                parameters.Add("@p_guid", model.Guid);

                var result = await connection.QueryFirstOrDefaultAsync<int>(
                    "insert_ContentData",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result;
            }
        }

        public async Task<IContentData> GetContentDataById(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@p_id", id);

                var result = await connection.QueryFirstOrDefaultAsync<ContentData>(
                    "select_contentData_ById",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result;
            }
        }
    }
}