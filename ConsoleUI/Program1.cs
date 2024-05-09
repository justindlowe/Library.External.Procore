using Library.External.Procore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.External.Procore;
using Library.External.Procore.Models;

namespace ConsoleUI
{
    public class Program1
    {
        static void Main(string[] args)
        {
            MainASync().Wait();
        }

        static async Task MainASync()
        {
            //Scratch space
            //Storing Id and Secret temporarily as system environmental variable. Need to change this since seems to require admin rights.
            string clientId = Environment.GetEnvironmentVariable("CoreAPI-ProcoreClientId");
            string clientSecret = Environment.GetEnvironmentVariable("CoreAPI-ProcoreClientSecret");
            ProcoreClient procoreInstance = new ProcoreClient(clientId, clientSecret);
            AuthToken authToken = await procoreInstance.GetAuthToken();
            Console.WriteLine(authToken.AccessToken);
            //List<Project> projects = await procoreInstance.GetProjects(authToken);
            //List<CompanyUser> companyUsers = await procoreInstance.GetCompanyUsers(authToken);
            //List<ProjectType> projectTypes = await procoreInstance.GetProjectTypes(authToken);
            //List<ProjectStage> projectStages = await procoreInstance.GetProjectStages(authToken);
            //List<Program> programs = await procoreInstance.GetPrograms(authToken);
            //List<CompanyOffice> offices = await procoreInstance.GetOffices(authToken);
            //List<Company> companies = await procoreInstance.GetCompanies(authToken);
            List<Project> projects = await procoreInstance.GetProjects(authToken);
            //List<CompanyPeople> companyPeople = await procoreInstance.GetCompanyPeople(authToken);
            //List<CompanyVendor> companyVendors = await procoreInstance.GetCompanyVendors(authToken);
            //List<Trade> companyVendors = await procoreInstance.GetCompanyTrades(authToken);
            //List<ProjectDailyLogCount> projectDailyLogsCounts = await procoreInstance.GetProjectDailyLogsCount(authToken, "1797062", "2024-04-01");
            //List<ProjectCoordinationIssue> projectCoordinationIssues = await procoreInstance.GetProjectCoordinationIssues(authToken, "1352088");
            //List<ProjectRfi> projectRfis = await procoreInstance.GetProjectRfis(authToken, "1352088");
            //var singleProjectRfi = await procoreInstance.GetProjectRfi(authToken, "1352088", "19005015");
            //var singleProjectCoordinationIssue = await procoreInstance.GetProjectCoordinationIssue(authToken, "1352088", "494732");

            Console.ReadLine();
        }
    }
}


//Last Notes
//Go change all the id types to long as some of them are like 0000000000000
//Leaving for now, but come back and add Specifications, Submittals.
