using System;

namespace Avalonia
{
  public static class EnumEx
  {
    public static T[] GetValues<T>() => (T[])Enum.GetValues(typeof(T));
  }
}
