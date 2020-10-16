using System;
using Avalonia.Controls;
using Avalonia.Styling;

namespace Avalonia.Tailwind
{
  public class ConsolidateSetter : ISetter
  {
    readonly Setter internalSetter;

    public AvaloniaProperty Property { get; set; }

    public object Value { get; set; }

    public ConsolidateSetter()
      => this.internalSetter = new Setter();
    public ConsolidateSetter(AvaloniaProperty property, object value)
      : this()
    {
      this.Property = property;
      this.Value = value;
    }

    static Thickness Merge(IStyleable control, AvaloniaProperty<Thickness> property, Thickness newValue)
    {
      var oldValue = control.GetValue<Thickness>(property);

      return new Thickness
      (
        left:   double.IsNaN(newValue.Left)   ? oldValue.Left   : newValue.Left,
        top:    double.IsNaN(newValue.Top)    ? oldValue.Top    : newValue.Top,
        right:  double.IsNaN(newValue.Right)  ? oldValue.Right  : newValue.Right,
        bottom: double.IsNaN(newValue.Bottom) ? oldValue.Bottom : newValue.Bottom
      );
    }

    static object GetConsolidatedValue(IStyleable control, AvaloniaProperty property, object value)
    {
      return (property, value) switch
      {
        (StyledProperty<Thickness> p, Thickness t) => Merge(control, p, t),
        _ => value,
      };
    }

    ISetter GetSetter(IStyleable control)
    {
      var setter = this.internalSetter;
      setter.Value = GetConsolidatedValue(control, this.Property, this.Value);
      setter.Property = this.Property;
      return setter;
    }

    public IDisposable Apply(IStyle style, IStyleable control, IObservable<bool> activator)
    {
      var setter = GetSetter(control);
      return setter.Apply(style, control, activator);
    }
  }
}
