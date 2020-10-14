using Avalonia.Media;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Avalonia.Tailwind
{
  public interface IColorDefinitionProvider
  {
    ImmutableArray<(string name, ImmutableArray<Color> colors)> ColorDefinitions { get; }
  }

  public class ColorDefinitionProvider : IColorDefinitionProvider
  {
    public ImmutableArray<(string name, ImmutableArray<Color> colors)> ColorDefinitions { get; }

    public ColorDefinitionProvider(IEnumerable<(string name, ImmutableArray<Color> colors)> colorDefinitions)
    {
      this.ColorDefinitions = colorDefinitions.ToImmutableArray();
    }
  }
}
