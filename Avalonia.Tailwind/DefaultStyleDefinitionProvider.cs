using System.Net;

namespace Avalonia.Tailwind
{
  public class DefaultStyleDefinitionProvider
  {
    public StyleDefinitions Definitions { get; }

    public DefaultStyleDefinitionProvider()
    {
      this.Definitions = new StyleDefinitions(
        thicknessSmall: StyleDefinitionHelpers.CreateThicknessDefinitions(Scales.SmallScaleInt, StyleDefinitionHelpers.GetThicknessTypes()),
        thicknessLarge: StyleDefinitionHelpers.CreateThicknessDefinitions(Scales.LargeScaleInt, StyleDefinitionHelpers.GetThicknessTypes()),
        brush: StyleDefinitionHelpers.CreateBrushDefinitions(new DefaultColorDefinitionProvider().ColorDefinitions),
        size: StyleDefinitionHelpers.CreateSizeDefinitions(Sizes.SizeValues),
        value: StyleDefinitionHelpers.CreateValueDefinitions(Scales.LargeScaleDouble),
        cornerRadius: StyleDefinitionHelpers.CreateCornerRadiusDefinitions(Scales.SmallScaleDouble)
      );
    }
  }
}
