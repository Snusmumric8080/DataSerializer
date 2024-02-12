using AutoMapper;
using DataSerializer.Models;
using DataSerializer.Models.DtoModels;

namespace DataSerializer.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContentData, ContentDataReadDtoModel>();
            CreateMap<ContentDataUpdateDtoModel, ContentData>();
            CreateMap<ContentDataCreateDtoModel, ContentData>()
               .AfterMap((dto, entity) =>
               {
                   entity.Guid = Guid.NewGuid();
               });
            CreateMap<ContentDataCreateDtoModel, IContentData>().As<ContentData>();
        }
    }
}
