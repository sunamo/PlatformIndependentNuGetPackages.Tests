namespace sunamo.Tests;
public class TestClass
{
    public TestClassInner TestClassInner { get; set; }
}

public class TestClassInner
{
    public string Name { get; set; }
    public int ID { get; set; }
    public DateTime? DateTime { get; set; }
    public string Address { get; set; }
}

[TestClass]
public class ReClasserTests
{
    [TestMethod]
    public void FixMeUpTest()
    {
        bool inner = false;

        TestClassInner ti = new TestClassInner();
        ti.Address = "address";
        ti.ID = 132;
        ti.Name = string.Empty;
        ti.DateTime = null;

        object t = null;

        if (inner)
        {
            t = ti;
        }
        else
        {
            /*
Na outer objekty toto nefunguje
            musel bych skládat objekt tak že bych subprops nahrazoval novými okleštěnými
             */
            TestClass to = new TestClass();
            to.TestClassInner = ti;

            t = to;
        }

        var d1 = RH.DumpAsObjectDumperNet(t);
        var ret = t.FixMeUp();
        var d2 = RH.DumpAsObjectDumperNet(ret);
    }
}
