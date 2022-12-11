using System.Diagnostics;

namespace Dotnet.Perf.Labs.Utils
{
    public static class TestHandler
    {
        public delegate void Del();

        public static long Handler(string Id, Del callback)
        {
            Stopwatch sw = new Stopwatch();

            sw.Reset();
            sw.Start();

            callback();

            sw.Stop();
            Console.WriteLine($" {Id}: {sw.ElapsedMilliseconds} ms");

            return sw.ElapsedMilliseconds;
        }
    }
}
