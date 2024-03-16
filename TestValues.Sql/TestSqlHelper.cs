public class TestSqlHelper
{
    //[Fact]
    public static void Init(UnitTestInit i)
    {
        // todo CryptDataWrapper nemůžu použít protože je v Credentials/Crypting. dočasně vše zakomentuji

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
