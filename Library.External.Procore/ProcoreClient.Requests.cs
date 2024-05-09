using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.External.Procore
{
    public partial class ProcoreClient
    {
        //Made two seperate calls since the return types were different
        public async Task<T> SendProcoreSingleRequestAsync<T>(RestRequest request, bool isAuthenticationRequest = false, double restVersion = 1.0) where T : new()
        {
            RestClientOptions options = isAuthenticationRequest ? new RestClientOptions(AuthenticationUrl) : new RestClientOptions(BaseUrl);
            var client = new RestClient(options);

            var response = await client.ExecuteAsync<T>(request, CancellationToken.None);
            if (response.ErrorException != null)
            {
                Console.WriteLine(response.Content);
                throw response.ErrorException;
            }

            return response.Data;
        }

        public async Task<List<T>> SendProcoreRequestAsync<T>(RestRequest initialRequest, bool isAuthenticationRequest = false, double restVersion = 1.0) where T : new()
        {
            RestClientOptions options = isAuthenticationRequest ? new RestClientOptions(AuthenticationUrl) : new RestClientOptions(BaseUrl);
            options.MaxTimeout = 600000;
            var client = new RestClient(options);
            List<T> allData = new List<T>();
            RestRequest request = initialRequest;

            do
            {
                var response = await client.ExecuteAsync<List<T>>(request, CancellationToken.None);
                if (response.ErrorException != null)
                {
                    Console.WriteLine(response.Content);
                    throw response.ErrorException;
                }

                allData.AddRange(response.Data);

                // Reset the request for the next URL, if any, and include headers
                request = null;
                if (response.Headers != null)
                {
                    var paginationLink = response.Headers.ToList().Find(p => p.Name == "Link");
                    if (paginationLink != null)
                    {
                        var regex = new Regex("<(https?://[^>]+)>; rel=\"next\"");
                        var match = regex.Match(paginationLink.Value.ToString());
                        if (match.Success)
                        {
                            string urlForNextCall = match.Groups[1].Value;
                            request = new RestRequest(urlForNextCall) { Method = initialRequest.Method };
                            // Copy headers from the initial request
                            foreach (var header in initialRequest.Parameters.Where(p => p.Type == ParameterType.HttpHeader))
                            {
                                request.AddParameter(header.Name, header.Value, ParameterType.HttpHeader);
                            }
                        }
                    }
                }
            } while (request != null);

            return allData;
        }
    }
}
