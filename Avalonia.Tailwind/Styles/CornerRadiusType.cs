using System;

namespace Avalonia.Tailwind.Styles
{
  public enum CornerRadiusType
  {
    All, TopLeft, TopRight, BottomRight, BottomLeft, Top, Bottom, Left, Right
  }

  public static class CornerRadiusTypeExtensions
  {
    public static string GetName(this CornerRadiusType radiusType) => radiusType switch
    {
      CornerRadiusType.All => null,
      CornerRadiusType.Top => "t",
      CornerRadiusType.Bottom => "b",
      CornerRadiusType.Left => "l",
      CornerRadiusType.Right => "r",
      CornerRadiusType.BottomLeft => "bl",
      CornerRadiusType.TopLeft => "tl",
      CornerRadiusType.BottomRight => "br",
      CornerRadiusType.TopRight => "tr",
      _ => throw new ArgumentOutOfRangeException(nameof(radiusType)),
    };
  }
}
