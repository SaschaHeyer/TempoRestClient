using TempoRestClient.Interfaces;

namespace TempoRestClient.Models
{
    /// <summary>
    /// Contains all User related informations
    /// </summary>
    /// <seealso cref="TempoRestClient.Interfaces.IAuthor" />
    public class User : IAuthor
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Avatar { get; set; }
    }
}
