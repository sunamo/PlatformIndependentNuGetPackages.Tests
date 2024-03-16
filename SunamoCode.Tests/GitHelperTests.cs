using SunamoWinStd;

namespace win.std.Tests;

[TestClass]
public class GitHelperTests
{
    [TestMethod]
    public void NameOfRepoFromOriginUriTest()
    {
        string actual = GitHelper.NameOfRepoFromOriginUri(@"https://github.com/sunamo/sunamoWithoutLocalDep.git");
        Assert.AreEqual("sunamoWithoutLocalDep", actual);
    }
}
