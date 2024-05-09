using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectDailyLog
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("apprentice_hours")]
        public string ApprenticeHours { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("datetime")]
        public string DateTime { get; set; }
        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; set; }
        [JsonPropertyName("first_year_hours")]
        public string FirstYearHours { get; set; }
        [JsonPropertyName("foreman_hours")]
        public string ForemanHours { get; set; }
        [JsonPropertyName("journeyman_hours")]
        public string JourneymanHours { get; set; }
        [JsonPropertyName("local_city_hours")]
        public string LocalCityHours { get; set; }
        [JsonPropertyName("local_county_hours")]
        public string LocalCountyHours { get; set; }
        [JsonPropertyName("minority_hours")]
        public string MinorityHours { get; set; }
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
        [JsonPropertyName("number_of_apprentice_workers")]
        public int? NumberOfApprenticeWorkers { get; set; }
        [JsonPropertyName("number_of_foreman_workers")]
        public int? NumberOfForemanWorkers { get; set; }
        [JsonPropertyName("number_of_journeyman_workers")]
        public int? NumberOfJourneymanWorkers { get; set; }
        [JsonPropertyName("number_of_other_workers")]
        public int? NumberOfOtherWorkers { get; set; }
        [JsonPropertyName("other_hours")]
        public string OtherHours { get; set; }
        [JsonPropertyName("position")]
        public int? Position { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
        [JsonPropertyName("veteran_hours")]
        public string VeteranHours { get; set; }
        [JsonPropertyName("women_hours")]
        public string WomenHours { get; set; }



    }
}
