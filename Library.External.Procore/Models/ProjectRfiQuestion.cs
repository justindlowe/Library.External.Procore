using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectRfiQuestion
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
