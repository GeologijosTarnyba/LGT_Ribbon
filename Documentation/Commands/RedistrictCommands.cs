// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.RedistrictCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class RedistrictCommands
  {
    private static readonly MapInfoCommand AssignCommand;
    private static readonly MapInfoCommand TargetCommand;
    private static readonly MapInfoCommand AddCommand;
    private static readonly MapInfoCommand DeleteCommand;
    private static readonly MapInfoCommand OptionsCommand;

    static RedistrictCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(705, nameof (Assign), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_Assign_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterAssign_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterAssign_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_Assign_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_Assign_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveRedistricterWindow;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_RedistrictCommands;
      RedistrictCommands.AssignCommand = (MapInfoCommand) basicRunMenuCommand1;
      RedistrictCommands.AssignCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(706, nameof (Target), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_Target_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterSetTarget_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterSetTarget_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_Target_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_Target_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveRedistricterWindow;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_RedistrictCommands;
      RedistrictCommands.TargetCommand = (MapInfoCommand) basicRunMenuCommand2;
      RedistrictCommands.TargetCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(707, nameof (Add), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_Add_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterAdd_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterAdd_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_Add_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_Add_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveRedistricterWindow;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_RedistrictCommands;
      RedistrictCommands.AddCommand = (MapInfoCommand) basicRunMenuCommand3;
      RedistrictCommands.AddCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(708, nameof (Delete), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_Delete_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterDelete_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterDelete_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_Delete_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_Delete_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveRedistricterWindow;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_RedistrictCommands;
      RedistrictCommands.DeleteCommand = (MapInfoCommand) basicRunMenuCommand4;
      RedistrictCommands.DeleteCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(709, "RedistricterOptions", (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_RedistricterOptions_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterOptions_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redistricterOptions_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_RedistricterOptions_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_RedistricterOptions_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveRedistricterWindow;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_RedistrictCommands;
      RedistrictCommands.OptionsCommand = (MapInfoCommand) basicRunMenuCommand5;
      RedistrictCommands.OptionsCommand.CreateScreenTip();
    }

    public static MapInfoCommand Assign
    {
      get
      {
        return RedistrictCommands.AssignCommand;
      }
    }

    public static MapInfoCommand Target
    {
      get
      {
        return RedistrictCommands.TargetCommand;
      }
    }

    public static MapInfoCommand Add
    {
      get
      {
        return RedistrictCommands.AddCommand;
      }
    }

    public static MapInfoCommand Delete
    {
      get
      {
        return RedistrictCommands.DeleteCommand;
      }
    }

    public static MapInfoCommand Options
    {
      get
      {
        return RedistrictCommands.OptionsCommand;
      }
    }
  }
}
