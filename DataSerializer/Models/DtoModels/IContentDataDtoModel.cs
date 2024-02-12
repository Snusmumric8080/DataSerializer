using Newtonsoft.Json;

namespace DataSerializer.Models.DtoModels
{
    public interface IContentDataDtoModel
    {
        public int OuterId { get; set; }
        public int OuterUserId { get; set; }
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}
