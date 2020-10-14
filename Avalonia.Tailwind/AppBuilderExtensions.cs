using System;
using System.Collections.Generic;
using Avalonia.Tailwind;
using Avalonia.Controls;

namespace Avalonia
{
  public static class AppBuilderExtensions
  {
    public static TAppBuilder UseTailwind<TAppBuilder>(
      this TAppBuilder builder,
      IStyleDefinitions definitions = null,
      IEnumerable<Type> controlTypes = null,
      NamingStrategy namingStrategy = NamingStrategy.Underscore)
      where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
      => builder.AfterSetup(builder =>
        {
          foreach (var style in Styles.CreateStyles(
            definitions ?? new DefaultStyleDefinitionProvider().Definitions,
            controlTypes ?? new AvaloniaControlTypeProvider().GetAvaloniaControls(),
            namingStrategy
          ))
            builder.Instance.Styles.Add(style);
        });
  }
}
