using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Avalonia;
using Avalonia.Media;

namespace Avalonia.Tailwind
{
  public static class StyleDefinitionHelpers
  {
    public static ThicknessType[] GetThicknessTypes()
      => (ThicknessType[])Enum.GetValues(typeof(ThicknessType));

    static Thickness GetThickness(int value, ThicknessType type)
      => type switch
      {
        ThicknessType.All => new Thickness(value),
        ThicknessType.Left => new Thickness(value, default, default, default),
        ThicknessType.Top => new Thickness(default, value, default, default),
        ThicknessType.Right => new Thickness(default, default, value, default),
        ThicknessType.Bottom => new Thickness(default, default, default, value),
        ThicknessType.X => new Thickness(value, default),
        ThicknessType.Y => new Thickness(default, value),
        _ => throw new ArgumentException(nameof(type)),
      };

    public static IEnumerable<(string name, ThicknessType type, Thickness thickness)>
      CreateThicknessDefinitions(int[] values, ThicknessType[] thicknessTypes)
    {
      for (int i = 0; i < values.Length; i++)
        foreach (var thicknessType in thicknessTypes)
          yield return (name: $"{i}", thicknessType, GetThickness(values[i], thicknessType));
    }

    public static IEnumerable<(string name, int value, Brush brush)>
      CreateBrushDefinitions(ImmutableArray<(string name, ImmutableArray<Color> colors)> colorDefinitions)
        => colorDefinitions.SelectMany(colorDefinition
          => colorDefinition.colors.Select((c, i)
            => (name: colorDefinition.name, value: (i+1)*100, brush: (Brush)new SolidColorBrush(c, 1))
          )
      );

    static readonly string[] SizeNames = new[]
    {
      "xs",
      "sm",
      "base",
      "lg",
      "xl",
      "2xl",
      "3xl",
      "4xl",
      "5xl",
      "6xl",
    };
    static string GetSizeName(int index)
      => SizeNames.Length > index ? SizeNames[index] : $"{index - 3}xl";

    public static IEnumerable<(string name, double value)>
      CreateSizeDefinitions(ImmutableArray<double> values)
        => values.Select((value, i) => (name: GetSizeName(i), value: value));

    public static IEnumerable<(string name, double value)>
      CreateValueDefinitions(ImmutableArray<double> values)
        => values.Select((value, i) => (name: $"{i}", value: value));

    static readonly string[] RoundedNames = new[]
    {
      "none",
      "xs",
      "sm",
      "md",
      "lg",
      "xl",
      "2xl",
      "3xl",
    };
    static string GetRoundedName(int index)
      => RoundedNames.Length > index ? RoundedNames[index] : $"{index - 4}xl";

    public static IEnumerable<(string name, CornerRadius cornerRadius)>
      CreateCornerRadiusDefinitions(ImmutableArray<double> values)
        => values.Select((value, i) => (name: GetRoundedName(i), value: new CornerRadius(value)));
  }
}
