using System.Collections.Immutable;
using Xunit;
using Avalonia.Media;

namespace Avalonia.Tailwind.Test
{
  public class ColorsTest
  {
    [Fact]
    public void ColorsTest_Ctor()
    {
      //var blue = Colors.Blue;

      //Color.FromRgb(0xF7, 0xFA, 0xFC);

      //new ImmutableArray<Color>()
      var colors = new []
    {

      Color.FromRgb(0xF7, 0xFA, 0xFC)
      //Color.FromRgb(0xED, 0xF2, 0xF7),
      //Color.FromRgb(0xE2, 0xE8, 0xF0),
      //Color.FromRgb(0xCB, 0xD5, 0xE0),
      //Color.FromRgb(0xA0, 0xAE, 0xC0),
      //Color.FromRgb(0x71, 0x80, 0x96),
      //Color.FromRgb(0x4A, 0x55, 0x68),
      //Color.FromRgb(0x2D, 0x37, 0x48),
      //Color.FromRgb(0x1A, 0x20, 0x2C),
    }.ToImmutableArray();
    }
  }
}
