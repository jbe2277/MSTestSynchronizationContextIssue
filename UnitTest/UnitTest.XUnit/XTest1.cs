using System.Waf.UnitTesting;

namespace UnitTest.XUnit;

public sealed class XTest1 : IDisposable
{
    public UnitTestSynchronizationContext Context { get; private set; } = null!;

    public XTest1()
    {
        Context = UnitTestSynchronizationContext.Create();
        Assert.Same(Context, SynchronizationContext.Current);
    }

    public void Dispose()
    {
        Assert.Same(Context, SynchronizationContext.Current);
        Context.Dispose();
    }

    [Fact]
    public void TestMethod1()
    {
        Assert.Same(Context, SynchronizationContext.Current);
    }

    [Fact]
    public void TestMethod2()
    {
        Assert.Same(Context, SynchronizationContext.Current);
    }
}
