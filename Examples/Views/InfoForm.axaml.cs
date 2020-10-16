using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Examples.Views
{
  public class InfoForm : UserControl
  {
    public InfoForm()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
