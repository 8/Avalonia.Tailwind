using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Avalonia.Media;

namespace Avalonia.Tailwind
{
  public static class BrushDefinitions
  {
    public static IEnumerable<(string name, int value, Brush brush)>
      Create(ImmutableArray<(string name, ImmutableArray<Color> colors)> colorDefinitions)
        => colorDefinitions.SelectMany(colorDefinition
          => colorDefinition.colors.Select((c, i)
            => (name: colorDefinition.name, value: (i + 1) * 100, brush: (Brush)new SolidColorBrush(c, 1))
          )
      );
  }
}
