using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GlobalUsingsInstanceTests
{
    [Fact]
    public async Task GlobalUsingsInstance_Test()
    {
        GlobalUsingsInstance g = new GlobalUsingsInstance();
        await g.Init(@"E:\vs\Projects\sunamoWithoutLocalDep\SunamoArgs\GlobalUsings.cs");

        g.AddNewGlobalUsing("a");
        await g.Save();
    }
}

