using MapInfo.Types;
using System.Linq;

namespace LGT_Ribbon.Core
{
  public class Tab
  {
    #region Constructors
    public Tab() { }
    /// <summary>
    /// Ribbon interfeiso tabo konstruktorius.
    /// </summary>
    /// <param name="name">paslėptas elemento vardas</param>
    /// <param name="caption">matomas elemento tekstas</param>
    public Tab(string name, string caption)
    {
      Name = name;
      Caption = caption;
    }
    #endregion

    #region Public Properties
    public IRibbonTab Control { get; private set; }
    /// <summary>
    /// Kažkas panašaus į elemento id, bet mapinfo jį vadina Name, tai ir mes vadiname Name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Elemento matomas tekstas
    /// </summary>
    public string Caption { get; set; }
    /// <summary>
    /// Nustato ar elementas bus sukurtas
    /// </summary>
    public bool Ignore { get; set; } = false;
    /// <summary>
    /// Nustato ar elementas po sukūrimo bus paslėptas
    /// </summary>
    public bool Visible { get; set; } = true;
    /// <summary>
    /// Nustato ar elementas po sukūrimo bus aktyvuotas.
    /// </summary>
    public bool IsSelected { get; set; } = false;
    /// <summary>
    /// Nustato elemento eilės tvarką sekoje. Prasideda nuo 0.
    /// </summary>
    public int? Index { get; set; }
    /// <summary>
    /// Elemento "Vaikai" - TabGroups tipo elementai.
    /// </summary>
    public TabGroup[] Groups { get; set; } = new TabGroup[] { };
    #endregion

    #region Methods
    public void HideInvisible()
    {
      if (Control != null)
        Control.Visible = this.Visible;
    }
    public IRibbonTab Create(IRibbonTabCollection ribbonTabs)
    {
      if (this.Ignore)
        return null;

      // if tab with this name already exists, append to it
      Control = ribbonTabs.FirstOrDefault(tab => tab.Name == this.Name);
      if (Control == null)
      {
        Control =
        ribbonTabs.Count > this.Index && this.Index != null
        ? ribbonTabs.Insert((int)this.Index, this.Name, this.Caption)
        : ribbonTabs.Add(this.Name, this.Caption)
        ;
      }

      if (Groups.Length > 0)
      {
        foreach (var child in Groups)
        {
          child.Create(Control);
        }
      }
      if (this.IsSelected && this.Visible)
        Control.IsSelected = true;

      return Control;
    }
    public void Unload(IRibbonTabCollection ribbonTabs)
    {
      if (Control != null)
        ribbonTabs.Remove(Control);
    }
    #endregion
  }
}
