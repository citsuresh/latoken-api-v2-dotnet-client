using Newtonsoft.Json;
using System.Collections.Generic;

namespace Latoken.Api.Client.Library
{
    public class Airdrop
    {
        [JsonProperty(PropertyName = "currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty(PropertyName = "ref_link")]
        public string Reflink { get; set; }

        [JsonProperty(PropertyName = "reward")]
        public string Reward { get; set; }

        [JsonProperty(PropertyName = "ticker")]
        public string Ticker { get; set; }
    }
}
