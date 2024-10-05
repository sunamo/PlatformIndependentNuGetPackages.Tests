using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RunnerCl;
internal class TestContainer(ILogger logger)
{
    internal void A()
    {
        logger.LogCritical("Critical!");
        logger.LogError("Error!");

        dynamic d = new ExpandoObject();
        d.To = "to";

        logger.LogInformation(JsonSerializer.Serialize(d as ExpandoObject));
    }
}
