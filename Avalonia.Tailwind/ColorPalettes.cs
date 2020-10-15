using Avalonia.Media;
using System.Collections.Immutable;
using System.Linq;

namespace Avalonia.Tailwind
{
  public static class ColorPalettes
  {
    public static Color FromHex(uint hex) => Color.FromUInt32(0xFF000000 | hex);

    static (string name, ImmutableArray<Color> colors) GetPalette(string name, params uint[] colors)
      => (name, colors.Select(c => FromHex(c)).ToImmutableArray());

    public static readonly (string name, ImmutableArray<Color>) Gray =
      GetPalette(nameof(Gray), 0xF7FAFC,0xEDF2F7, 0xE2E8F0, 0xCBD5E0, 0xA0AEC0, 0x718096, 0x4A5568, 0x2D3748, 0x1A202C);

    public static readonly (string name, ImmutableArray<Color>) Red =
      GetPalette(nameof(Red), 0xFFF5F5, 0xFED7D7, 0xFEB2B2, 0xFC8181, 0xF56565, 0xE53E3E, 0xC53030, 0x9B2C2C, 0x742A2A);

    public static readonly (string name, ImmutableArray<Color>) Orange =
      GetPalette(nameof(Orange), 0xFFFAF0, 0xFEEBC8, 0xFBD38D, 0xF6AD55, 0xED8936, 0xDD6B20, 0xC05621, 0x9C4221, 0x7B341E);

    public static readonly (string name, ImmutableArray<Color>) Yellow =
      GetPalette(nameof(Yellow), 0xFFFFF0, 0xFEFCBF, 0xFAF089, 0xF6E05E, 0xECC94B, 0xD69E2E, 0xB7791F, 0x975A16, 0x744210);

    public static readonly (string name, ImmutableArray<Color>) Green =
      GetPalette(nameof(Green), 0xF0FFF4, 0xC6F6D5, 0x9AE6B4, 0x68D391, 0x48BB78, 0x38A169, 0x2F855A, 0x276749, 0x22543D);

    public static readonly (string name, ImmutableArray<Color>) Teal =
      GetPalette(nameof(Teal), 0xE6FFFA, 0xB2F5EA, 0x81E6D9, 0x4FD1C5, 0x38B2AC, 0x319795, 0x2C7A7B, 0x285E61, 0x234E52);

    public static readonly (string name, ImmutableArray<Color>) Blue =
      GetPalette(nameof(Blue), 0xEBF8FF, 0xBEE3F8, 0x90CDF4, 0x63B3ED, 0x4299E1, 0x3182CE, 0x2B6CB0, 0x2C5282, 0x2A4365);

    public static readonly (string name, ImmutableArray<Color>) Indigo =
      GetPalette(nameof(Indigo), 0xEBF4FF, 0xC3DAFE, 0xA3BFFA, 0x7F9CF5, 0x667EEA, 0x5A67D8, 0x4C51BF, 0x434190, 0x3C366B);

    public static readonly (string name, ImmutableArray<Color>) Purple =
      GetPalette(nameof(Purple), 0xFAF5FF, 0xE9D8FD, 0xD6BCFA, 0xB794F4, 0x9F7AEA, 0x805AD5, 0x6B46C1, 0x553C9A, 0x44337A);

    public static readonly (string name, ImmutableArray<Color>) Pink =
      GetPalette(nameof(Pink), 0xFFF5F7, 0xFED7E2, 0xFBB6CE, 0xF687B3, 0xED64A6, 0xD53F8C, 0xB83280, 0x97266D, 0x702459);

  }
}
