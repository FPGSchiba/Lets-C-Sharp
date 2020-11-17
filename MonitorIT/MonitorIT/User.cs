using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorIT
{
    public class Rights
    {
        [JsonProperty("rightManage")]
        public int rightManage { get; set; }
        [JsonProperty("rightUser")]
        public int rightUser { get; set; }
        [JsonProperty("rightWarning")]
        public int rightWarning { get; set; }
        [JsonProperty("rightDashboard")]
        public int rightDashboard { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public Rights rights { get; set; }
    }
}
