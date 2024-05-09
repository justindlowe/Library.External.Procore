using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.External.Procore.Models
{
    public class ProjectRfi
    {
        public ProjectRfi()
        {
            Questions = new List<ProjectRfiQuestion>();
            Assignees = new List<CompanyAssignee>();
            BallInCourts = new List<CompanyBallInCourt>();
        }
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
        [JsonPropertyName("location_id")]
        public int? LocationId { get; set; }
        [JsonPropertyName("questions")]
        public List<ProjectRfiQuestion> Questions { get; set; }
        [JsonPropertyName("assignee")]
        public CompanyAssignee? Assignee { get; set; }
        [JsonPropertyName("assignees")]
        public List<CompanyAssignee> Assignees { get; set; }
        [JsonPropertyName("ball_in_courts")]
        public List<CompanyBallInCourt> BallInCourts { get; set; }
        [JsonPropertyName("cost_code")]
        public CompanyCostCode? CostCode { get; set; }
        [JsonPropertyName("cost_impact")]
        public CompanyCostImpact? CostImpact { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }
        [JsonPropertyName("deleted_at")]
        public DateTime? DeletedAt { get; set; }
        [JsonPropertyName("due_date")]
        public DateTime? DueDate { get; set; }
        [JsonPropertyName("initiated_at")]
        public DateTime? InitiatedAt { get; set; }
        [JsonPropertyName("location")]
        public ProjectLocation? Location { get; set; }
        [JsonPropertyName("full_number")]
        public string FullNumber { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }
        [JsonPropertyName("private")]
        public bool? Private { get; set; }
        [JsonPropertyName("project_stage")]
        public CompanyProjectStage? ProjectStage { get; set; }
        [JsonPropertyName("responsible_contractor")]
        public ProjectRfiResponsibleContractor? ResponsibleContractor { get; set; }
        [JsonPropertyName("rfi_manager")]
        public ProjectRfiRfiManager? RfiManager { get; set; }
        [JsonPropertyName("schedule_impact")]
        public ProjectRfiScheduleImpact? ScheduleImpact { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("translated_status")]
        public string TranslatedStatus { get; set; }
        [JsonPropertyName("sub_job")]
        public ProjectRfiSubJob? SubJob { get; set; }
        [JsonPropertyName("time_resolved")]
        public DateTime? TimeResolved { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("accepted")]
        public bool? Accepted { get; set; }
        [JsonPropertyName("ball_in_court_role")]
        public string BallInCourtRole { get; set; }
    }
}
