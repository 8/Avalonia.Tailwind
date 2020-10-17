using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using Avalonia.Styling;
using Avalonia.Tailwind.Controls;
using Avalonia.Tailwind.Styles;

namespace Avalonia.Tailwind
{
  public static class StyleUtils
  {
    static (Style style, int priority) CreateStyle(Type controlType, AvaloniaProperty property, object value, string name, string pseudo = null)
      => (new Style
      {
        Selector = Selectors.Is(null, controlType).Class(name).ClassIfNotNull(pseudo),
        Setters = new List<ISetter> { new ConsolidateSetter(property, value) },
      }, pseudo is null ? 0 : 1);

    static IEnumerable<(Style style, int priority)> CreateStyles(Type controlType, AvaloniaProperty property, object value, string name, IEnumerable<string> pseudoClasses)
    {
      static string GetPseudoClassName(string name, string pseudo)
        => pseudo switch
        {
          string p when p.StartsWith(":") => $"{p[1..]}_{name}",
          string p => $"{p}_{name}",
          _ => name,
        };

      yield return CreateStyle(controlType, property, value, name, null);
      foreach (var pseudo in pseudoClasses)
        yield return CreateStyle(controlType, property, value, GetPseudoClassName(name, pseudo), pseudo);
    }

    static IEnumerable<(Style style, int priority)> CreateStyles(
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

        "BorderBrush" => definitions.Brush.SelectMany(d =>
          CreateStyles(controlType, property, d.brush, getClassName("border", d.name, $"{d.value}"), definitions.PseudoClasses)),

        "Background" => definitions.Brush.SelectMany(d =>
          CreateStyles(controlType, property, d.brush, getClassName("bg", d.name, $"{d.value}"), definitions.PseudoClasses)),

        "Foreground" => definitions.Brush.SelectMany(d =>
          CreateStyles(controlType, property, d.brush, getClassName("text", $"{d.name}", $"{d.value}"), definitions.PseudoClasses)),

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
          CreateStyle(controlType, property, d.cornerRadius, getClassName($"rounded", d.type.GetName(), d.name))),

        "HorizontalAlignment" => definitions.HorizontalAlignment.Select(d =>
          CreateStyle(controlType, property, d.alignment, getClassName("align", "h", d.name))),

        "VerticalAlignment" => definitions.VerticalAlignment.Select(d =>
          CreateStyle(controlType, property, d.alignment, getClassName("align", "v", d.name))),

        "FontWeight" => definitions.FontWeight.Select(d =>
          CreateStyle(controlType, property, d.weight, getClassName("font", d.name))),

       _ => new(Style, int)[0],
      };
    }

    static IEnumerable<(Style style, int priority)> CreateStylesInternal(
      IStyleDefinitions definitions,
      IEnumerable<Type> controlTypes,
      ClassNamingStrategy namingStrategy)
    {
      foreach (var controlProperty in AvaloniaControlHelper.GetAvaloniaControlPropertiesFiltered(controlTypes))
        foreach (var style in CreateStyles(controlProperty.controlType, controlProperty.property, definitions, namingStrategy))
          yield return style;
    }

    public static IEnumerable<Style> CreateStyles(
      IStyleDefinitions definitions,
      IEnumerable<Type> controlTypes,
      ClassNamingStrategy namingStrategy)
    {
      return CreateStylesInternal(definitions, controlTypes, namingStrategy)
        .OrderBy(t => t.priority)
        .Select(t => t.style);
    }
  }
}
