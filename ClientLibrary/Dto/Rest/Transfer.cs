using Newtonsoft.Json;
namespace Latoken.Api.Client.Library
{
    public class Transfer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "fromAccount")]
        public string FromAccount { get; set; }

        [JsonProperty(PropertyName = "toAccount")]
        public string ToAccount { get; set; }

        [JsonProperty(PropertyName = "transferringFunds")]
        public decimal TransferringFunds { get; set; }

        [JsonProperty(PropertyName = "usdValue")]
        public decimal UsdValue { get; set; }

        [JsonProperty(PropertyName = "rejectReason")]
        public string RejectReason { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public string Recipient { get; set; }

        [JsonProperty(PropertyName = "sender")]
        public string Sender { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "codeRequired")]
        public bool CodeRequired { get; set; }

        [JsonProperty(PropertyName = "fromUser")]
        public string FromUser { get; set; }

        [JsonProperty(PropertyName = "toUser")]
        public string ToUser { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public decimal Fee { get; set; }
    }
}
