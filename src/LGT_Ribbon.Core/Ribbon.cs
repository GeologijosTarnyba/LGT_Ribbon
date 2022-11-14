using System.Linq;
using MapInfo.Types;
using LGT_Ribbon.Core;

namespace LGT_Ribbon.Core
{
  public class Ribbon
  {
    #region Constructors
    public Ribbon() : base()
    {

    }
    public Ribbon(string proText, Tab[] tabs, Button[] backstage)
    {
      this.ProText = proText;
      this.Tabs = tabs;
      this.Backstage = backstage;
    }
    #endregion

    #region Private
    private bool created = false;
    #endregion
    #region Public
    public IMapInfoPro MapInfoApplication { get; private set; }
    public int _id { get; set; } // Reikalingas LiteDB failo sukūrimui
    public Tab[] Tabs { get; set; } = new Tab[] { };
    public Button[] Backstage { get; set; } = new Button[] { };
    public Button[] MapMiniToolBar { get; set; } = new Button[] { };
    public Button[] LayoutMiniToolBar { get; set; } = new Button[] { };
    public string OldProText { get; private set; }
    public string ProText { get; set; }

    public void Create(IMapInfoPro mapInfoApplication)
    {
      if (this.created)
        return;

      this.created = true;
      this.MapInfoApplication = mapInfoApplication;

      this.OldProText = MapInfoApplication.BackStage.Caption;
      this.MapInfoApplication.BackStage.Caption = ProText;

      // Create tabs and their children.
      foreach (var tab in Tabs)
      {
        var newTab = tab.Create(MapInfoApplication.Ribbon.Tabs);
        if (!tab.Visible) {
          newTab.Visible = false;
        }
      }

      // Create backstage items.
      foreach (var backstageTabs in Backstage)
      {
        backstageTabs.Create(MapInfoApplication.BackStage);
      }
      foreach (var item in MapMiniToolBar) {
        item.Create(MapInfoApplication.ContextMenus.MapMiniToolBar);
      }
      foreach (var item in LayoutMiniToolBar) {
        item.Create(mapInfoApplication.ContextMenus.LayoutMiniToolBar);
      }
    }
    public void Unload()
    {
      if (!this.created)
        return;
      foreach (var tab in Tabs)
      {
        tab.Unload(MapInfoApplication.Ribbon.Tabs);
      }
      foreach (var backTab in Backstage)
      {
        backTab.Unload(MapInfoApplication.BackStage.Controls);
      }
      MapInfoApplication.BackStage.Caption = OldProText;
      this.created = false;
      MapInfoApplication = null;
    }

    #endregion
  }
}
