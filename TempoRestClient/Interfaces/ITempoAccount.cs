namespace TempoRestClient.Interfaces
{
    public interface ITempoAccount
    {
        string ServerUrl { get; set; }

        string User { get; set; }
        string Password { get; set; }
    }
}
