namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsDashboardOptions : INestedOptions
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}