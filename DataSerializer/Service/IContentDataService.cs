using AutoMapper;
using DataSerializer.Models;
using DataSerializer.Models.DtoModels;
using DataSerializer.Repositories;
using System.Reflection.Metadata;

namespace DataSerializer.Service
{
    public interface IContentDataService
    {
        public Task<IContentDataReadDtoModel> GetContentDataByOuteridAsync(int id);
        public Task<IContentDataReadDtoModel> GetContentDataByIdAsync(int id);
        public Task<IContentDataReadDtoModel> GetContentDataByGuidAsync(Guid guid);
        public Task<IEnumerable<IContentDataReadDtoModel>> GetAllContentDataAsync();
        public Task<int> AddContentDataAsync(IContentDataCreateDtoModel document);
        public Task<int> UpdateContentDataAsync(IContentDataUpdateDtoModel document);
    }

    public class ContentData : IContentDataService
    {
        private readonly ILogger<IContentDataService> _logger;

        public readonly IContentDataRepository _repo;
        public readonly IMapper _mapper;
        public ContentData(ILogger<IContentDataService> logger, IContentDataRepository repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> AddContentDataAsync(IContentDataCreateDtoModel document)
        {
            var res = await _repo.AddContentDataAsync(_mapper.Map<IContentData>(document));
            _logger.LogDebug("Add");
            return res;
        }

        public async Task<IContentDataReadDtoModel> GetContentDataByIdAsync(int id)
        {
            var res = await _repo.GetContentDataById(id);
            return _mapper.Map<IContentDataReadDtoModel>(res);
        }

        public async Task<IEnumerable<IContentDataReadDtoModel>> GetAllContentDataAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IContentDataReadDtoModel> GetContentDataByGuidAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task<IContentDataReadDtoModel> GetContentDataByOuteridAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateContentDataAsync(IContentDataUpdateDtoModel document)
        {
            throw new NotImplementedException();
        }
    }
}
