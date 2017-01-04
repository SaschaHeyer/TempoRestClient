using TempoRestClient.Models;

namespace TempoRestClient.Interfaces
{
    public interface IWorklog
    {
        int TimeSpentSeconds { get; set; }
        int BilledSeconds { get; set; }
        string Comment { get; set; }
        string Id { get; set; }
        Author Author { get; set; }
        Issue Issue { get; set; }
    }
}
