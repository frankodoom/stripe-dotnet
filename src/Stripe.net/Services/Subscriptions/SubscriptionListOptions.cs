namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("current_period_end")]
        public todo-thingy CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        public todo-thingy CurrentPeriodStart { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
