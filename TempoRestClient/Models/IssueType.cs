using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all Issue Type related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IIssueType" />
    public class IssueType : IIssueType
    {
        public string Name { get; set; }
        public string IconUrl { get; set; }

    }
}
