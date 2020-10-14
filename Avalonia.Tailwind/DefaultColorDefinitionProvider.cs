namespace Avalonia.Tailwind
{
  public class DefaultColorDefinitionProvider : ColorDefinitionProvider
  {
    public DefaultColorDefinitionProvider()
      :base(new []
      { 
        (nameof(Colors.Gray), Colors.Gray),
        (nameof(Colors.Red), Colors.Red),
        (nameof(Colors.Orange), Colors.Orange),
        (nameof(Colors.Yellow), Colors.Yellow),
        (nameof(Colors.Green), Colors.Green),
        (nameof(Colors.Teal), Colors.Teal),
        (nameof(Colors.Blue), Colors.Blue),
        (nameof(Colors.Indigo), Colors.Indigo),
        (nameof(Colors.Purple), Colors.Purple),
        (nameof(Colors.Pink), Colors.Pink),
      }
      )
    {
    }
  }
}
