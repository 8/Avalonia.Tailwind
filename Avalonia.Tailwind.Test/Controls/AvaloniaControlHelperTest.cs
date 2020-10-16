using System;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using Avalonia.Controls;

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
  }
}
