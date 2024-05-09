using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectCoordinationIssueLinkedProcoreItemData
    {
        [JsonPropertyName("has_official_response")]
        public bool? HasOfficialResponse { get; set; }
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
