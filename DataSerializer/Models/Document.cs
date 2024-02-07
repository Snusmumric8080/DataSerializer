
namespace DataSerializer.Models
{
    public class Document : IDocument
    {
        public int OuterId { get; set; }
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}