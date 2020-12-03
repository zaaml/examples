using Zaaml.PresentationCore.Theming;
using Zaaml.Theming;

namespace GettingStarted
{
  public partial class App
  {
    public App()
    {
      // Enable Metro Office theme
      ThemeManager.ApplicationTheme = Themes.MetroOffice;
    }
  }
}