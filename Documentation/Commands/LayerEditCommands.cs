// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LayerEditCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class LayerEditCommands
  {
    private static readonly LayerEditCommand LayerEditableOnCommand;
    private static readonly LayerEditCommand LayerEditableOffCommand;

    static LayerEditCommands()
    {
      LayerEditCommand layerEditCommand1 = new LayerEditCommand(nameof (LayerEditableOn), "On", (InputGestureCollection) null);
      layerEditCommand1.Text = Resources.Command_LayerEditableOn_Label;
      layerEditCommand1.ToolTipText = Resources.Command_LayerEditableOn_ToolTip_Text;
      layerEditCommand1.ToolTipDescription = Resources.Command_LayerEditableOn_ToolTip_Description;
      layerEditCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      layerEditCommand1.Category = Resources.Command_Category_LayerEditCommands;
      LayerEditCommands.LayerEditableOnCommand = layerEditCommand1;
      LayerEditCommand layerEditCommand2 = new LayerEditCommand(nameof (LayerEditableOff), "Off", (InputGestureCollection) null);
      layerEditCommand2.Text = Resources.Command_LayerEditableOff_Label;
      layerEditCommand2.ToolTipText = Resources.Command_LayerEditableOff_ToolTip_Text;
      layerEditCommand2.ToolTipDescription = Resources.Command_LayerEditableOff_ToolTip_Description;
      layerEditCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      layerEditCommand2.Category = Resources.Command_Category_LayerEditCommands;
      LayerEditCommands.LayerEditableOffCommand = layerEditCommand2;
    }

    public static MapInfoCommand LayerEditableOn
    {
      get
      {
        return (MapInfoCommand) LayerEditCommands.LayerEditableOnCommand;
      }
    }

    public static MapInfoCommand LayerEditableOff
    {
      get
      {
        return (MapInfoCommand) LayerEditCommands.LayerEditableOffCommand;
      }
    }
  }
}
