using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Avalonia.Tailwind.Test
{
  public class ScalesTest
  {
    private readonly ITestOutputHelper output;

    public ScalesTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    [Fact]
    public void ScalesTest_SmallScale()
    {
      var result = Scales.SmallScaleInt;

      this.output.Dump(result);

      result.Should().NotBeNull().And.NotBeEmpty();
    }
  }
}
