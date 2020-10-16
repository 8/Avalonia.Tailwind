using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Styling;
using Avalonia.Tailwind.Controls;
using Avalonia.Tailwind.Styles;

namespace Avalonia.Tailwind
{
  public static class StyleUtils
  {
    static Style CreateStyle(Type controlType, AvaloniaProperty property, object value, string name)
      => new Style
      {
        Selector = Selectors.OfType(null, controlType).Class(name),
        Setters = new List<ISetter> { new ConsolidateSetter(property, value) },
      };

    static IEnumerable<Style> CreateStyles(
      Type controlType,
      AvaloniaProperty property,
      IStyleDefinitions definitions,
      ClassNamingStrategy namingStrategy
      )
    {
      string getClassName(params string[] p) => CssClassName.GetClassName(namingStrategy, p);

      return property.Name switch
      {
        "BorderThickness" => definitions.BorderThickness.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("border", d.type.GetName(), d.name))),

        "Padding" => definitions.ThicknessLarge.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("p", d.type.GetName(), d.name))),

        "Margin" => definitions.ThicknessLarge.Select(d =>
          CreateStyle(controlType, property, d.thickness, getClassName("m", d.type.GetName(), d.name))),

        "BorderBrush" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName("border", d.name, $"{d.value}"))),

        "Background" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName("bg", d.name, $"{d.value}"))),

        "Foreground" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName("text", $"{d.name}", $"{d.value}"))),

        "Fill" => definitions.Brush.Select(d =>
          CreateStyle(controlType, property, d.brush, getClassName(d.name, $"{d.value}"))),

        "FontSize" => definitions.FontSize.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"text", d.name))),

        "Spacing" => definitions.Spacing.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"s", d.name))),

        "Width" => definitions.Width.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"w", d.name))),

        "Height" => definitions.Height.Select(d =>
          CreateStyle(controlType, property, d.value, getClassName($"h", d.name))),

        "CornerRadius" => definitions.CornerRadius.Select(d =>
          CreateStyle(controlType, property, d.cornerRadius, getClassName($"rounded", d.name))),

        "HorizontalAlignment" => EnumEx.GetValues<HorizontalAlignment>().Select(alignment =>
          CreateStyle(controlType, property, alignment, getClassName("align", "h", alignment.ToString()))),

        "VerticalAlignment" => EnumEx.GetValues<VerticalAlignment>().Select(alignment =>
          CreateStyle(controlType, property, alignment, getClassName("align", "v", alignment.ToString()))),

        "FontWeight" => definitions.FontWeight.Select(d =>
          CreateStyle(controlType, property, d.weight, getClassName("font", d.name))),

       _ => new Style[0],
      };
    }

    public static IEnumerable<Style> CreateStyles(
      IStyleDefinitions definitions,
      IEnumerable<Type> controlTypes,
      ClassNamingStrategy namingStrategy)
    {
      foreach (var controlProperty in AvaloniaControlHelper.GetAvaloniaControlProperties(controlTypes))
        foreach (var style in CreateStyles(controlProperty.controlType, controlProperty.property, definitions, namingStrategy))
          yield return style;
    }
  }
}
