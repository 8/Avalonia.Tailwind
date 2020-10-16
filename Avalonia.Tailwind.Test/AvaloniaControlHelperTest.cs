using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

namespace Avalonia.Tailwind.Controls.Test
{
  public class AvaloniaControlHelperTest
  {
    private readonly ITestOutputHelper output;

    public AvaloniaControlHelperTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    [Fact]
    public void AvaloniaControlHelperTest_GetAvaloniaControls()
    {
      /* act & arrange */
      var types = AvaloniaControlHelper.GetAvaloniaControls();
      this.output.Dump(types);

      /* assert */
      types.Should().NotBeNullOrEmpty();
    }
  }
}
