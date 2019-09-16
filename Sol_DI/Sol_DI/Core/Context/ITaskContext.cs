using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_DI.Core.Context
{
    public interface ITaskContext
    {
        Task<int?> TotalTaskAsync();
        Task<int?> PendingTaskAsync();
        Task<int?> CompletedTaskAsync();
    }
}
