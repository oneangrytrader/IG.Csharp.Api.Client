﻿using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class SlippageFactor
    {
        [JsonProperty("unit")]
        public string Unit;

        [JsonProperty("value")]
        public double Value;
    }
}
