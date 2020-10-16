using System;
using System.Collections.Generic;

namespace Avalonia.Tailwind
{
  public static class ThicknessDefinitions
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
      Create(int[] values, ThicknessType[] thicknessTypes)
    {
      for (int i = 0; i < values.Length; i++)
        foreach (var thicknessType in thicknessTypes)
          yield return (name: $"{i}", thicknessType, GetThickness(values[i], thicknessType));
    }
  }
}
