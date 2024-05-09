using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class CompanyVendor
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("authorized_bidder")]
        public bool? AuthorizedBidder { get; set; }
        [JsonPropertyName("business_phone")]
        public string BusinessPhone { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }
        [JsonPropertyName("is_connected")]
        public bool? IsConnected { get; set; }
        [JsonPropertyName("labor_union")]
        public string LaborUnion { get; set; }
        [JsonPropertyName("license_number")]
        public string LicenseNumber { get; set; }
        [JsonPropertyName("prequalified")]
        public bool? Prequalified { get; set; }
        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }
        [JsonPropertyName("synced_to_erp")]
        public bool? SyncedToErp { get; set; }
        [JsonPropertyName("trade_name")]
        public string TradeName { get; set; }
        [JsonPropertyName("union_member")]
        public bool? UnionMember { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
        [JsonPropertyName("business_id")]
        public string BusinessId { get; set; }







    }
}
