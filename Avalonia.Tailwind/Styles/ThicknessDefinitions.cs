using System;
using System.Collections.Generic;

namespace Avalonia.Tailwind.Styles
{
  public static class ThicknessDefinitions
  {
    public static ThicknessType[] GetThicknessTypes()
      => (ThicknessType[])Enum.GetValues(typeof(ThicknessType));

    const double defaultValue = double.NaN;

    static Thickness GetThickness(int value, ThicknessType type)
      => type switch
      {
        ThicknessType.All => new Thickness(value),
        ThicknessType.Left => new Thickness(value, defaultValue, defaultValue, defaultValue),
        ThicknessType.Top => new Thickness(defaultValue, value, defaultValue, defaultValue),
        ThicknessType.Right => new Thickness(defaultValue, defaultValue, value, defaultValue),
        ThicknessType.Bottom => new Thickness(defaultValue, defaultValue, defaultValue, value),
        ThicknessType.X => new Thickness(value, defaultValue),
        ThicknessType.Y => new Thickness(defaultValue, value),
        _ => throw new ArgumentException(nameof(type)),
      };

    public static IEnumerable<(string name, ThicknessType type, Thickness thickness)>
      Create(int[] values, ThicknessType[] thicknessTypes)
    {
      for (int i = 0; i < values.Length; i++)
        foreach (var thicknessType in thicknessTypes)
          yield return (name: $"{i}", thicknessType, GetThickness(values[i], thicknessType));
    }
  }
}
