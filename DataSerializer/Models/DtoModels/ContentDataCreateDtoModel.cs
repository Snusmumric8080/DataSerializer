

using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DataSerializer.Models.DtoModels
{
    public class ContentDataCreateDtoModel : IContentDataCreateDtoModel
    {
        [JsonProperty("outerId")]
        public int OuterId { get; set; }

        [JsonProperty("outerUserId")]
        public int OuterUserId { get; set; }

        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
