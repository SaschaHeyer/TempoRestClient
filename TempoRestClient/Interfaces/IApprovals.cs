using System.Collections.Generic;
using TempoRestClient.Models;

namespace TempoRestClient.Interfaces
{
    public interface IApprovals
    {
        Period Period { get; set; }
        IEnumerable<Approval> Approvals { get; set; }
    }
}
