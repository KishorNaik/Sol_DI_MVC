using Sol_DI.Core.Context;
using Sol_DI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_DI.Context
{
    public class TaskContext : ITaskContext
    {

        private readonly ITasksRepository tasksRepository = null;

        public TaskContext(ITasksRepository tasksRepository)
        {
            this.tasksRepository = tasksRepository;
        }

        async Task<int?> ITaskContext.CompletedTaskAsync()
        {
            try
            {
                return await this.tasksRepository.CompletedTaskAsync();
            }
            catch
            {
                throw;
            }
        }

        async Task<int?> ITaskContext.PendingTaskAsync()
        {
            try
            {
                return await this.tasksRepository.PendingTaskAsync();
            }
            catch
            {
                throw;
            }
        }

        async Task<int?> ITaskContext.TotalTaskAsync()
        {
            try
            {
                return await this.tasksRepository.TotalTaskAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
