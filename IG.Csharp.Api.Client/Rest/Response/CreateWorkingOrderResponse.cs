﻿using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class CreateWorkingOrderResponse
    {
        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }
}