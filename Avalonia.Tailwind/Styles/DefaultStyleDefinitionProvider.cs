using Avalonia.Layout;
using Avalonia.Tailwind.Colors;
using Avalonia.Tailwind.Controls;
using System.Linq;

namespace Avalonia.Tailwind.Styles
{
  public class DefaultStyleDefinitionProvider
  {
    public StyleDefinitions Definitions { get; }

    public DefaultStyleDefinitionProvider()
    {
      this.Definitions = new StyleDefinitions(
        borderThickness: ThicknessDefinitions.Create(Scales.SmallScaleInt, ThicknessDefinitions.GetThicknessTypes()),
        thicknessLarge: ThicknessDefinitions.Create(Scales.LargeScaleInt, ThicknessDefinitions.GetThicknessTypes()),
        brush: BrushDefinitions.Create(new DefaultColorPaletteDefinitionProvider().ColorDefinitions),
        fontSize: FontSizes.Create(FontSizes.CreateValues()),
        spacing: Values.Create(Scales.LargeScaleDouble),
        width: Values.Create(Scales.LargeScaleDouble),
        height: Values.Create(Scales.LargeScaleDouble),
        cornerRadius: CornerRadiusDefinitions.CreateCornerRadiusDefinitions(Scales.SmallScaleDouble),
        fontWeight: FontWeightDefinitions.Create(),
        horizontalAlignment: EnumEx.GetValues<HorizontalAlignment>().Select(alignment => (name: alignment.ToString(), alignment)),
        verticalAlignment: EnumEx.GetValues<VerticalAlignment>().Select(alignment => (name: alignment.ToString(), alignment)),
        pseudoClasses: PseudoClassHelper.GetAllPseudoClasses()
      );
    }
  }
}
