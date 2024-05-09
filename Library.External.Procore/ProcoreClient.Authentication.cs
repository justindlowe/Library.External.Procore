using Library.External.Procore.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.External.Procore
{
    public partial class ProcoreClient
    {
        public async Task<AuthToken> GetAuthToken()
        {
            var request = new RestRequest("oauth/token")
            {
                Method = Method.Post
            };

            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", ClientId);
            request.AddParameter("client_secret", ClientSecret);

            return await SendProcoreSingleRequestAsync<AuthToken>(request, true);
        }
    }
}
