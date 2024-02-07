using Dapper;
using DataSerializer.Models;
using DataSerializer.Models.DtoModels;
using System.Data;
using System.Data.SqlClient;

namespace DataSerializer.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly string _connectionString;
        public DocumentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<int> AddDocumentAsync(IDocument model)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Content", model.Content);
                parameters.Add("@Guid", model.Guid);
                parameters.Add("@Created", model.Created);
                parameters.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var affectedRows = await connection.ExecuteAsync(
                        "AddDocument",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    );
                var id = parameters.Get<int>("@Id");
                return id;
            }
        }
    }
}