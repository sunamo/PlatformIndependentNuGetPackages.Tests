public class TestSqlHelper
{
    //[Fact]
    public static void Init(UnitTestInit i)
    {
        _ = i;
        // todo CryptDataWrapper cannot be used because it lives in Credentials/Crypting; everything is commented out for now

        //XlfResourcesHSunamo.SaveResouresToRLSunamo(LocalizationLanguagesLoader.Load());

        //CryptHelper.ApplyCryptData(CryptHelper.RijndaelBytes.Instance, CryptDataWrapper.rijn);


        //// First must ApplyCryptData
        //if (i.cryptData)
        //{
        //    CryptHelper.ApplyCryptData(CryptHelper.RijndaelBytes.Instance, CryptDataWrapper.rijn);
        //}

        //// Then I can connect
        //if (i.databases.HasValue)
        //{
        //    // TODO: DbHelper
        //    //DatabasesConnections.SetConnToMSDatabaseLayer(i.databases.Value, null);
        //}
    }
}
