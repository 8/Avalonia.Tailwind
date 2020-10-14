using System.Collections.Generic;
using System.Collections.Immutable;

using Avalonia;
using Avalonia.Media;

namespace Avalonia.Tailwind
{
  public interface IStyleDefinitions
  {
    ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessSmall { get; }
    ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessLarge { get; }
    ImmutableArray<(string name, int value, Brush brush)> Brush { get; }
    ImmutableArray<(string name, double value)> FontSize { get; }
    ImmutableArray<(string name, double value)> Value { get; }
    ImmutableArray<(string name, CornerRadius cornerRadius)> CornerRadius { get; }
  }

  public class StyleDefinitions : IStyleDefinitions
  {
    public ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessSmall { get; }
    public ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessLarge { get; }
    public ImmutableArray<(string name, int value, Brush brush)> Brush { get; }
    public ImmutableArray<(string name, double value)> FontSize { get; }
    public ImmutableArray<(string name, double value)> Value { get; }
    public ImmutableArray<(string name, CornerRadius cornerRadius)> CornerRadius { get; }

    public StyleDefinitions(
      IEnumerable<(string name, ThicknessType type, Thickness thickness)> thicknessSmall,
      IEnumerable<(string name, ThicknessType type, Thickness thickness)> thicknessLarge,
      IEnumerable<(string name, int value, Brush brush)> brush,
      IEnumerable<(string name, double value)> size,
      IEnumerable<(string name, double vlaue)> value,
      IEnumerable<(string name, CornerRadius cornerRadius)> cornerRadius
    )
    {
      this.ThicknessSmall = thicknessSmall.ToImmutableArray();
      this.ThicknessLarge = thicknessLarge.ToImmutableArray();
      this.Brush = brush.ToImmutableArray();
      this.FontSize = size.ToImmutableArray();
      this.Value = value.ToImmutableArray();
      this.CornerRadius = cornerRadius.ToImmutableArray();
    }
  }
}
