using Newtonsoft.Json;
using System.Collections.Generic;
namespace Latoken.Api.Client.Library
{
    public class TradingCompetition
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        public long StartDate { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public long EndDate { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string CurrencyId { get; set; }

        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "minTarget")]
        public decimal MinTarget { get; set; }

        [JsonProperty(PropertyName = "winnersLimit")]
        public int WinnersLimit { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        public TopWinners TopWinners { get; set; }
        public List<SplitBudget> SplitBudgets { get; set; }
        public LuckyWinners LuckyWinners { get; set; }
        public List<PlaceReward> PlaceRewards { get; set; }
        public OthersReward OthersReward { get; set; }
    }

    public class TopWinners
    {
        [JsonProperty("rewards")]
        public List<string> rewards { get; set; }
    }

    public class SplitBudget
    {
        [JsonProperty("budget")]
        public string budget { get; set; }

        [JsonProperty("split")]
        public string split { get; set; }

        [JsonProperty("limit")]
        public int limit { get; set; }

        [JsonProperty("step")]
        public int step { get; set; }
    }

    public class LuckyWinners
    {
        [JsonProperty("limit")]
        public int limit { get; set; }

        [JsonProperty("reward")]
        public string reward { get; set; }

        public override string ToString()
        {
            return limit.ToString() + " -> " + reward;
        }
    }


    public class PlaceReward
    {
        [JsonProperty("from")]
        public int from { get; set; }

        [JsonProperty("to")]
        public int to { get; set; }

        [JsonProperty("rewardValue")]
        public string rewardValue { get; set; }

        public override string ToString()
        {
            if (from == to)
            {
                return from.ToString() + "->" + rewardValue;
            }
            else
            {
                return "(" + from.ToString() + "-" + to.ToString() +")" + "->" + rewardValue;
            }
        }
    }

    public class OthersReward
    {
        [JsonProperty("from")]
        public int from { get; set; }

        [JsonProperty("to")]
        public int to { get; set; }

        [JsonProperty("rewardValue")]
        public object rewardValue { get; set; }
    }

}

