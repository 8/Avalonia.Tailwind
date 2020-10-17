using System;
using System.Linq;
using System.Text;

namespace Avalonia.Tailwind.Styles
{
  public static class CssClassName
  {
    public static string GetClassNameCamelCase(params string[] parts)
    {
      var strBuilder = new StringBuilder();

      static string Capitalize(string part)
        => $"{char.ToUpperInvariant(part[0])}{part[1..]}";

      static string Lower(string part)
        => $"{char.ToLowerInvariant(part[0])}{part[1..]}";

      for (int i = 0; i < parts.Length; i++)
        strBuilder.Append(i == 0 ? Lower(parts[i]) : Capitalize(parts[i]));

      return strBuilder.ToString();
    }

    public static string GetClassNameUnderScore(params string[] parts)
      => string.Join("_", parts.Where(p => !string.IsNullOrEmpty(p)).Select(p => p.ToLower()));

    public static string GetClassName(ClassNamingStrategy namingStrategy, params string[] parts)
      => namingStrategy switch
      {
        ClassNamingStrategy.CamelCase => CssClassName.GetClassNameCamelCase(parts),
        ClassNamingStrategy.Underscore => CssClassName.GetClassNameUnderScore(parts),
        _ => throw new ArgumentException(nameof(namingStrategy)),
      };
  }
}
