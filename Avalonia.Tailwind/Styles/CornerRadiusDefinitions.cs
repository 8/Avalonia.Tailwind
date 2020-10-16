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

    public static IEnumerable<(string name, CornerRadius cornerRadius)>
      CreateCornerRadiusDefinitions(ImmutableArray<double> values)
        => values.Select((value, i) => (name: GetRoundedName(i), value: new CornerRadius(value)));
  }
}
