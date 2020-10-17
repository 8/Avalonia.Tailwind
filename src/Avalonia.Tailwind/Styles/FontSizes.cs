using System.Collections.Generic;
using System.Linq;

namespace Avalonia.Tailwind.Styles
{
  public static class FontSizes
  {
    public static IEnumerable<double> CreateValues(double baseSize = 12.0)
    {
      yield return baseSize * 0.75;
      yield return baseSize * 0.875;
      yield return baseSize * 1.0;
      yield return baseSize * 1.125;
      yield return baseSize * 1.25;
      yield return baseSize * 1.5;
      yield return baseSize * 1.875;
      yield return baseSize * 2.25;
      yield return baseSize * 3;
      yield return baseSize * 4;
    }

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
      Create(IEnumerable<double> values)
        => values.Select((value, i) => (name: GetSizeName(i), value: value));
  }
}
