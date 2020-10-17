using System.Collections.Immutable;
using Xunit;
using Avalonia.Media;

namespace Avalonia.Tailwind.Colors.Test
{
  public class ColorPaletteDefinitionProviderTest
  {
    [Fact]
    public void ColorPaletteDefinitionProviderTest_Ctor() => new ColorPaletteDefinitionProvider(
      new ImmutableArray<(string name, ImmutableArray<Color> colors)> { }
    );
  }
}
