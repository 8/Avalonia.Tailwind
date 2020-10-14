using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace Avalonia.Tailwind
{
  public static class Styles
  {
    public static IEnumerable<AvaloniaProperty> GetAvaloniaProperties(Type controlType)
      => AvaloniaPropertyRegistry.Instance.GetRegistered(controlType);

    public static IEnumerable<(Type controlType, AvaloniaProperty property)> GetAvaloniaControlProperties(IEnumerable<Type> controlTypes)
      => controlTypes.SelectMany(c => GetAvaloniaProperties(c).Select(p => (c, p)));

    static Style CreateStyle(Type controlType, AvaloniaProperty property, object value, string name)
      => new Style
      {
        Selector = Selectors.OfType(null, controlType).Class(name),
        Setters = new List<ISetter> { new Setter(property, value) },
      };

    static string GetClassNameCamelCase(params string[] parts)
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

    static string GetClassNameUnderScore(params string[] parts)
      => string.Join("_", parts.Where(p => !string.IsNullOrEmpty(p)).Select(p => p.ToLower()));

    static IEnumerable<Style> CreateStyles(
      Type controlType,
      AvaloniaProperty property,
      IStyleDefinitions definitions,
      NamingStrategy namingStrategy
      )
    {
      string getClassName(params string[] parts)
        => namingStrategy switch
        {
          NamingStrategy.CamelCase => GetClassNameCamelCase(parts),
          NamingStrategy.Underscore => GetClassNameUnderScore(parts),
          _ => throw new ArgumentException(nameof(namingStrategy)),
        };

      return property.Name switch
      {
        "BorderThickness" => definitions.ThicknessSmall.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("m", d.type.GetName(), d.name))),

        "Padding" => definitions.ThicknessLarge.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("m", d.type.GetName(), d.name))),

        "Margin" => definitions.ThicknessLarge.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("m", d.type.GetName(), d.name))),

        "BorderBrush" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName("border", d.name, $"{d.value}"))),

        "Background" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName("bg", d.name, $"{d.value}"))),

        "Foreground" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName($"{d.name}", $"{d.value}"))),

        "Fill" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName(d.name, $"{d.value}"))),

        "FontSize" => definitions.FontSize.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"text", d.name))),

        "Spacing" => definitions.Value.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"s", d.name))),

        "Width" => definitions.Value.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"w", d.name))),

        "Height" => definitions.Value.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"h", d.name))),

        "CornerRadius" => definitions.CornerRadius.Select(d =>
          CreateStyle(controlType, property, d.cornerRadius, getClassName($"rounded", d.name))),

        _ => new Style[0],
      };
    }

    public static IEnumerable<Style> CreateStyles(
      IStyleDefinitions definitions,
      IEnumerable<Type> controlTypes,
      NamingStrategy namingStrategy)
    {
      //yield return CreateStyle<Border>("b2", Border.BorderThicknessProperty, new Thickness(2));
      //yield return CreateStyle<Border>("borderBlue", Border.BorderBrushProperty, new SolidColorBrush(Color.FromRgb(0x2b, 0x6c, 0xb0)));

      foreach (var controlProperty in GetAvaloniaControlProperties(controlTypes))
        foreach (var style in CreateStyles(controlProperty.controlType, controlProperty.property, definitions, namingStrategy))
          yield return style;
    }

  }

}
