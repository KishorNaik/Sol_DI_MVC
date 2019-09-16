using Sol_DI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_DI.Repository
{
    public class TasksRepository : ITasksRepository
    {
        async Task<int?> ITasksRepository.CompletedTaskAsync()
        {
            try
            {
                return await Task.Run(() => {

                    return 10;
                });
            }
            catch
            {
                throw;
            }
        }

        async Task<int?> ITasksRepository.PendingTaskAsync()
        {
            try
            {
                return await Task.Run(() => {

                    return 10;

                });
            }
            catch {
                throw;
            }
        }

        async Task<int?> ITasksRepository.TotalTaskAsync()
        {
           try
            {
                return await Task.Run(() => {

                    return 20;

                });
            }
            catch
            {
                throw;
            }
        }
    }
}
