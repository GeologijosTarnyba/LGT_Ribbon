using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGT_Ribbon.Core
{
  public enum ControlLocation
  {
    Backstage,
    StatusBar,
    LayoutMiniToolBar,
    MapMiniToolBar
  }
  public static class MyExtensions
  {
    public static IControlGroup GetControlGroup(this IMapInfoPro str, ControlLocation controlLocation)
    {
      switch (controlLocation) {
        case ControlLocation.Backstage:
          return str.BackStage;
        case ControlLocation.StatusBar:
          return str.StatusBar;
        case ControlLocation.LayoutMiniToolBar:
          return str.ContextMenus.LayoutMiniToolBar;
        case ControlLocation.MapMiniToolBar:
          return str.ContextMenus.MapMiniToolBar;
        default:
          return null;
      }
    }
  }
}
