using Newtonsoft.Json;
using System.Collections.Generic;
namespace Latoken.Api.Client.Library
{
    public class Transfers
    {
        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty(PropertyName = "content")]
        public List<Transfer> Content { get; set; }

        [JsonProperty(PropertyName = "first")]
        public bool First { get; set; }

        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        [JsonProperty(PropertyName = "hasContent")]
        public bool HasContent { get; set; }
    }
}


