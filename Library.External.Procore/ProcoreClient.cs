using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.External.Procore.Models;
using System.Text.RegularExpressions;

namespace Library.External.Procore
{
    public partial class ProcoreClient
    {
        string BaseUrl = "https://api.procore.com/";
        string AuthenticationUrl = "https://login.procore.com/";
        private string ClientId { get; set; }
        private string ClientSecret { get; set; }
        public DateTime? NextRequestLimitUpdate { get; set; }
        public int? RemainingRequests { get; set; }

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public ProcoreClient(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}


