using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using Avalonia.Controls;

namespace Avalonia.Tailwind.Controls
{
  public static class PseudoClassHelper
  {
    public static IDictionary<Type, ImmutableArray<string>> GetPseudoClassesPerType()
      => new Dictionary<Type, ImmutableArray<string>>
      {
        { typeof(Button), new [] { ":pressed" }.ToImmutableArray() },
      };
  }
}
