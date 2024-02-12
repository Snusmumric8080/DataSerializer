
namespace DataSerializer.Models.DtoModels
{
    public class ContentDataUpdateDtoModel : IContentDataUpdateDtoModel
    {
        public int OuterId { get; set; }
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public int OuterUserId { get; set; }
    }
}
