using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class CompanyPeople
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("is_employee")]
        public bool? IsEmployee { get; set; }
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }
        [JsonPropertyName("user_uuid")]
        public string UserUuid { get; set; }
    }
}
