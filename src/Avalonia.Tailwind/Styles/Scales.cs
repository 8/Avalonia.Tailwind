using System.Collections.Immutable;
using System.Linq;

namespace Avalonia.Tailwind.Styles
{
  public static class Scales
  {
    public static readonly int[] SmallScaleInt
      = { 0, 1, 2, 4, 8, 16, 32 };

    public static readonly int[] LargeScaleInt
      = { 0, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

    public static readonly ImmutableArray<double> LargeScaleDouble
      = LargeScaleInt.Select(i => (double)i).ToImmutableArray();

    public static readonly ImmutableArray<double> SmallScaleDouble
      = SmallScaleInt.Select(i => (double)i).ToImmutableArray();
  }
}
