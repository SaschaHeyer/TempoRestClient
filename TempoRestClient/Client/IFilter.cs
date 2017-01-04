using System.Collections.Generic;
using TempoRestClient.Interfaces;

namespace TempoRestClient.Client
{
    public interface IFilter
    {
        IFilter FilterUsername(string username);
        IFilter FilterProjectKey(string projectKey);
        IFilter FilterAccountKey(string accountKey);
        IFilter FilterTeamId(string teamId);
        IFilter FilterToDate(string dateTo);
        IFilter FilterFromDate(string dateFrom);
        IEnumerable<IWorklog> ExecuteWorklogRequest();
    }
}
