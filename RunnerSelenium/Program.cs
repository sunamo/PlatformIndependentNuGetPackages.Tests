using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using SunamoCl.SunamoCmd;
using SunamoSelenium;
using SunamoSelenium.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerSelenium;
partial class Program
{

    const string appName = "ToNugets.Cmd.Roslyn";

    static ServiceCollection Services = new();
    static ServiceProvider Provider;
    static ILogger logger;

    static Program()
    {
        CmdBootStrap.AddILogger(Services, true, null, appName);

        Provider = Services.BuildServiceProvider();
        logger = Provider.GetService<ILogger>() ?? throw new ServiceNotFoundException(nameof(ILogger));
    }

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        var runnedAction = await CmdBootStrap.RunWithRunArgs(new SunamoCl.SunamoCmd.Args.RunArgs
        {
            AddGroupOfActions = AddGroupOfActions,
            AskUserIfRelease = true,
            Args = args,
            RunInDebugAsync = RunInDebugAsync,
            ServiceCollection = Services,
            IsDebug =
#if DEBUG
          true
#else
false
#endif
        });

        Console.WriteLine("Finished");
        Console.ReadLine();
    }

    static async Task RunInDebugAsync()
    {
        await Task.Delay(1);

        var driver = SeleniumHelper.InitDriver(@"D:\pa\_dev\edgedriver_win64\");

        SeleniumService seleniumService = new SeleniumService(driver, logger);

        SeleniumNavigateService seleniumNavigateService = new(logger, driver, seleniumService);

        await seleniumNavigateService.Go("https://www.seznamka.cz/");

        var acceptCookies = driver.FindElement(By.CssSelector(".fc-button.fc-cta-consent.fc-primary-button"));
        acceptCookies?.Click();
    }

}
