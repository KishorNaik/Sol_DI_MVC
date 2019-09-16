using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_DI.Models
{
    public class StatsModel
    {
        public int? TotalTask { get; set; }

        public int? CompleteTask { get; set; }

        public int? PendingTask { get; set; }
    }
}
