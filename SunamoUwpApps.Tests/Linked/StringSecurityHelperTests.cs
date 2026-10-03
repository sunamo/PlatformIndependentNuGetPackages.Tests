using apps.Secure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
//using Xunit;

public class StringSecurityHelperTests
{
    /// <summary>
    /// DOnt run as unit test: The following TestContainer was not found 'E:\vs\Projects\_Uap\App1\App1\bin\x86\Debug\App1.exe'
    /// 
    /// </summary>
    //[Fact]
    public static void StringSecurityHelperRun()
    {
        var input = "1Pompinka5*";
        var encrypted = StringSecurityHelper.EncryptString(null, input);
        var decrypted = StringSecurityHelper.DecryptString(null, encrypted);

        if (input != decrypted)
        {
            Debugger.Break();
        }
        //Assert.Equal(input, decrypted);
    }

    public async static void SaveToFile()
    {
        var input = "1Pompinka5*";
        var encrypted = StringSecurityHelper.EncryptString(null, input);

        var folder = ApplicationData.Current.LocalFolder;
        var file = await folder.CreateFileAsync( "a.txt", CreationCollisionOption.OpenIfExists);

        await FileIO.WriteTextAsync(file, encrypted, Windows.Storage.Streams.UnicodeEncoding.Utf16BE);

        var decryptedFile = await FileIO.ReadTextAsync(file);
        var decrypted = StringSecurityHelper.DecryptString(null, decryptedFile);

        if (input != decrypted)
        {
            Debugger.Break();
        }
    }
}