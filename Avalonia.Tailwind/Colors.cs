using Avalonia.Media;
using System.Collections.Immutable;

namespace Avalonia.Tailwind
{
  public static class Colors
  {
    public static Color FromHex(uint hex)
    {
      return Color.FromUInt32(0xFF000000 | hex);
    }

    public static readonly ImmutableArray<Color> Gray = new []
    {
      FromHex(0xF7FAFC),
      FromHex(0xEDF2F7),
      FromHex(0xE2E8F0),
      FromHex(0xCBD5E0),
      FromHex(0xA0AEC0),
      FromHex(0x718096),
      FromHex(0x4A5568),
      FromHex(0x2D3748),
      FromHex(0x1A202C),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Red = new[]
    {
      FromHex(0xFFF5F5),
      FromHex(0xFED7D7),
      FromHex(0xFEB2B2),
      FromHex(0xFC8181),
      FromHex(0xF56565),
      FromHex(0xE53E3E),
      FromHex(0xC53030),
      FromHex(0x9B2C2C),
      FromHex(0x742A2A),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Orange = new []
    {
      FromHex(0xFFFAF0),
      FromHex(0xFEEBC8),
      FromHex(0xFBD38D),
      FromHex(0xF6AD55),
      FromHex(0xED8936),
      FromHex(0xDD6B20),
      FromHex(0xC05621),
      FromHex(0x9C4221),
      FromHex(0x7B341E),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Yellow = new []
    {
      FromHex(0xFFFFF0),
      FromHex(0xFEFCBF),
      FromHex(0xFAF089),
      FromHex(0xF6E05E),
      FromHex(0xECC94B),
      FromHex(0xD69E2E),
      FromHex(0xB7791F),
      FromHex(0x975A16),
      FromHex(0x744210),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Green = new []
    {
      FromHex(0xF0FFF4),
      FromHex(0xC6F6D5),
      FromHex(0x9AE6B4),
      FromHex(0x68D391),
      FromHex(0x48BB78),
      FromHex(0x38A169),
      FromHex(0x2F855A),
      FromHex(0x276749),
      FromHex(0x22543D),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Teal = new[]
    {
      FromHex(0xE6FFFA),
      FromHex(0xB2F5EA),
      FromHex(0x81E6D9),
      FromHex(0x4FD1C5),
      FromHex(0x38B2AC),
      FromHex(0x319795),
      FromHex(0x2C7A7B),
      FromHex(0x285E61),
      FromHex(0x234E52),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Blue = new[]
    {
      FromHex(0xEBF8FF),
      FromHex(0xBEE3F8),
      FromHex(0x90CDF4),
      FromHex(0x63B3ED),
      FromHex(0x4299E1),
      FromHex(0x3182CE),
      FromHex(0x2B6CB0),
      FromHex(0x2C5282),
      FromHex(0x2A4365),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Indigo = new[]
    {
      FromHex(0xEBF4FF),
      FromHex(0xC3DAFE),
      FromHex(0xA3BFFA),
      FromHex(0x7F9CF5),
      FromHex(0x667EEA),
      FromHex(0x5A67D8),
      FromHex(0x4C51BF),
      FromHex(0x434190),
      FromHex(0x3C366B),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Purple = new[]
    {
      FromHex(0xFAF5FF),
      FromHex(0xE9D8FD),
      FromHex(0xD6BCFA),
      FromHex(0xB794F4),
      FromHex(0x9F7AEA),
      FromHex(0x805AD5),
      FromHex(0x6B46C1),
      FromHex(0x553C9A),
      FromHex(0x44337A),
    }.ToImmutableArray();

    public static readonly ImmutableArray<Color> Pink = new[]
    {
      FromHex(0xFFF5F7),
      FromHex(0xFED7E2),
      FromHex(0xFBB6CE),
      FromHex(0xF687B3),
      FromHex(0xED64A6),
      FromHex(0xD53F8C),
      FromHex(0xB83280),
      FromHex(0x97266D),
      FromHex(0x702459),
    }.ToImmutableArray();

  }
}
