using System;
using System.Linq;

using Xunit;
using Xunit.Abstractions;

using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Tailwind.Styles;
using Avalonia.Tailwind.Controls;

namespace Avalonia.Tailwind.Test
{
  public class StylesTest
  {
    private readonly ITestOutputHelper output;

    public StylesTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    [Theory,
      InlineData(typeof(Border)),
      InlineData(typeof(StackPanel)),
      InlineData(typeof(Rectangle)),
      InlineData(typeof(TextBlock)),
      InlineData(typeof(UserControl)),
    ]
    public void StylesTest_CreateStyles(Type type)
    {
      var styleDefinitions = new DefaultStyleDefinitionProvider().Definitions;
      var types = new Type[] { type };
      var styles = StyleUtils.CreateStyles(styleDefinitions, types, ClassNamingStrategy.Underscore).ToArray();

      this.output.Dump(styles);
    }

    [Fact]
    public void StylesTest_CreateAllStyles()
    {
      var styleDefinitions = new DefaultStyleDefinitionProvider().Definitions;
      var types = AvaloniaControlHelper.GetAvaloniaControls();
      var styles = StyleUtils.CreateStyles(styleDefinitions, types, ClassNamingStrategy.Underscore).ToArray();

      this.output.Dump(styles.Length);
    }
  }
}
