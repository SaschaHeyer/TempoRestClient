namespace TempoRestClient.Interfaces
{
    public interface IPeriod
    {
        string PeriodView { get; set; }
        string PeriodId { get; set; }
        string DateFrom { get; set; }
        string DateTo { get; set; }
    }
}
