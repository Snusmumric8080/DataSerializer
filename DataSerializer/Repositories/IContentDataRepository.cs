using DataSerializer.Models;
using DataSerializer.Models.DtoModels;

namespace DataSerializer.Repositories
{
    public interface IContentDataRepository
    {
        public Task<int> AddContentDataAsync(IContentData model);
        public Task<IContentData> GetContentDataById(int id);
    }
}
