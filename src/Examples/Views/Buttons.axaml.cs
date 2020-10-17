using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Examples.Views
{
  public class Buttons : UserControl
  {
    public Buttons()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
