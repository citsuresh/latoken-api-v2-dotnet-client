using Newtonsoft.Json;
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

        [JsonProperty(PropertyName = "budget")]
        public string Budget { get; set; }

        [JsonProperty(PropertyName = "budgetSplit")]
        public string BudgetSplit { get; set; }

        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "winnersLimit")]
        public int WinnersLimit { get; set; }
    }
}
