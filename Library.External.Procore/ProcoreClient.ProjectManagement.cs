using Library.External.Procore.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.External.Procore
{
    partial class ProcoreClient
    {
        public async Task<List<ProjectDailyLogCount>> GetProjectDailyLogsCount(AuthToken authToken, string ProcoreProjectId, string LogDate)
        {
            var resroucePath = string.Format("/rest/v1.1/projects/{0}/daily_logs/counts", ProcoreProjectId);
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("log_date", LogDate);

            List<ProjectDailyLogCount> allProjectDailyLogsCount = await SendProcoreRequestAsync<ProjectDailyLogCount>(request);

            return allProjectDailyLogsCount;
        }

        public async Task<List<ProjectCoordinationIssue>> GetProjectCoordinationIssues(AuthToken authToken, string ProcoreProjectId)
        {
            var resroucePath = "/rest/v1.0/coordination_issues";
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("project_id", ProcoreProjectId);
            request.AddParameter("sort", "issue_number");
            request.AddParameter("view", "extended");
            request.AddParameter("viewpoint_format", "default");

            List<ProjectCoordinationIssue> allProjectCoordinationIssues = await SendProcoreRequestAsync<ProjectCoordinationIssue>(request);

            return allProjectCoordinationIssues;
        }

        public async Task<ProjectCoordinationIssue> GetProjectCoordinationIssue(AuthToken authToken, string ProcoreProjectId, string ProcoreCoordinationIssueId)
        {
            var resroucePath = string.Format("/rest/v1.0/coordination_issues/{0}", ProcoreCoordinationIssueId);
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));
            request.AddParameter("project_id", ProcoreProjectId);
            request.AddParameter("view", "extended");
            request.AddParameter("viewpoint_format", "default");

            var singleProjectCoordinationIssue = await SendProcoreSingleRequestAsync<ProjectCoordinationIssue>(request);

            return singleProjectCoordinationIssue;
        }

        public async Task<List<ProjectRfi>> GetProjectRfis(AuthToken authToken, string ProcoreProjectId)
        {
            var resroucePath = string.Format("/rest/v1.0/projects/{0}/rfis", ProcoreProjectId);
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));

            List<ProjectRfi> allProjectRfis = await SendProcoreRequestAsync<ProjectRfi>(request);

            return allProjectRfis;
        }

        public async Task<ProjectRfi> GetProjectRfi(AuthToken authToken, string ProcoreProjectId, string ProcoreRfiId)
        {
            var resroucePath = string.Format("/rest/v1.0/projects/{0}/rfis/{1}", ProcoreProjectId, ProcoreRfiId);
            var request = new RestRequest(resroucePath)
            {
                Method = Method.Get
            };

            request.AddHeader("Authorization", string.Format("Bearer {0}", authToken.AccessToken));
            request.AddHeader("Procore-Company-Id", string.Format("6714"));

            var singleRfi = await SendProcoreSingleRequestAsync<ProjectRfi>(request);

            return singleRfi;
        }
    }
}
