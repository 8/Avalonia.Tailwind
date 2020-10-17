using System;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using Avalonia.Controls;
using System.Linq;

namespace Avalonia.Tailwind.Controls.Test
{
  public class AvaloniaControlHelperTest
  {
    private readonly ITestOutputHelper output;

    public AvaloniaControlHelperTest(ITestOutputHelper testOutputHelper)
    {
      this.output = testOutputHelper;
    }

    [Fact]
    public void AvaloniaControlHelperTest_GetAvaloniaControls()
    {
      /* act & arrange */
      var types = AvaloniaControlHelper.GetAvaloniaControls();
      this.output.Dump(types);

      /* assert */
      types.Should().NotBeNullOrEmpty();
    }

    [Theory,
      InlineData(typeof(Button)),
      InlineData(typeof(Border)),
      InlineData(typeof(Grid)),
      InlineData(typeof(UserControl)),
      InlineData(typeof(ContentControl)),
    ]
    public void AvaloniaControlHelperTest_GetAvaloniaControls_Contain_Type(Type type)
    {
      /* act */
      var types = AvaloniaControlHelper.GetAvaloniaControls();

      /* assert */
      types.Should().Contain(type);
    }

    [Fact]
    public void AvaloniaControlHelperTest_GetAvaloniaControlProperties()
    {
      var controlProperties = AvaloniaControlHelper.GetAvaloniaControlProperties(new[] { typeof(Control) }).ToArray();
      var buttonProperties = AvaloniaControlHelper.GetAvaloniaControlProperties(new[] { typeof(Button) }).ToArray();
      var controlAndButtonProperties = AvaloniaControlHelper.GetAvaloniaControlProperties(new[] { typeof(Control), typeof(Button) }).ToArray();

      this.output.Dump($"controlProperties.Length: { controlProperties.Length }");
      this.output.Dump($"buttonProperties.Length: { buttonProperties.Length }");
      this.output.Dump($"control and button Properties.Length: { controlAndButtonProperties.Length }");
    }

    [Fact]
    public void AvaloniaControlHelperTest_GetAvaloniaControlPropertiesFiltered()
    {
      var controlProperties = AvaloniaControlHelper.GetAvaloniaControlPropertiesFiltered(new[] { typeof(Control) }).ToArray();
      var buttonProperties = AvaloniaControlHelper.GetAvaloniaControlPropertiesFiltered(new[] { typeof(Button) }).ToArray();
      var controlAndButtonProperties = AvaloniaControlHelper.GetAvaloniaControlPropertiesFiltered(new[] { typeof(Control), typeof(Button) }).ToArray();

      this.output.Dump($"controlProperties.Length: { controlProperties.Length }");
      this.output.Dump($"buttonProperties.Length: { buttonProperties.Length }");
      this.output.Dump($"control and button Properties.Length: { controlAndButtonProperties.Length }");
    }
  }
}
