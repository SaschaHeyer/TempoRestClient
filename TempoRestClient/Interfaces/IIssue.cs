using TempoRestClient.Models;

namespace TempoRestClient.Interfaces
{
    public interface IIssue
    {
        IssueType IssueType { get; set; }
        int Id { get; set; }
        int ProjectId { get; set; }
        string Key { get; set; }
        string Summary { get; set; }
    }
}
