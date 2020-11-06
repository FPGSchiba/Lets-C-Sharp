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
        [JsonProperty("overview")]
        public Overview Overview { get; set; }

        [JsonProperty("connection")]
        public Connection Connection { get; set; }

        [JsonProperty("warning")]
        public Warning Warning { get; set; }

        [JsonProperty("mail")]
        public Mail Mail { get; set; }
    }

    public partial class Connection
    {
        [JsonProperty("tries")]
        public long Tries { get; set; }
    }

    public partial class Mail
    {
        [JsonProperty("sending")]
        public Sending Sending { get; set; }

        [JsonProperty("to-mail")]
        public string[] ToMail { get; set; }
    }

    public partial class Sending
    {
        [JsonProperty("server")]
        public Server Server { get; set; }

        [JsonProperty("sender-mail")]
        public string SenderMail { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("additional")]
        public string Additional { get; set; }
    }

    public partial class Server
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }
    }

    public partial class Overview
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("good")]
        public Good Good { get; set; }

        [JsonProperty("ok")]
        public Ok Ok { get; set; }

        [JsonProperty("less")]
        public Less Less { get; set; }

        [JsonProperty("bad")]
        public Bad Bad { get; set; }
    }

    public partial class Bad
    {
        [JsonProperty("badMin")]
        public long BadMin { get; set; }

        [JsonProperty("badMax")]
        public long BadMax { get; set; }
    }

    public partial class Good
    {
        [JsonProperty("goodMin")]
        public long GoodMin { get; set; }

        [JsonProperty("goodMax")]
        public long GoodMax { get; set; }
    }

    public partial class Less
    {
        [JsonProperty("lessMin")]
        public long LessMin { get; set; }

        [JsonProperty("lessMax")]
        public long LessMax { get; set; }
    }

    public partial class Ok
    {
        [JsonProperty("okMin")]
        public long OkMin { get; set; }

        [JsonProperty("okMax")]
        public long OkMax { get; set; }
    }

    public partial class Warning
    {
        [JsonProperty("CPUMax")]
        public long CpuMax { get; set; }

        [JsonProperty("GPUMax")]
        public long GpuMax { get; set; }

        [JsonProperty("MEMMax")]
        public long MemMax { get; set; }

        [JsonProperty("DPCMax")]
        public long DpcMax { get; set; }

        [JsonProperty("DFRMax")]
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
