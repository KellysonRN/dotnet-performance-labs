using System.Text;
using Dotnet.Perf.Labs.Utils;

namespace Dotnet.Perf.Labs;

public sealed class StringManipulation
{
    private readonly int _count;

    public StringManipulation(int count = 1000)
    {
        _count = count;
    }

    public void TestString()
    {
        string test = string.Empty;

        for (int i = 0; i < _count; i++)
        {
            test += i.ToString();
        }
    }

    public void TestStringBuilder()
    {
        var test = new StringBuilder();

        for (int i = 0; i < _count; i++)
        {
            test.Append(i);
        }
    }
}
