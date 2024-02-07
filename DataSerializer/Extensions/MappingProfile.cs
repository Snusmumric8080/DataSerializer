using AutoMapper;
using DataSerializer.Models;
using DataSerializer.Models.DtoModels;

namespace DataSerializer.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Document, DocumentReadDtoModel>();
            CreateMap<DocumentUpdateDtoModel, Document>();
            CreateMap<DocumentCreateDtoModel, Document>()
                .AfterMap((dto, entity) =>
                {
                    entity.Guid = Guid.NewGuid();
                });
        }
    }
}
