using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectCoordinationIssue
    {
        public ProjectCoordinationIssue()
        {
            Viewpoints = new List<ProjectCoordinationIssueViewpoint>();
            Attachments = new List<ProjectCoordinationIssueAttachment>();
            LinkedProcoreItems = new List<ProjectCoordinationIssueLinkedProcoreItem> { };
            LinkedDrawings = new List<ProjectCoordinationIssueLinkedDrawing> { };
            LinkedObservationItems = new List<ProjectCoordinationIssueLinkedObservationItem> { };
        }
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("issue_number")]
        public int IssueNumber { get; set; }
        [JsonPropertyName("creation_source")]
        public string CreationSource { get; set; }
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }
        [JsonPropertyName("coordination_issue_file")]
        public ProjectCoordinationIssueFile CoordinationIssueFile { get; set; }
        [JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }
        [JsonPropertyName("bim_model_id")]
        public int? BimModelId { get; set; }
        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; set; }
        [JsonPropertyName("issue_type")]
        public string IssueType { get; set; }
        [JsonPropertyName("priority")]
        public string Priority { get; set; }
        [JsonPropertyName("drawing_revision")]
        public ProjectDrawingRevision DrawingRevision { get; set; }
        [JsonPropertyName("trade")]
        public CompanyTrade Trade { get; set; }
        [JsonPropertyName("location")]
        public ProjectLocation Location { get; set; }
        [JsonPropertyName("assignee")]
        public ProjectCoordinationIssueAssignee Assignee { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("created_by")]
        public ProjectCoordinationIssueCreatedBy CreatedBy { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("updated_by")]
        public ProjectCoordinationIssueUpdatedBy UpdatedBy { get; set; }
        [JsonPropertyName("viewpoints")]
        public List<ProjectCoordinationIssueViewpoint> Viewpoints { get; set; }
        [JsonPropertyName("attachments")]
        public List<ProjectCoordinationIssueAttachment> Attachments { get; set; }
        [JsonPropertyName("linked_procore_items")]
        public List<ProjectCoordinationIssueLinkedProcoreItem> LinkedProcoreItems { get; set; }
        [JsonPropertyName("linked_drawings")]
        public List<ProjectCoordinationIssueLinkedDrawing> LinkedDrawings { get; set; }
        [JsonPropertyName("linked_observation_items")]
        public List<ProjectCoordinationIssueLinkedObservationItem> LinkedObservationItems { get; set; }
    }
}
