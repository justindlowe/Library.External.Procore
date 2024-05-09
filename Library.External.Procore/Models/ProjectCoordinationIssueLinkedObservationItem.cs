using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectCoordinationIssueLinkedObservationItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("personal")]
        public bool? Personal { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("created_by_id")]
        public long CreatedById { get; set; }
    }
}
