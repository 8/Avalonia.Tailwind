using System;
using System.Collections.Generic;
using System.Reflection;

namespace Avalonia.Tailwind
{
  public interface IAvaloniaControlTypeProvider
  {
    IEnumerable<Type> GetAvaloniaControls();
  }

  public class AvaloniaControlTypeProvider : IAvaloniaControlTypeProvider
  {
    readonly Assembly[] assemblies;

    public AvaloniaControlTypeProvider(params Assembly[] assemblies)
    {
      this.assemblies = assemblies;
    }

    public IEnumerable<Type> GetAvaloniaControls() => AvaloniaControlHelper.GetAvaloniaControls(this.assemblies);
  }

}
