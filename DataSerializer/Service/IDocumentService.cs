using AutoMapper;
using DataSerializer.Models;
using DataSerializer.Models.DtoModels;
using DataSerializer.Repositories;
using System.Reflection.Metadata;

namespace DataSerializer.Service
{
    public interface IDocumentService
    {
        public Task<IDocumentReadDtoModel> GetDocumentByOuteridAsync(int id);
        public Task<IDocumentReadDtoModel> GetDocumentByGuidAsync(Guid guid);
        public Task<IEnumerable<IDocumentReadDtoModel>> GetAllDocumentsAsync();
        public Task<int> AddDocumentAsync(IDocumentCreateDtoModel document);
        public Task<int> UpdateDocumentAsync(IDocumentUpdateDtoModel document);
    }

    public class DocumentService : IDocumentService
    {
        private readonly ILogger<IDocumentService> _logger;

        public readonly IDocumentRepository _repo;
        public readonly IMapper _mapper;
        public DocumentService(ILogger<IDocumentService> logger, IDocumentRepository repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> AddDocumentAsync(IDocumentCreateDtoModel document)
        {
            return await _repo.AddDocumentAsync(_mapper.Map<IDocument>(document));
        }

        public Task<IEnumerable<IDocumentReadDtoModel>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDocumentReadDtoModel> GetDocumentByGuidAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<IDocumentReadDtoModel> GetDocumentByOuteridAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateDocumentAsync(IDocumentUpdateDtoModel document)
        {
            throw new NotImplementedException();
        }
    }
}
