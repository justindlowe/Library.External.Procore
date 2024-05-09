using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectRfiScheduleImpact
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }
}
