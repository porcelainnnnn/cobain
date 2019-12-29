using Newtonsoft.Json;

namespace FMBot.LastFM.Models
{
    public class Response<T>
    {
        [JsonIgnore]
        public bool Success { get; set; }

        public ResponseStatus? Error { get; set; }

        public string Message { get; set; }

        public T Content { get; set; }
    }
}
