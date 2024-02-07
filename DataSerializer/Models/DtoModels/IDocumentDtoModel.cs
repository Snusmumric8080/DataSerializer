namespace DataSerializer.Models.DtoModels
{
    public interface IDocumentDtoModel
    {
        public int OuterId { get; set; }
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}
