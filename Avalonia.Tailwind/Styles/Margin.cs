using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Avalonia.Tailwind
{
  public static class Values
  {
    public static IEnumerable<(string name, double value)>
      Create(ImmutableArray<double> values)
        => values.Select((value, i) => (name: $"{i}", value: value));
  }
}
