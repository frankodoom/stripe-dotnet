namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }

        [JsonProperty("percentage")]
        public todo-thingy Percentage { get; set; }
    }
}
