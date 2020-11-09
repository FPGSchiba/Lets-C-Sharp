using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonitorIT
{
    public partial class Settings
    {
        [JsonProperty("Overview")]
        public Overview Overview { get; set; }

        [JsonProperty("Connection")]
        public Connection Connection { get; set; }

        [JsonProperty("Warning")]
        public Warning Warning { get; set; }

        [JsonProperty("Mail")]
        public Mail Mail { get; set; }
    }

    public partial class Connection
    {
        [JsonProperty("Tries")]
        public long Tries { get; set; }
    }

    public partial class Mail
    {
        [JsonProperty("Sending")]
        public Sending Sending { get; set; }

        [JsonProperty("ToMail")]
        public List<string> ToMail { get; set; }
    }

    public partial class Sending
    {
        [JsonProperty("Server")]
        public Server Server { get; set; }

        [JsonProperty("SenderMail")]
        public string SenderMail { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Subject")]
        public string Subject { get; set; }

        [JsonProperty("Additional")]
        public string Additional { get; set; }
    }

    public partial class Server
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Port")]
        public long Port { get; set; }
    }

    public partial class Overview
    {
        [JsonProperty("Status")]
        public Status Status { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("Good")]
        public Good Good { get; set; }

        [JsonProperty("Ok")]
        public Ok Ok { get; set; }

        [JsonProperty("Less")]
        public Less Less { get; set; }

        [JsonProperty("Bad")]
        public Bad Bad { get; set; }
    }

    public partial class Bad
    {
        [JsonProperty("BadMin")]
        public long BadMin { get; set; }

        [JsonProperty("BadMax")]
        public long BadMax { get; set; }
    }

    public partial class Good
    {
        [JsonProperty("GoodMin")]
        public long GoodMin { get; set; }

        [JsonProperty("GoodMax")]
        public long GoodMax { get; set; }
    }

    public partial class Less
    {
        [JsonProperty("LessMin")]
        public long LessMin { get; set; }

        [JsonProperty("LessMax")]
        public long LessMax { get; set; }
    }

    public partial class Ok
    {
        [JsonProperty("OkMin")]
        public long OkMin { get; set; }

        [JsonProperty("OkMax")]
        public long OkMax { get; set; }
    }

    public partial class Warning
    {
        [JsonProperty("CpuMax")]
        public long CpuMax { get; set; }

        [JsonProperty("GpuMax")]
        public long GpuMax { get; set; }

        [JsonProperty("MemMax")]
        public long MemMax { get; set; }

        [JsonProperty("DpcMax")]
        public long DpcMax { get; set; }

        [JsonProperty("DfrMax")]
        public long DfrMax { get; set; }
    }

    public partial class Settings
    {
        public static Settings FromJson(string json) => JsonConvert.DeserializeObject<Settings>(json, MonitorIT.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Settings self) => JsonConvert.SerializeObject(self, MonitorIT.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
