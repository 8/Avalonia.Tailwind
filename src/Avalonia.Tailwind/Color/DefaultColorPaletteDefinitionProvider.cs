namespace Avalonia.Tailwind.Colors
{
  public class DefaultColorPaletteDefinitionProvider : ColorPaletteDefinitionProvider
  {
    public DefaultColorPaletteDefinitionProvider()
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
