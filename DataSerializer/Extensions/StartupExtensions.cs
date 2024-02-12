

using DataSerializer.Models;
using DataSerializer.Models.DtoModels;
using DataSerializer.Repositories;
using DataSerializer.Service;

namespace DataSerializer.Extensions
{
    public static class StartupExtensions
    {
        public static void AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IContentDataService, Service.ContentData>();
            services.AddScoped<IContentDataCreateDtoModel, ContentDataCreateDtoModel>();
            services.AddScoped<IContentDataUpdateDtoModel, ContentDataUpdateDtoModel>();
            services.AddScoped<IContentDataReadDtoModel, ContentDataReadDtoModel>();
            services.AddScoped<IContentData, Models.ContentData>();        
        }
    }
}
