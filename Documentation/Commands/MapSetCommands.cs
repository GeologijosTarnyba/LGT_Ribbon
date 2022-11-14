// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.MapSetCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class MapSetCommands
  {
    private static readonly MapSetCommand SetMapDisplayZoomCommand;
    private static readonly MapSetCommand SetMapDisplayScaleCommand;
    private static readonly MapSetCommand SetMapDisplayCartographicCommand;
    private static readonly MapSetCommand SetMapDisplayPositionCommand;

    static MapSetCommands()
    {
      MapSetCommand mapSetCommand1 = new MapSetCommand(nameof (SetMapDisplayZoom), "display Zoom", (InputGestureCollection) null);
      mapSetCommand1.Text = Resources.Command_SetMapDisplayZoom_Label;
      mapSetCommand1.ToolTipText = Resources.Command_SetMapDisplayZoom_ToolTip_Text;
      mapSetCommand1.ToolTipDescription = Resources.Command_SetMapDisplayZoom_ToolTip_Description;
      mapSetCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      mapSetCommand1.Category = Resources.Command_Category_MapDisplayCommands;
      MapSetCommands.SetMapDisplayZoomCommand = mapSetCommand1;
      MapSetCommand mapSetCommand2 = new MapSetCommand(nameof (SetMapDisplayScale), "display Scale", (InputGestureCollection) null);
      mapSetCommand2.Text = Resources.Command_SetMapDisplayScale_Label;
      mapSetCommand2.ToolTipText = Resources.Command_SetMapDisplayScale_ToolTip_Text;
      mapSetCommand2.ToolTipDescription = Resources.Command_SetMapDisplayScale_ToolTip_Description;
      mapSetCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      mapSetCommand2.Category = Resources.Command_Category_MapDisplayCommands;
      MapSetCommands.SetMapDisplayScaleCommand = mapSetCommand2;
      MapSetCommand mapSetCommand3 = new MapSetCommand(nameof (SetMapDisplayCartographic), "display Scale Cartographic", (InputGestureCollection) null);
      mapSetCommand3.Text = Resources.Command_SetMapDisplayCartographic_Label;
      mapSetCommand3.ToolTipText = Resources.Command_SetMapDisplayCartographic_ToolTip_Text;
      mapSetCommand3.ToolTipDescription = Resources.Command_SetMapDisplayCartographic_ToolTip_Description;
      mapSetCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      mapSetCommand3.Category = Resources.Command_Category_MapDisplayCommands;
      MapSetCommands.SetMapDisplayCartographicCommand = mapSetCommand3;
      MapSetCommand mapSetCommand4 = new MapSetCommand(nameof (SetMapDisplayPosition), "display Position", (InputGestureCollection) null);
      mapSetCommand4.Text = Resources.Command_SetMapDisplayPosition_Label;
      mapSetCommand4.ToolTipText = Resources.Command_SetMapDisplayPosition_ToolTip_Text;
      mapSetCommand4.ToolTipDescription = Resources.Command_SetMapDisplayPosition_ToolTip_Description;
      mapSetCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      mapSetCommand4.Category = Resources.Command_Category_MapDisplayCommands;
      MapSetCommands.SetMapDisplayPositionCommand = mapSetCommand4;
    }

    public static MapInfoCommand SetMapDisplayZoom
    {
      get
      {
        return (MapInfoCommand) MapSetCommands.SetMapDisplayZoomCommand;
      }
    }

    public static MapInfoCommand SetMapDisplayScale
    {
      get
      {
        return (MapInfoCommand) MapSetCommands.SetMapDisplayScaleCommand;
      }
    }

    public static MapInfoCommand SetMapDisplayCartographic
    {
      get
      {
        return (MapInfoCommand) MapSetCommands.SetMapDisplayCartographicCommand;
      }
    }

    public static MapInfoCommand SetMapDisplayPosition
    {
      get
      {
        return (MapInfoCommand) MapSetCommands.SetMapDisplayPositionCommand;
      }
    }
  }
}
