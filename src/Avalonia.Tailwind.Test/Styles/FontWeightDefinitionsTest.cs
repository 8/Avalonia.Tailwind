using FluentAssertions;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Avalonia.Tailwind.Styles;

namespace Avalonia.Tailwind.Test.Styles
{
  public class FontWeightDefinitionsTest
  {
    private readonly ITestOutputHelper output;

    public FontWeightDefinitionsTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    [Fact]
    public void FontWeightDefinitionsTest_Create()
    {
      /* act */
      var fontWeights = FontWeightDefinitions.Create().ToArray();

      /* assert */
      this.output.Dump(fontWeights);
      fontWeights.Should().NotBeNullOrEmpty().And.HaveCount(16);
    }
  }
}
