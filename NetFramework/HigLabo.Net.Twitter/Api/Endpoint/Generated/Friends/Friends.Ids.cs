using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HigLabo.Net.Twitter.Api_1_1
{
    public partial class Friends
    {
        public partial class Ids
        {
            public class Command : TwitterCommand
            {
                public Int64? user_id { get; set; }
                public String screen_name { get; set; }
                public String cursor { get; set; }
                public Boolean? stringify_ids { get; set; }
                public Int64? count { get; set; }

                public override String GetApiEndpointUrl()
                {
                    return "https://api.twitter.com/1.1/friends/ids.json";
                }
                public override HttpMethodName GetHttpMethodName()
                {
                    return HttpMethodName.Get;
                }
            }
            public class Result
            {
                [JsonProperty("previous_cursor")]
                public Int64? previous_cursor { get; set; }
                [JsonProperty("ids")]
                public Int64?[] ids { get; set; }
                [JsonProperty("previous_cursor_str")]
                public String previous_cursor_str { get; set; }
                [JsonProperty("next_cursor")]
                public Int64? next_cursor { get; set; }
                [JsonProperty("next_cursor_str")]
                public String next_cursor_str { get; set; }
            }
        }
    }
}
