using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class Project
    {
        //Properties that are disabled for the Beck Procore company have been deleted.
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("accounting_project_number")]
        public string? AccountingProjectNumber { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("actual_start_date")]
        public DateTime ActualStartDate { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("company")]
        public Company Company { get; set; }
        [JsonPropertyName("completion_date")]
        public DateTime? CompletionDate { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("county")]
        public string County { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("designated_market_area")]
        public string? DesignatedMarketArea { get; set; }
        [JsonPropertyName("dictionary_type")]
        public string DictionaryType { get; set; }
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
        [JsonPropertyName("estimated_completion_date")]
        public DateTime? EstimatedCompletionDate { get; set; }
        [JsonPropertyName("estimated_start_date")]
        public DateTime? EstimatedStartDate { get; set; }
        [JsonPropertyName("estimated_value")]
        public string EstimatedValue { get; set; }
        [JsonPropertyName("flag")]
        public string Flag { get; set; }
        [JsonPropertyName("inbound_email")]
        public string InboundEmail { get; set; }
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }
        [JsonPropertyName("office")]
        public CompanyOffice Office { get; set; }
        [JsonPropertyName("origin_code")]
        public string? OriginCode { get; set; }
        [JsonPropertyName("origin_data")]
        public string? OriginData { get; set; }
        [JsonPropertyName("origin_id")]
        public string? OriginId { get; set; }
        [JsonPropertyName("owners_project_id")]
        public string? OwnersProjectId { get; set; } //Made a string in case owner project number has letters in it
        [JsonPropertyName("parent_job_id")]
        public int? ParentJobId { get; set; } //Made a string in case project number has letters in it. Eg: Life sciences
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("photo_id")]
        public int? PhotoId { get; set; }
        [JsonPropertyName("program")]
        public CompanyProgram Program { get; set; }
        [JsonPropertyName("project_number")]
        public string? Number { get; set; }
        [JsonPropertyName("project_stage")]
        public CompanyProjectStage Stage { get; set; }
        [JsonPropertyName("project_type")]
        public CompanyProjectType ProjectType { get; set; }
        [JsonPropertyName("projected_finish_date")]
        public DateTime? ProjectedFinishDate { get; set; }
        [JsonPropertyName("public_notes")]
        public string? PublicNotes { get; set; }
        [JsonPropertyName("square_feet")]
        public int? SquareFeet { get; set; }
        //Standard Cost Code was throwing errors so turned off
        //[JsonPropertyName("standard_cost_code_list_id")]
        //public int StandardCostCodeListId { get; set; }
        [JsonPropertyName("start_date")]
        public DateTime? StartDate { get; set; }
        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }
        [JsonPropertyName("store_number")]
        public string? StoreNumber { get; set; }
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }
        //Total Value was throwing errors so turned off
        //[JsonPropertyName("total_value")]
        //public float TotalValue { get; set; }
        [JsonPropertyName("tz_name")]
        public string TzName { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("warranty_end_date")]
        public DateTime? WarrantyEndDate { get; set; }
        [JsonPropertyName("warranty_start_date")]
        public DateTime? WarrantyStartDate { get; set; }
        [JsonPropertyName("zip")]
        public string Zip { get; set; }







    }
}
