using System;
using Xunit;
using Xunit.Abstractions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;

namespace Avalonia.Tailwind.Test
{
  public class StylesTest
  {
    private readonly ITestOutputHelper output;

    public StylesTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    //[Fact]
    //public void GetRegisteredProperties()
    //{
    //  var properties = AvaloniaPropertyRegistry.Instance.GetRegistered(typeof(Border));

    //  this.output.Dump(properties);
    //}

    [Theory,
      InlineData(typeof(Border)),
      InlineData(typeof(StackPanel)),
      InlineData(typeof(Rectangle)),
      InlineData(typeof(TextBlock)),
    ]
    public void StylesTest_CreateStyles(Type type)
    {
      var styleDefinitions = new DefaultStyleDefinitionProvider().Definitions;
      var types = new Type[] { type };
      var styles = Styles.CreateStyles(styleDefinitions, types, NamingStrategy.Underscore);

      this.output.Dump(styles);
    }

    //[Fact]
    //public void StylesTest_GetProperties()
    //{
    //  var fields = Styles.GetStyledPropertiesFieldInfos(typeof(Button));
    //  foreach (var field in fields)
    //  {
    //    var value = field.GetValue(null);
    //    this.output.Dump(value);
    //  }
    //  this.output.Dump(fields);
    //}

    //[Fact]
    //public void StylesTest_GetStyledProperties()
    //{
    //  var properties = Styles.GetStyledProperties(typeof(TemplatedControl));
    //  this.output.Dump(properties);
    //}

  }
}
