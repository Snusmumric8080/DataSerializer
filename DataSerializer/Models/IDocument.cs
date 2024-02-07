namespace DataSerializer.Models
{
    public interface IDocument
    {
        int OuterId { get; set; }
        Guid Guid { get; set; }
        DateTime Created { get; set; }
        string Content { get; set; }
    }
}
