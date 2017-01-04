using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all Period related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IPeriod" />
    public class Period : IPeriod
    {
        public string PeriodView { get; set; }
        public string PeriodId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
