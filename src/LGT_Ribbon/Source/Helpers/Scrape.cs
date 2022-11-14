using MapInfo.Types;
using System.Linq;
using System.Windows;

namespace LGT_Ribbon
{
  //public static class Scrape
  //{
  //  public static void Tab(IRibbonTab tab, int skipGroups = 0)
  //  {
  //    //MessageBox.Show(tab.Caption);
  //    //if (tab.Groups.Count() == 1)
  //    //  MessageBox.Show("Pridėkite papildomą grupę į šį TAB'a");
  //    if (tab.Groups.Count - skipGroups > 0) {
  //      Clipboard.SetText(string.Empty); // Empty out clipboard.
  //    }
  //    string asd = string.Empty;
  //    foreach (var group in tab.Groups.Skip(skipGroups))
  //    {
  //      asd += RibbonControlGroup(group);
  //    }
  //    Clipboard.SetText(asd);
  //  }
  //  public static string RibbonControlGroup(IRibbonControlGroup group, int skipControls = 0)
  //  {
  //    //MessageBox.Show(group.Caption);
  //    string result = $"new TabGroup(\"asd_{group.Name}\", \"{group.Name}\") {{" +
  //     "Controls = new Button[] {";
  //    foreach (var control in group.Controls.Skip(skipControls))
  //    {
  //      result += Control(control);
  //    }
  //    result += "}" + "\n}";
  //    return result;
      
  //  }
  //  public static string Control(IMapInfoControl control) {
  //    string result = string.Empty;
  //    if (control is ICommandControl commandControl)
  //    {
  //      result = $"new Button({commandControl.CommandId}, ";
  //      if (control is IMapInfoControl ctrl)
  //      {
  //        result += $"ControlType.{ctrl.ControlType}), // {ctrl.Caption}\n";
  //      }
  //      if (MessageBox.Show("Pridėti prie nukopijuotų ?\n" + result, "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
  //      {
  //        Clipboard.SetText(Clipboard.GetText() + "\n" + result);
  //      }
  //    }
  //    return result;
  //  }
  //}
}