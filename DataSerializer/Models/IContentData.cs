namespace DataSerializer.Models
{
    public interface IContentData
    {
        int OuterId { get; set; }
        public int OuterUserId { get; set; }
        Guid Guid { get; set; }
        DateTime Created { get; set; }
        string Content { get; set; }
    }
}
