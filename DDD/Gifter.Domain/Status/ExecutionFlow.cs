using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.Status
{
    public static class ExecutionFlow
    {
        public static IExecutionOptions Options { get; set; }

        static ExecutionFlow()
        {
            Options = new ExecutionOptions();
        }
    }
}
