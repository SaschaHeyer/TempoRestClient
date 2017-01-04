using TempoRestClient.Models;

namespace TempoRestClient.Interfaces
{
    public interface IApproval
    {
        User User { get; set; }
        string Status { get; set; }
        int WorkedSeconds { get; set; }
        int SubmittedSeconds { get; set; }
        int RequiredSeconds { get; set; }
        int RequiredSecondsRelativeToday { get; set; }
        string SmartDateString { get; set; }
        Worklog Worklogs { get; set; }
    }
}
