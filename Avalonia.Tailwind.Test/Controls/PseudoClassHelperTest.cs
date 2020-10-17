using System;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

using Avalonia.Controls;
using Avalonia.Tailwind.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace Avalonia.Tailwind.Test.Controls
{
  public class PseudoClassHelperTest
  {
    private readonly ITestOutputHelper output;

    public PseudoClassHelperTest(ITestOutputHelper output)
    {
      this.output = output;
    }

    [Theory,
      InlineData(typeof(Button)),
      InlineData(typeof(ToggleButton)),
      InlineData(typeof(InputElement)),
      InlineData(typeof(ItemsControl)),
    ]
    public void PseudoClassHelperTest_GetPseudoClasses(Type t)
    {
      /* act */
      var pseudoClasses = PseudoClassHelper.GetPseudoClasses(t);

      /* assert */
      pseudoClasses.Should().NotBeNull();
      this.output.Dump(pseudoClasses);
    }

    [Fact]
    public void PseudoClassHelperTest_GetPseudoClassesRecursive()
    {
      var pseudoClasses = PseudoClassHelper.GetPseudoClassesRecursive(typeof(Button));

      this.output.Dump(pseudoClasses);
    }
  }
}
