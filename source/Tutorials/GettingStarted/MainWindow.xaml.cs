using System.Collections.Generic;
using System.Linq;
using Zaaml.UI.Controls.ListView;

namespace GettingStarted
{
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    public List<string> ListData { get; } = new List<string>(Enumerable.Range(0, 1000).Select(i => $"List Item {i}"));
  }

  public sealed class ListViewFilter : ListViewItemTextFilter<string>
  {
    protected override bool Pass(string item)
    {
      return item.Contains(FilterText);
    }
  }
}