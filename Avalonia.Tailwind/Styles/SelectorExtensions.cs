using Avalonia.Styling;

namespace Avalonia.Tailwind
{
  public static class SelectorExtensions
  {
    public static Selector ClassIfNotNull(this Selector selector, string @class)
      => @class switch
      {
        null => selector,
        string c => selector.Class(c),
      };
  }
}
