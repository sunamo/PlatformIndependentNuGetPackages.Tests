using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerLogging;
internal class LoggerOuter(LoggerInner loggerInner)
{
    public void Log()
    {
        loggerInner.Log();
    }
}
