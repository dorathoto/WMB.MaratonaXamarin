using Newtonsoft.Json;

namespace wmbXamarin.Model
{
    public class User
    {
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}
