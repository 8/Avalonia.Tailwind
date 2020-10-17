using System.Collections;
using System.Linq;
using Xunit.Abstractions;

namespace Avalonia.Tailwind
{
  public static class TestOutputHelperExtensions
  {
    public static string Format(object o)
      => o switch
      {
        null => "NULL",
        string s => s,
        IEnumerable enumerable => $"[" + string.Join(", ", enumerable.Cast<object>().Select(item => Format(item))) + "]",
        var ob => ob.ToString(),
      };

    public static void Dump(this ITestOutputHelper testOutputHelper, object o)
      => testOutputHelper.WriteLine(Format(o));
  }
}
