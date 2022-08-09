using Newtonsoft.Json;

namespace Latoken.Api.Client.Library
{
    public class FeeScheme
    {
        [JsonProperty(PropertyName = "makerFee")]
        public string MakerFee { get; set; }

        [JsonProperty(PropertyName = "takerFee")]
        public string TakerFee { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "take")]
        public string Take { get; set; }

    }
}
