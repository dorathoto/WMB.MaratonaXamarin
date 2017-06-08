using Newtonsoft.Json;

namespace WMB.MaratonaXamarin.Model
{
    public class User
    {
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}
