using DataSerializer.Models;
using DataSerializer.Models.DtoModels;

namespace DataSerializer.Repositories
{
    public interface IDocumentRepository
    {
        public Task<int> AddDocumentAsync(IDocument model);
    }
}
