using LGT_Ribbon.Core;
using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LGT_Ribbon
{
  public static class MB
  {
    public static void AddMapToLayout(IMapInfoPro MapInfoApplication, int? layoutWindowID = null, int? mapWindowID = null, 
      string xy1 = "(0,0)", string xy2 = "(10,10)",
      string units = "cm"
    ){
      layoutWindowID ??= MapInfoApplication.Windows.OrderByDescending(item => item.ActivatedTime).FirstOrDefault(item => item.WindowGroup == "Layouts")?.WindowId;
      mapWindowID ??= MapInfoApplication.Windows.OrderByDescending(item => item.ActivatedTime).FirstOrDefault(item => item.WindowGroup == "Maps")?.WindowId;
      if (layoutWindowID != null && mapWindowID != null) {
        MapInfoApplication.RunMapBasicCommand(
          $"Set CoordSys Layout Units \"{units}\"\n" +
          $"Create Frame " +
          $"Into Window {layoutWindowID} " +
          $"{xy1} {xy2} " +
          $"FillFrame On " +
          $"From Window {mapWindowID} "
        );
      }
    }
    public static void RunMapBasicCommand(IMapInfoPro MapInfoApplication, string command)
    {
      try {
        if (PC.Is(UserLevel.Admin)) {
          MessageBox.Show(command, "Admin only");
        }
        MapInfoApplication.RunMapBasicCommand(command);
      } catch (MapBasicException e) {
        MessageBox.Show(e.Message);
      }
    }

  }
}
