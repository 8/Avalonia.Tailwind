using System;
using System.Linq;

using Xunit;
using Xunit.Abstractions;

using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Tailwind.Styles;
using Avalonia.Tailwind.Controls;
using Avalonia.Styling;

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
      InlineData(typeof(Button)),
    ]
    public void StylesTest_CreateStyles(Type type)
    {
      var styleDefinitions = new DefaultStyleDefinitionProvider().Definitions;
      var types = new Type[] { type };
      var styles = StyleUtils.CreateStyles(styleDefinitions, types, ClassNamingStrategy.Underscore).ToArray();

      //this.output.Dump(styles);
      foreach (var style in styles)
        this.output.Dump(style);
    }

    [Fact]
    public void StylesTest_CreateAllStyles()
    {
      var styleDefinitions = new DefaultStyleDefinitionProvider().Definitions;
      var types = AvaloniaControlHelper.GetAvaloniaControls();
      var styles = StyleUtils.CreateStyles(styleDefinitions, types, ClassNamingStrategy.Underscore).ToArray();

      this.output.Dump($"Number of Styles: {styles.Length}");
    }

    [Fact]
    public void StylesTest_Ctor()
    {
      //  var style = new Style(x => x.Class("large"));
      //  style.Setters.Add(new Setter(Border.CornerRadiusProperty, 4));

      //new Style(x => x.Class("large"));
      //new Style(x => x.Class(":focus"));
      //new Style(x => x.OfType<Button>().Class("large"));
      //new Style(x => x.OfType<Button>().Class("large").Class(":focus"));
    }

  }
}
