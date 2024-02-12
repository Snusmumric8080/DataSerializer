namespace Service.Models
{
    public interface IDocument : IEntity
    {
        IDocumentState State { get; set; }
    }
}
