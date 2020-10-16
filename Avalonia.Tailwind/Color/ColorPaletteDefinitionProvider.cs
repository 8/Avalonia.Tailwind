using Avalonia.Media;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Avalonia.Tailwind.Colors
{
  public interface IColorDefinitionProvider
  {
    ImmutableArray<(string name, ImmutableArray<Color> colors)> ColorDefinitions { get; }
  }

  public class ColorPaletteDefinitionProvider : IColorDefinitionProvider
  {
    public ImmutableArray<(string name, ImmutableArray<Color> colors)> ColorDefinitions { get; }

    public ColorPaletteDefinitionProvider(IEnumerable<(string name, ImmutableArray<Color> colors)> colorDefinitions)
    {
      this.ColorDefinitions = colorDefinitions.ToImmutableArray();
    }
  }
}
