using MapInfo.Types;

namespace LGT_Ribbon.Core
{
  public class TabGroup : CaptionedControl
  {
    #region Constructors
    public TabGroup()
    {

    }
    public TabGroup(string name, string caption)
    {
      Name = name;
      Caption = caption;
    }
    #endregion

    #region Public Properties
    public IRibbonControlGroup Control { get; set; }
    public bool IsLauncherVisible { get; set; } = false;
    public Button[] Controls { get; set; } = new Button[] { };
    public bool Ignore { get; set; } = false;
    #endregion

    #region Public Methods
    public void Create(IRibbonTab tab)
    {
      if (Ignore)
        return;
      Control = tab.Groups.Add(Name, Caption);
      Control.IsLauncherVisible = IsLauncherVisible;
      foreach (var child in Controls)
      {
        child.Create(Control, this.Name);
      }
    }
    #endregion
  }
}
