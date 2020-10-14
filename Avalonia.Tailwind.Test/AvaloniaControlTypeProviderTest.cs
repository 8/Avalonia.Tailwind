using FluentAssertions;
using Xunit;

namespace Avalonia.Tailwind.Test
{
  public class AvaloniaControlTypeProviderTest
  {
    IAvaloniaControlTypeProvider CreateProvider()
      => new AvaloniaControlTypeProvider();

    [Fact]
    public void AvaloniaControlTypeProviderTest_Ctor() => CreateProvider();

    [Fact]
    public void AvaloniaControlTypeProviderTest_GetAvaloniaControls()
    {
      /* arrange */
      var provider = CreateProvider();

      /* act */
      var result = provider.GetAvaloniaControls();

      /* assert */
      result.Should().NotBeNull().And.NotBeEmpty();
    }
  }
}
