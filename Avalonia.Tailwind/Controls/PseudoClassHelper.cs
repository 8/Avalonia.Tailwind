using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

using Avalonia.Controls;
using Avalonia.Input;

namespace Avalonia.Tailwind.Controls
{
  public static class PseudoClassHelper
  {
    public static IEnumerable<string> GetPseudoClasses(Type type)
      => type switch
      {
        Type o when o == typeof(InputElement) => new[] { ":disabled", ":focus", ":focus-visible", ":pointerover" },
        Type o when o == typeof(Button) => new[] { ":pressed" },
        Type o when o == typeof(TabItem) => new[] {":pressed", ":selected" },
        //Type o when o == typeof(ToggleButton) => new[] { ":checked", ":unchecked", ":indeterminate" },
        //Type o when o == typeof(ItemsControl) => new[] { ":empty", ":singleitem" },
        _ => new string[0],
      };

    public static IEnumerable<string> GetPseudoClassesRecursive(Type type) 
      => type == null
        ? new string[0]
        : GetPseudoClasses(type).Union(GetPseudoClassesRecursive(type.BaseType));

    public static IEnumerable<string> GetAllPseudoClasses(IEnumerable<Type> types = null)
      => (types ?? AvaloniaControlHelper.GetAvaloniaControls()).SelectMany(t => GetPseudoClassesRecursive(t)).Distinct();
  }
}
