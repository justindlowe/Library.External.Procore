using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class CompanyUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("business_id")]
        public string BusinessId { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }
        [JsonPropertyName("erp_integrated_accountant")]
        public bool? ErpIntegratedAccount { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }
        [JsonPropertyName("is_employee")]
        public bool? IsEmployee { get; set; }
        [JsonPropertyName("job_title")]
        public string JobTitle { get; set; }
        [JsonPropertyName("last_login_at")]
        public DateTime? LastLoginAt { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("mobile_phone")]
        public string MobileNumber { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("vendor")]
        public CompanyVendor CompanyVendor { get; set; }
    }
}
