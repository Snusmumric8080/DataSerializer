
namespace DataSerializer.Models.DtoModels
{
    public class DocumentReadDtoModel : IDocumentReadDtoModel
    {
        public int OuterId { get; set; }
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}
