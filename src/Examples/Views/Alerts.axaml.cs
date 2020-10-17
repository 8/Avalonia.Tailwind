using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Examples.Views
{
  public class Alerts : UserControl
  {
    public Alerts()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
