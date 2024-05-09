using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectCoordinationIssueLinkedProcoreItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("coordination_issue_id")]
        public int CoordinationIssueId { get; set; }
        [JsonPropertyName("item_id")]
        public int ItemId { get; set; }
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }
        [JsonPropertyName("item_url")]
        public string ItemUrl { get; set; }
        [JsonPropertyName("item_data")]
        public ProjectCoordinationIssueLinkedProcoreItemData ItemData { get; set; }
    }
}
