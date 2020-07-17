using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Organiser.Extensions.Auto_Paste_Details_Plugin
{
    public class SerialisedConnectionDetails
    {
        [JsonProperty("Host")]
        public string Host { get; set; }
        [JsonProperty("Port")]
        public string Port { get; set; }
        [JsonProperty("Username")]
        public string Username { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
