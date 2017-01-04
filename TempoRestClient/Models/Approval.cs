using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all Approval related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IApproval" />
    public class Approval : IApproval
    {
        public User User { get; set; }
        public string Status { get; set; }
        public int WorkedSeconds { get; set; }
        public int SubmittedSeconds { get; set; }
        public int RequiredSeconds { get; set; }
        public int RequiredSecondsRelativeToday { get; set; }
        public string SmartDateString { get; set; }
        public Worklog Worklogs { get; set; }
    }
}
