using Avalonia.Media;
using System.Collections.Generic;
using System.Linq;

namespace Avalonia.Tailwind.Styles
{
  public static class FontWeightDefinitions
  {
    //static readonly string[] WeightNames = new[]
    //{
    //  "hairline",
    //  "thin",
    //  "light",
    //  "normal",
    //  "medium",
    //  "semibold",
    //  "bold",
    //  "extrabold",
    //  "black",
    //};

    //static string GetWeightName(int index) => WeightNames[index];

    public static IEnumerable<(string name, FontWeight weight)> Create(IEnumerable<FontWeight> values = null)
      => (values ?? EnumEx.GetValues<FontWeight>()).Select((value, i) => (name: value.ToString(), weight: value));
  }
}
