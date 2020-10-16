using Avalonia.Tailwind.Colors;

namespace Avalonia.Tailwind.Styles
{
  public class DefaultStyleDefinitionProvider
  {
    public StyleDefinitions Definitions { get; }

    public DefaultStyleDefinitionProvider()
    {
      this.Definitions = new StyleDefinitions(
        thicknessSmall: ThicknessDefinitions.Create(Scales.SmallScaleInt, ThicknessDefinitions.GetThicknessTypes()),
        thicknessLarge: ThicknessDefinitions.Create(Scales.LargeScaleInt, ThicknessDefinitions.GetThicknessTypes()),
        brush: BrushDefinitions.Create(new DefaultColorPaletteDefinitionProvider().ColorDefinitions),
        size: StyleDefinitionHelpers.CreateSizeDefinitions(Sizes.SizeValues),
        value: StyleDefinitionHelpers.CreateValueDefinitions(Scales.LargeScaleDouble),
        cornerRadius: CornerRadiusDefinitions.CreateCornerRadiusDefinitions(Scales.SmallScaleDouble)
      );
    }
  }
}
