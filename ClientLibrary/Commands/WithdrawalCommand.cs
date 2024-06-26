﻿using Newtonsoft.Json;

namespace Latoken.Api.Client.Library.Commands
{
    public class WithdrawalCommand
    {
        [JsonProperty(PropertyName = "currencyBinding")]
        public string CurrencyBinding { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "recipientAddress")]
        public string RecipientAddress { get; set; }

        [JsonProperty(PropertyName = "memo")]
        public string Memo { get; set; }

    }
}
