using System.Waf.UnitTesting;

namespace UnitTestOld.MSTest;

[TestClass]
public sealed class MSTest1
{
    public UnitTestSynchronizationContext Context { get; private set; } = null!;
    
    [TestInitialize]
    public void TestInitialize()
    {
        Context = UnitTestSynchronizationContext.Create();
        Assert.AreSame(Context, SynchronizationContext.Current);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Assert.AreSame(Context, SynchronizationContext.Current);
        Context.Dispose();
    }

    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreSame(Context, SynchronizationContext.Current);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreSame(Context, SynchronizationContext.Current);
    }
}
