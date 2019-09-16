using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_DI.Core.Repository
{
    public interface ITasksRepository
    {
        Task<int?> TotalTaskAsync();
        Task<int?> PendingTaskAsync();
        Task<int?> CompletedTaskAsync();
    }
}
