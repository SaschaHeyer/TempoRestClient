using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all Issue related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IIssue" />
    public class Issue : IIssue
    {
        public IssueType IssueType { get; set; }
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Key { get; set; }
        public string Summary { get; set; }
    }
}
