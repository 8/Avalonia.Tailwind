﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Avalonia.Controls;

namespace Avalonia.Tailwind
{
  public static class AvaloniaControlHelper
  {
    public static IEnumerable<Type> GetAvaloniaControls(Assembly assembly)
      => assembly
        .GetTypes()
        .Where(t => t.IsSubclassOf(typeof(Control)))
        .Where(t => !t.IsAbstract);

    public static IEnumerable<Type> GetAvaloniaControls(Assembly[] assemblies = null)
    {
      var a = (assemblies == null || assemblies.Length == 0)
        ? new Assembly[] { typeof(Control).Assembly }
        : assemblies;

      foreach (var assembly in a)
        foreach (var controlType in GetAvaloniaControls(assembly))
          yield return controlType;
    }
  }

}
