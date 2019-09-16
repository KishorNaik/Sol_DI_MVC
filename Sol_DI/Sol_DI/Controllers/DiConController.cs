using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_DI.Core.Context;
using Sol_DI.Models;

namespace Sol_DI.Controllers
{
    public class DiConController : Controller
    {
        private readonly ITaskContext taskContext = null;

        public DiConController(ITaskContext taskContext)
        {
            this.taskContext = taskContext;

            Stats = new StatsModel();
        }


        [BindProperty]
        public StatsModel Stats { get; set; }


        public async Task<IActionResult> Index()
        {
            Stats.TotalTask = await taskContext.TotalTaskAsync();
            Stats.CompleteTask = await taskContext.CompletedTaskAsync();
            Stats.PendingTask = await taskContext.PendingTaskAsync();

            return View(Stats);
        }
    }
}