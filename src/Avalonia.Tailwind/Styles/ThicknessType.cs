using System;

namespace Avalonia.Tailwind.Styles
{
  public enum ThicknessType
  {
    All, Left, Top, Right, Bottom, X, Y,
  }

  public static class ThicknessTypeExtensions
  {
    public static string GetName(this ThicknessType thicknessType) => thicknessType switch
    {
      ThicknessType.All => null,
      ThicknessType.Bottom => "b",
      ThicknessType.Left => "l",
      ThicknessType.Right => "r",
      ThicknessType.Top => "t",
      ThicknessType.X => "x",
      ThicknessType.Y => "y",
      _ => throw new ArgumentOutOfRangeException(nameof(thicknessType)),
    };
  }
}
