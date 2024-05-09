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
        public async Task<List<Project>> GetProjects(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.1/projects";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);
            request.AddParameter("view", "extended");

            List<Project> allProjects = await SendProcoreRequestAsync<Project>(request);
            return allProjects;
        }

        public async Task<List<Company>> GetCompanies(AuthToken authToken)
        {
            var resroucePath = "rest/v1.0/companies";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));

            List<Company> allCompanies = await SendProcoreRequestAsync<Company>(request);

            return allCompanies;
        }

        public async Task<List<CompanyOffice>> GetOffices(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/offices";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyOffice> allOffices = await SendProcoreRequestAsync<CompanyOffice>(request);

            return allOffices;
        }

        public async Task<List<CompanyProgram>> GetPrograms(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/companies/6714/programs";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyProgram> allPrograms = await SendProcoreRequestAsync<CompanyProgram>(request);

            return allPrograms;
        }

        public async Task<List<CompanyProjectStage>> GetProjectStages(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/companies/6714/project_stages";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyProjectStage> allProjectStages = await SendProcoreRequestAsync<CompanyProjectStage>(request);

            return allProjectStages;
        }

        public async Task<List<CompanyProjectType>> GetProjectTypes(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/companies/6714/project_types";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyProjectType> allProjectTypes = await SendProcoreRequestAsync<CompanyProjectType>(request);

            return allProjectTypes;
        }

        public async Task<List<CompanyPeople>> GetCompanyPeople(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/companies/6714/people";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyPeople> allCompanyPeople = await SendProcoreRequestAsync<CompanyPeople>(request);

            return allCompanyPeople;
        }

        public async Task<List<CompanyUser>> GetCompanyUsers(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.3/companies/6714/users";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyUser> allCompanyUsers = await SendProcoreRequestAsync<CompanyUser>(request);

            return allCompanyUsers;
        }

        public async Task<List<CompanyVendor>> GetCompanyVendors(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/vendors";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyVendor> allCompanyVendors = await SendProcoreRequestAsync<CompanyVendor>(request);

            return allCompanyVendors;
        }

        public async Task<List<CompanyTrade>> GetCompanyTrades(AuthToken authToken)
        {
            var resroucePath = "/rest/v1.0/companies/6714/trades";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("company_id", 6714);

            List<CompanyTrade> allCompanyTrades = await SendProcoreRequestAsync<CompanyTrade>(request);

            return allCompanyTrades;
        }
    }
}


