using Avalonia.Media;
using System.Collections.Generic;
using System.Collections.Immutable;
using Xunit;

namespace Avalonia.Tailwind.Test
{
  public class ColorDefinitionProviderTest
  {
    [Fact]
    public void ColorDefinitionProviderTest_Ctor() => new ColorDefinitionProvider(
      new ImmutableArray<(string name, ImmutableArray<Color> colors)> { }
    );
  }
}
