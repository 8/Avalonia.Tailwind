using Avalonia.Tailwind.Styles;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Avalonia.Tailwind
{
  public static class CornerRadiusDefinitions
  {
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

    public static CornerRadiusType[] GetCornerRadiusTypes()
      => EnumEx.GetValues<CornerRadiusType>();

    const double defaultValue = double.NaN;

    static CornerRadius GetCornerRadius(double value, CornerRadiusType type)
      => type switch
      {
        CornerRadiusType.All => new CornerRadius(value),
        CornerRadiusType.TopLeft => new CornerRadius(value, defaultValue, defaultValue, defaultValue),
        CornerRadiusType.TopRight => new CornerRadius(defaultValue, value, defaultValue, defaultValue),
        CornerRadiusType.BottomRight => new CornerRadius(defaultValue, defaultValue, value, defaultValue),
        CornerRadiusType.BottomLeft => new CornerRadius(defaultValue, defaultValue, defaultValue, value),
        CornerRadiusType.Left => new CornerRadius(value, default, default, value),
        CornerRadiusType.Right => new CornerRadius(default, value, value, default),
        CornerRadiusType.Top => new CornerRadius(value, default),
        CornerRadiusType.Bottom => new CornerRadius(default, value),
        _ => throw new ArgumentException(nameof(type)),
      };

    public static IEnumerable<(string name, CornerRadiusType cornerRadiusType, CornerRadius cornerRadius)>
      CreateCornerRadiusDefinitions(ImmutableArray<double> values, CornerRadiusType[] cornerRadiusTypes)
    {
      for (int i = 0; i < values.Length; i++)
        foreach (var cornerRadiusType in cornerRadiusTypes)
          yield return (name: GetRoundedName(i), cornerRadiusType, cornerRadius: GetCornerRadius(values[i], cornerRadiusType));
        //return values.Select((value, i) => (name: GetRoundedName(i), value: GetCornerRadius(value, cornerRadiusType)));
    }
  }
}
