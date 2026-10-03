using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apps;

public class ProtectedDataTestsShared
{
    public async static void Tests()
    {
        string pw = "1Pompinka5*";

        var data = AppDataApps.ci.GetFolder(AppFolders.Data);
        //var _3ec7c014 = await data.CreateFileAsync("_3ec7c014.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
        var _6c87ecd0 = await data.CreateFileAsync("_6c87ecd0.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
        var _9463ec63 = await data.CreateFileAsync("_9463ec63.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
        var sf = await data.CreateFileAsync("a.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

        //P_3ec7c014.SaveSecureToDisc(null, pw, _3ec7c014);
        P_6c87ecd0.SaveSecureToDisc(null, pw, _6c87ecd0);
        P_9463ec63.SaveSecureToDisc(null, pw, _9463ec63);
        ProtectedDataHelper.SaveSecureToDisc(null, pw, sf);
    }
}