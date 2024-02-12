namespace Service.Models
{
    public class Document : IDocument
    {
        public int Id { get; set; }
        public IDocumentState State { get; set; }
    }
}