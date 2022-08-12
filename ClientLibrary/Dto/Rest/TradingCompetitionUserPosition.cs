using Newtonsoft.Json;
namespace Latoken.Api.Client.Library
{
    public class TradingCompetitionUserPosition
    {
        [JsonProperty(PropertyName = "nickname")]
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "targetValue")]
        public string TargetValue { get; set; }

        [JsonProperty(PropertyName = "rewardValue")]
        public string RewardValue { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }
    }
}
