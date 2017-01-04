using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all accound related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.ITempoAccount" />
    public class TempoAccount :ITempoAccount
    {
        public string ServerUrl { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
