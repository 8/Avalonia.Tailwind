using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Avalonia.Layout;
using Avalonia.Media;

namespace Avalonia.Tailwind.Styles
{
  public interface IStyleDefinitions
  {
    ImmutableArray<(string name, ThicknessType type, Thickness thickness)> BorderThickness { get; }
    ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessLarge { get; }
    ImmutableArray<(string name, int value, Brush brush)> Brush { get; }
    ImmutableArray<(string name, double value)> FontSize { get; }
    ImmutableArray<(string name, CornerRadius cornerRadius)> CornerRadius { get; }
    ImmutableArray<(string name, FontWeight weight)> FontWeight { get; }
    ImmutableArray<(string name, double value)> Spacing { get; }
    ImmutableArray<(string name, double value)> Width { get; }
    ImmutableArray<(string name, double value)> Height { get; }
    ImmutableArray<(string name, HorizontalAlignment alignment)> HorizontalAlignment { get; }
    ImmutableArray<(string name, VerticalAlignment alignment)> VerticalAlignment { get; }
    ImmutableDictionary<Type, ImmutableArray<string>> PseudoClasses { get; }
  }

  public class StyleDefinitions : IStyleDefinitions
  {
    public ImmutableArray<(string name, ThicknessType type, Thickness thickness)> BorderThickness { get; }
    public ImmutableArray<(string name, ThicknessType type, Thickness thickness)> ThicknessLarge { get; }
    public ImmutableArray<(string name, int value, Brush brush)> Brush { get; }
    public ImmutableArray<(string name, double value)> FontSize { get; }
    public ImmutableArray<(string name, CornerRadius cornerRadius)> CornerRadius { get; }
    public ImmutableArray<(string name, FontWeight weight)> FontWeight { get; }
    public ImmutableArray<(string name, double value)> Spacing { get; }
    public ImmutableArray<(string name, double value)> Width { get; }
    public ImmutableArray<(string name, double value)> Height { get; }
    public ImmutableArray<(string name, HorizontalAlignment alignment)> HorizontalAlignment { get; }
    public ImmutableArray<(string name, VerticalAlignment alignment)> VerticalAlignment { get; }
    public ImmutableDictionary<Type, ImmutableArray<string>> PseudoClasses { get; }

    public StyleDefinitions(
      IEnumerable<(string name, ThicknessType type, Thickness thickness)> borderThickness,
      IEnumerable<(string name, ThicknessType type, Thickness thickness)> thicknessLarge,
      IEnumerable<(string name, int value, Brush brush)> brush,
      IEnumerable<(string name, double value)> fontSize,
      IEnumerable<(string name, CornerRadius cornerRadius)> cornerRadius,
      IEnumerable<(string name, FontWeight weight)> fontWeight,
      IEnumerable<(string name, double vlaue)> spacing,
      IEnumerable<(string name, double vlaue)> width,
      IEnumerable<(string name, double vlaue)> height,
      IEnumerable<(string name, HorizontalAlignment alignment)> horizontalAlignment,
      IEnumerable<(string name, VerticalAlignment alignment)> verticalAlignment,
      IDictionary<Type, ImmutableArray<string>> pseudoClasses
    )
    {
      this.BorderThickness = borderThickness.ToImmutableArray();
      this.ThicknessLarge = thicknessLarge.ToImmutableArray();
      this.Brush = brush.ToImmutableArray();
      this.FontSize = fontSize.ToImmutableArray();
      this.CornerRadius = cornerRadius.ToImmutableArray();
      this.FontWeight = fontWeight.ToImmutableArray();
      this.Spacing = spacing.ToImmutableArray();
      this.Width = width.ToImmutableArray();
      this.Height = height.ToImmutableArray();
      this.HorizontalAlignment = horizontalAlignment.ToImmutableArray();
      this.VerticalAlignment = verticalAlignment.ToImmutableArray();
      this.PseudoClasses = pseudoClasses.ToImmutableDictionary();
    }
  }
}
