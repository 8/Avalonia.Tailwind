using FluentAssertions;
using Xunit;

namespace Avalonia.Tailwind.Styles.Test
{
  public class DefaultStyleDefinitionProviderTest
  {
    DefaultStyleDefinitionProvider CreateProvider() => new DefaultStyleDefinitionProvider();

    [Fact]
    public void DefaultDefinitionProvider_Ctor() => CreateProvider();

    [Fact]
    public void DefaultStyleDefinitionProviderTest_Definitions()
    {
      /* arrange */
      var defaultDefinitionProvider = CreateProvider();

      /* act */
      var result = defaultDefinitionProvider.Definitions;

      /* assert */
      result.Should().NotBeNull();
    }
  }
}
