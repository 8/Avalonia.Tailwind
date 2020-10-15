namespace Avalonia.Tailwind
{
  public class DefaultColorDefinitionProvider : ColorDefinitionProvider
  {
    public DefaultColorDefinitionProvider()
      :base(new []
      { 
        ColorPalettes.Gray,
        ColorPalettes.Red,
        ColorPalettes.Orange,
        ColorPalettes.Yellow,
        ColorPalettes.Green,
        ColorPalettes.Teal,
        ColorPalettes.Blue,
        ColorPalettes.Indigo,
        ColorPalettes.Purple,
        ColorPalettes.Pink,
      }
      )
    {
    }
  }
}
