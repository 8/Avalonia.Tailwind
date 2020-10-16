using System.Collections.Generic;
using System.Collections.Immutable;

namespace Avalonia.Tailwind.Styles
{
  public static class Sizes
  {
    static IEnumerable<double> CreateSizes(double baseSize)
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

    public static readonly ImmutableArray<double> SizeValues = CreateSizes(12.0).ToImmutableArray();
  }
}
