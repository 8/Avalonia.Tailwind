using Avalonia.Controls;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace Avalonia.Tailwind.Test.Controls
{
  public class PseudoClassHelperTest
  {
    private readonly ITestOutputHelper output;

    public PseudoClassHelperTest(ITestOutputHelper output)
    {
      this.output = output;
    }

    [Fact]
    public void PseudoClassHelperTest_Ctor()
    {
      var type = typeof(Button);

      var attributes = type.GetCustomAttributes();

      foreach (var att in attributes)
        this.output.Dump(att);

    }
  }
}
