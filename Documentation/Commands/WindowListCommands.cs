// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.WindowListCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class WindowListCommands
  {
    public static MapInfoCommand SelectAllOfType { get; private set; }

    public static MapInfoCommand HideSelectedWindow { get; private set; }

    public static MapInfoCommand ActivateSelectedWindow { get; private set; }

    public static MapInfoCommand CloseSelectedWindow { get; private set; }

    public static MapInfoCommand RenameSelectedWindow { get; private set; }

    public static MapInfoCommand CloneSelectedWindow { get; private set; }

    static WindowListCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(3001, nameof (SelectAllOfType), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_SelectAllOfType_Label;
      basicRunMenuCommand1.SmallIcon = (string) null;
      basicRunMenuCommand1.LargeIcon = (string) null;
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_SelectAllOfType_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_SelectAllOfType_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.SelectAllOfType = (MapInfoCommand) basicRunMenuCommand1;
      WindowListCommands.SelectAllOfType.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(3002, nameof (HideSelectedWindow), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_HideSelectedWindow_Label;
      basicRunMenuCommand2.SmallIcon = (string) null;
      basicRunMenuCommand2.LargeIcon = (string) null;
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_HideSelectedWindow_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_HideSelectedWindow_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.HideSelectedWindow = (MapInfoCommand) basicRunMenuCommand2;
      WindowListCommands.HideSelectedWindow.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(3003, nameof (ActivateSelectedWindow), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_ActivateSelectedWindow_Label;
      basicRunMenuCommand3.SmallIcon = (string) null;
      basicRunMenuCommand3.LargeIcon = (string) null;
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_ActivateSelectedWindow_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_ActivateSelectedWindow_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.ActivateSelectedWindow = (MapInfoCommand) basicRunMenuCommand3;
      WindowListCommands.ActivateSelectedWindow.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(3004, nameof (CloseSelectedWindow), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_CloseSelectedWindow_Label;
      basicRunMenuCommand4.SmallIcon = (string) null;
      basicRunMenuCommand4.LargeIcon = (string) null;
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_CloseSelectedWindow_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_CloseSelectedWindow_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand4.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.CloseSelectedWindow = (MapInfoCommand) basicRunMenuCommand4;
      WindowListCommands.CloseSelectedWindow.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(3005, nameof (RenameSelectedWindow), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_RenameSelectedWindow_Label;
      basicRunMenuCommand5.SmallIcon = (string) null;
      basicRunMenuCommand5.LargeIcon = (string) null;
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_RenameSelectedWindow_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_RenameSelectedWindow_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand5.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.RenameSelectedWindow = (MapInfoCommand) basicRunMenuCommand5;
      WindowListCommands.RenameSelectedWindow.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(3006, nameof (CloneSelectedWindow), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_CloneSelectedWindow_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/CloneMap_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/CloneMap_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_CloneSelectedWindow_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_CloneSelectedWindow_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand6.Category = Resources.Command_Category_WindowListCommands;
      WindowListCommands.CloneSelectedWindow = (MapInfoCommand) basicRunMenuCommand6;
      WindowListCommands.CloneSelectedWindow.CreateScreenTip();
    }
  }
}
