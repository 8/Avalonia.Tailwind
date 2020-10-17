using Xunit;
using FluentAssertions;
using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.Tailwind.Test.Styles
{
  public class ConsolidateSetterTest
  {
    ConsolidateSetter CreateSetter()
      => new ConsolidateSetter();

    [Fact]
    public void ConsolidateSetterTest_Ctor() => CreateSetter();

    [Fact]
    public void ConsolidateSetterTest_Property()
    {
      /* arrange */
      var setter = CreateSetter();
      var input = Border.BorderBrushProperty;

      /* act */
      setter.Property = input;
      var result = setter.Property;

      /* assert */
      result.Should().Be(input);
    }

    [Fact]
    public void ConsolidateSetterTest_Value()
    {
      /* arrange */
      var setter = CreateSetter();
      var input = Brushes.White;

      /* act */
      setter.Value = input;
      var result = setter.Value;

      /* assert */
      result.Should().Be(input);
    }

    [Fact]
    public void ConsolidateSetterTest_Nan()
    {
      var nan = double.NaN;

      (nan == double.NaN).Should().BeFalse();

      double.IsNaN(nan).Should().BeTrue();
    }
  }
}
