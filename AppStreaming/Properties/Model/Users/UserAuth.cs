using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppStreaming.Properties.Model.Users
{
    public class UserAuth
    {
        public required string Username { get; set; }

        [JsonPropertyName("password")]
        public required string Password { get; set; }

        [JsonPropertyName("expiresInMins")]
        public int ExpiresInMins { get; set; }
    }
}
