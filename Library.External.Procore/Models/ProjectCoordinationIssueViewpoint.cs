using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectCoordinationIssueViewpoint
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("bim_file_id")]
        public int? BimFileId { get; set; }
        [JsonPropertyName("view_folder_id")]
        public int? ViewFolderId { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("snapshot")]
        public ProjectCoordinationIssueViewpointSnapshot? Snapshot { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("render_mode")]
        public string RenderMode { get; set; }
        [JsonPropertyName("camera_data")]
        public string CameraData { get; set; }
        [JsonPropertyName("redlines_data")]
        public string RedlinesData { get; set; }
        [JsonPropertyName("sections_data")]
        public string SectionsData { get; set; }
    }
}
