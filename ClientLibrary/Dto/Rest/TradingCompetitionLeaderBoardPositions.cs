using Newtonsoft.Json;
using System.Collections.Generic;
namespace Latoken.Api.Client.Library
{
    public class TradingCompetitionLeaderBoardPositions
    {
        [JsonProperty(PropertyName = "hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty(PropertyName = "content")]
        public List<TradingCompetitionLeaderBoardPosition> Content { get; set; }

        [JsonProperty(PropertyName = "rewardHidden")]
        public bool RewardHidden { get; set; }

        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "targetHidden")]
        public bool TargetHidden { get; set; }
    }
}
