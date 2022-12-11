namespace Dotnet.Perf.Labs.Tests;

public class StringManipulationTest
{
    private StringManipulation _sm;

    public StringManipulationTest()
    {
        _sm = new StringManipulation(10000);
    }

    [Fact]
    public void Compare_StringBuilder_append_against_string_concat()
    {
        Assert.True(TestHandler.Handler("string", () => _sm.TestString())
            > TestHandler.Handler("StringBuilder", () => _sm.TestStringBuilder()));
    }
}
