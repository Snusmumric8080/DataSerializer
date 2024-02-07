

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
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IDocumentCreateDtoModel, DocumentCreateDtoModel>();
            services.AddScoped<IDocumentUpdateDtoModel, DocumentUpdateDtoModel>();
            services.AddScoped<IDocumentReadDtoModel, DocumentReadDtoModel>();
            services.AddScoped<IDocument, Document>();
            services.AddAutoMapper(typeof(Program));         
        }
    }
}
