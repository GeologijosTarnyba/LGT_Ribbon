// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.EditCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class EditCommands
  {
    private static readonly MapBasicRunMenuCommand UndoCommand;
    private static readonly MapBasicRunMenuCommand CutCommand;
    private static readonly MapBasicRunMenuCommand CopyCommand;
    private static readonly MapBasicRunMenuCommand PasteCommand;
    private static readonly MapBasicRunMenuCommand ClearMapObjectsCommand;
    private static readonly MapBasicRunMenuCommand GetInfoCommand;

    static EditCommands()
    {
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand1 = new SelectiveRequeryRunMenuCommand(201, nameof (Undo), MapInfoCommand.GetGesture(Resources.Command_Undo_KeyGesture));
      requeryRunMenuCommand1.Text = Resources.Command_Undo_Label;
      requeryRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/undo_16x16.png";
      requeryRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/undo_32x32.png";
      requeryRunMenuCommand1.ToolTipDescription = Resources.Command_Undo_ToolTip_Description;
      requeryRunMenuCommand1.ToolTipText = Resources.Command_Undo_ToolTip_Text;
      requeryRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedEdits;
      requeryRunMenuCommand1.EnableCommand = false;
      requeryRunMenuCommand1.Category = Resources.Command_Category_EditCommands;
      EditCommands.UndoCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand1;
      EditCommands.UndoCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand2 = new SelectiveRequeryRunMenuCommand(202, nameof (Cut), MapInfoCommand.GetGesture(Resources.Command_Cut_KeyGesture));
      requeryRunMenuCommand2.Text = Resources.Command_Cut_Label;
      requeryRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/cut_16x16.png";
      requeryRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/cut_32x32.png";
      requeryRunMenuCommand2.ToolTipDescription = Resources.Command_Cut_ToolTip_Description;
      requeryRunMenuCommand2.ToolTipText = Resources.Command_Cut_ToolTip_Text;
      requeryRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      requeryRunMenuCommand2.EnableCommand = false;
      requeryRunMenuCommand2.Category = Resources.Command_Category_EditCommands;
      EditCommands.CutCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand2;
      EditCommands.CutCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand3 = new SelectiveRequeryRunMenuCommand(203, nameof (Copy), MapInfoCommand.GetGesture(Resources.Command_Copy_KeyGesture));
      requeryRunMenuCommand3.Text = Resources.Command_Copy_Label;
      requeryRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/copy_16x16.png";
      requeryRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/copy_32x32.png";
      requeryRunMenuCommand3.ToolTipDescription = Resources.Command_Copy_ToolTip_Description;
      requeryRunMenuCommand3.ToolTipText = Resources.Command_Copy_ToolTip_Text;
      requeryRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      requeryRunMenuCommand3.EnableCommand = false;
      requeryRunMenuCommand3.Category = Resources.Command_Category_EditCommands;
      EditCommands.CopyCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand3;
      EditCommands.CopyCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand4 = new SelectiveRequeryRunMenuCommand(204, nameof (Paste), MapInfoCommand.GetGesture(Resources.Command_Paste_KeyGesture));
      requeryRunMenuCommand4.Text = Resources.Command_Paste_Label;
      requeryRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/paste_16x16.png";
      requeryRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/paste_32x32.png";
      requeryRunMenuCommand4.ToolTipDescription = Resources.Command_Paste_ToolTip_Description;
      requeryRunMenuCommand4.ToolTipText = Resources.Command_Paste_ToolTip_Text;
      requeryRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedClipboardContent;
      requeryRunMenuCommand4.EnableCommand = false;
      requeryRunMenuCommand4.Category = Resources.Command_Category_EditCommands;
      EditCommands.PasteCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand4;
      EditCommands.PasteCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(206, nameof (ClearMapObjects), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_ClearMapObjects_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearMapObjects_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearMapObjects_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_ClearMapObjects_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_ClearMapObjects_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_ClearMapObjects;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_EditCommands;
      EditCommands.ClearMapObjectsCommand = basicRunMenuCommand1;
      EditCommands.ClearMapObjectsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(207, nameof (GetInfo), MapInfoCommand.GetGesture(Resources.Command_GetInfo_KeyGesture));
      basicRunMenuCommand2.Text = Resources.Command_GetInfo_Label;
      basicRunMenuCommand2.MenuItemText = Resources.Command_GetInfo_MenuText;
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_GetInfo_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_GetInfo_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedMapSelection;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_EditCommands;
      EditCommands.GetInfoCommand = basicRunMenuCommand2;
      EditCommands.GetInfoCommand.CreateScreenTip();
    }

    public static MapInfoCommand Undo
    {
      get
      {
        return (MapInfoCommand) EditCommands.UndoCommand;
      }
    }

    public static MapInfoCommand Cut
    {
      get
      {
        return (MapInfoCommand) EditCommands.CutCommand;
      }
    }

    public static MapInfoCommand Copy
    {
      get
      {
        return (MapInfoCommand) EditCommands.CopyCommand;
      }
    }

    public static MapInfoCommand Paste
    {
      get
      {
        return (MapInfoCommand) EditCommands.PasteCommand;
      }
    }

    public static MapInfoCommand ClearMapObjects
    {
      get
      {
        return (MapInfoCommand) EditCommands.ClearMapObjectsCommand;
      }
    }

    public static MapInfoCommand GetInfo
    {
      get
      {
        return (MapInfoCommand) EditCommands.GetInfoCommand;
      }
    }
  }
}
