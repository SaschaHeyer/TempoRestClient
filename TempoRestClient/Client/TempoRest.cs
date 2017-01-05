using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using TempoRestClient.Globals;
using TempoRestClient.Interfaces;
using TempoRestClient.Models;

namespace TempoRestClient.Client
{
    public class TempoRest : ITempoRest, IFilter, IExecute
    {
        private readonly RestClient _restClient;
        private readonly IRestRequest _restRequest;

        private TempoRest(ITempoAccount tempoAccountAccount)
        {
            _restClient = new RestClient(new Uri(new Uri(tempoAccountAccount.ServerUrl), "/rest/tempo-timesheets/3/"))
            {
                Authenticator = new HttpBasicAuthenticator(tempoAccountAccount.User, tempoAccountAccount.Password)
            };

            _restRequest = new RestRequest(
                Paths.Worklogs,
                Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
        }

        public static IFilter Configure(ITempoAccount account)
        {
            return new TempoRest(account);
        }

        public static IFilter Configure(string serverUrl, string user, string password)
        {
            ITempoAccount account = new TempoAccount
            {
                ServerUrl = serverUrl,
                User = user,
                Password = password
            };

            return new TempoRest(account);
        }

        public IEnumerable<IWorklog> ExecuteWorklogRequest()
        {
            IRestResponse response = this._restClient.Execute(this._restRequest);
            JsonDeserializer deserial = new JsonDeserializer();

            return deserial.Deserialize<List<Worklog>>(response);
        }

        public IFilter FilterUsername(string username)
        {
            this._restRequest.AddParameter(Parameters.Username, username);
            return this;
        }

        public IFilter FilterTeamId(string teamId)
        {
            this._restRequest.AddParameter(Parameters.TeamId, teamId);
            return this;
        }

        public IFilter FilterToDate(string dateTo)
        {
            this._restRequest.AddParameter(Parameters.DateTo, dateTo);
            return this;
        }

        public IFilter FilterFromDate(string dateFrom)
        {
            this._restRequest.AddParameter(Parameters.DateFrom, dateFrom);
            return this;
        }

        public IFilter FilterProjectKey(string projectKey)
        {
            this._restRequest.AddParameter(Parameters.ProjectKey, projectKey);
            return this;
        }

        public IFilter FilterAccountKey(string accountKey)
        {
            this._restRequest.AddParameter(Parameters.AccountKey, accountKey);
            return this;
        }
    }
}
