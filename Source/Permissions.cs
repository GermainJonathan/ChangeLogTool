using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Source
{
    class Permissions
    {
        [JsonProperty("permissions")]
        public List<Permission> permissions { get; set; }
    }
}
