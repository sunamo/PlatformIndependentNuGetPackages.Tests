namespace win.std.Tests;


public class GitHelperTests
{
    [Fact]
    public void NameOfRepoFromOriginUriTest()
    {
        string actual = GitHelper.NameOfRepoFromOriginUri(@"https://github.com/sunamo/sunamoWithoutLocalDep.git");
        Assert.Equal("sunamoWithoutLocalDep", actual);
    }
}
