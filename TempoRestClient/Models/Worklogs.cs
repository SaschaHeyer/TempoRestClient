using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all worklog related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IWorklog" />
    public class Worklog :IWorklog
    {
        public int TimeSpentSeconds { get; set; }
        public int BilledSeconds { get; set; }
        public string Comment { get; set; }
        public string Id { get; set; }
        public Author Author { get; set; }
        public Issue Issue { get; set; }
    }
}
