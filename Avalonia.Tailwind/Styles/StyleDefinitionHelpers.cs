using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Avalonia;

namespace Avalonia.Tailwind
{
  public static class StyleDefinitionHelpers
  {
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
  }
}
