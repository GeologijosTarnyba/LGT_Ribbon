// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LegendCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class LegendCommands
  {
    private static readonly MapInfoCommand AddFramesCommand;
    private static readonly MapInfoCommand AddTextFrameCommand;
    private static readonly MapInfoCommand RemoveFramesCommand;
    private static readonly MapInfoCommand FramePropertiesCommand;
    private static readonly MapInfoCommand ModifyThemeCommand;
    private static readonly MapInfoCommand ToggleGridLinesCommand;
    private static readonly MapInfoCommand SnapToGridCommand;
    private static readonly MapInfoCommand AddHorizontalGuidelineCommand;
    private static readonly MapInfoCommand AddVerticalGuidelineCommand;
    private static readonly MapInfoCommand SnapToTopGuidelineCommand;
    private static readonly MapInfoCommand SnapToBottomGuidelineCommand;
    private static readonly MapInfoCommand SnapToLeftGuidelineCommand;
    private static readonly MapInfoCommand SnapToRightGuidelineCommand;
    private static readonly MapInfoCommand QuickRefreshCommand;
    private static readonly MapInfoCommand RefreshAllCommand;
    private static readonly MapInfoCommand DisableGuidelinesCommand;
    private static readonly MapInfoCommand RemoveGuidelinesCommand;

    static LegendCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(2806, nameof (AddFrames), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_AddFrames_Label;
      basicRunMenuCommand1.MenuItemText = Resources.Command_AddFrames_MenuItemText;
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_AddFrames_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_AddFrames_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.AddFramesCommand = (MapInfoCommand) basicRunMenuCommand1;
      LegendCommands.AddFramesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(2807, nameof (AddTextFrame), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_AddTextFrame_Label;
      basicRunMenuCommand2.MenuItemText = Resources.Command_AddTextFrame_MenuItemText;
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_AddTextFrame_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_AddTextFrame_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.AddTextFrameCommand = (MapInfoCommand) basicRunMenuCommand2;
      LegendCommands.AddTextFrameCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(2803, nameof (RemoveFrames), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_RemoveFrames_Label;
      basicRunMenuCommand3.MenuItemText = Resources.Command_RemoveFrames_MenuItemText;
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_RemoveFrames_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_RemoveFrames_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.RemoveFramesCommand = (MapInfoCommand) basicRunMenuCommand3;
      LegendCommands.RemoveFramesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(2804, "LegendFrameProperties", (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_LegendFrameProperties_Label;
      basicRunMenuCommand4.MenuItemText = Resources.Command_LegendFrameProperties_MenuItemText;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyLegend_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyLegend_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_LegendFrameProperties_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_LegendFrameProperties_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow_ThemeFrame;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.FramePropertiesCommand = (MapInfoCommand) basicRunMenuCommand4;
      LegendCommands.FramePropertiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(2808, "LegendModifyTheme", (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_LegendModifyTheme_Label;
      basicRunMenuCommand5.MenuItemText = Resources.Command_LegendModifyTheme_MenuItemText;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyTheme_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyTheme_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_LegendModifyTheme_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_LegendModifyTheme_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow_ThemeFrame;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.ModifyThemeCommand = (MapInfoCommand) basicRunMenuCommand5;
      LegendCommands.ModifyThemeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(2809, "LegendToggleGridLines", (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_LegendToggleGridLines_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/showGridlines_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/showGridlines_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_LegendToggleGridLines_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_LegendToggleGridLines_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.ToggleGridLinesCommand = (MapInfoCommand) basicRunMenuCommand6;
      LegendCommands.ToggleGridLinesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(2810, "LegendSnapToGrid", (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_LegendSnapToGrid_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/snapToGrid_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/snapToGrid_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_LegendSnapToGrid_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_LegendSnapToGrid_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.SnapToGridCommand = (MapInfoCommand) basicRunMenuCommand7;
      LegendCommands.SnapToGridCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(2811, "LegendAddHorizontalGuideline", (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_LegendAddHorizontalGuideline_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/addHorizGuideline_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/addHorizGuideline_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_LegendAddHorizontalGuideline_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_LegendAddHorizontalGuideline_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_AddGuideline;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.AddHorizontalGuidelineCommand = (MapInfoCommand) basicRunMenuCommand8;
      LegendCommands.AddHorizontalGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(2812, "LegendAddVerticalGuideline", (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_LegendAddVerticalGuideline_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/addVertGuideline_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/addVertGuideline_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_LegendAddVerticalGuideline_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_LegendAddVerticalGuideline_Tooltip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_AddGuideline;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.AddVerticalGuidelineCommand = (MapInfoCommand) basicRunMenuCommand9;
      LegendCommands.AddVerticalGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(2813, "LegendSnapToTopGuideline", (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_LegendSnapToTopGuideline_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignTop_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignTop_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_LegendSnapToTopGuideline_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_LegendSnapToTopGuideline_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegend_HorizGuide;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.SnapToTopGuidelineCommand = (MapInfoCommand) basicRunMenuCommand10;
      LegendCommands.SnapToTopGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(2814, "LegendSnapToBottomGuideline", (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_LegendSnapToBottomGuideline_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignBottom_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignBottom_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_LegendSnapToBottomGuideline_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_LegendSnapToBottomGuideline_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegend_HorizGuide;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.SnapToBottomGuidelineCommand = (MapInfoCommand) basicRunMenuCommand11;
      LegendCommands.SnapToBottomGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(2815, "LegendSnapToLeftGuideline", (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_LegendSnapToLeftGuideline_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignLeft_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignLeft_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_LegendSnapToLeftGuideline_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_LegendSnapToLeftGuideline_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegend_VertGuide;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.SnapToLeftGuidelineCommand = (MapInfoCommand) basicRunMenuCommand12;
      LegendCommands.SnapToLeftGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(2816, "LegendSnapToRightGuideline", (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_LegendSnapToRightGuideline_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignRight_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/alignRight_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_LegendSnapToRightGuideline_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_LegendSnapToRightGuideline_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegend_VertGuide;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.SnapToRightGuidelineCommand = (MapInfoCommand) basicRunMenuCommand13;
      LegendCommands.SnapToRightGuidelineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(2817, "LegendQuickRefresh", (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_LegendQuickRefresh_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/legendRefreshQuick_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/legendRefreshQuick_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_LegendQuickRefresh_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_LegendQuickRefresh_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand14.EnableCommand = true;
      basicRunMenuCommand14.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.QuickRefreshCommand = (MapInfoCommand) basicRunMenuCommand14;
      LegendCommands.QuickRefreshCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(2805, "LegendRefreshAll", (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_LegendRefreshAll_Label;
      basicRunMenuCommand15.MenuItemText = Resources.Command_LegendRefreshAll_MenuItemText;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/legendrefreshAll_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/legendrefreshAll_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_LegendRefreshAll_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_LegendRefreshAll_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand15.EnableCommand = true;
      basicRunMenuCommand15.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.RefreshAllCommand = (MapInfoCommand) basicRunMenuCommand15;
      LegendCommands.RefreshAllCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(2801, "LegendDisableGuidelines", (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_LegendDisableGuidelines_Label;
      basicRunMenuCommand16.MenuItemToggleText = Resources.Command_LegendDisableGuidelines_MenuItemToggleText;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/showAlignBars_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/showAlignBars_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_LegendDisableGuidelines_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_LegendDisableGuidelines_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.DisableGuidelinesCommand = (MapInfoCommand) basicRunMenuCommand16;
      LegendCommands.DisableGuidelinesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(2802, "LegendRemoveGuidelines", (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_LegendRemoveGuidelines_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/clearAlignBars_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/clearAlignBars_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_LegendRemoveGuidelines_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_LegendRemoveGuidelines_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLegendWindow;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_LegendCommands;
      LegendCommands.RemoveGuidelinesCommand = (MapInfoCommand) basicRunMenuCommand17;
      LegendCommands.RemoveGuidelinesCommand.CreateScreenTip();
    }

    public static MapInfoCommand AddFrames
    {
      get
      {
        return LegendCommands.AddFramesCommand;
      }
    }

    public static MapInfoCommand AddTextFrame
    {
      get
      {
        return LegendCommands.AddTextFrameCommand;
      }
    }

    public static MapInfoCommand RemoveFrames
    {
      get
      {
        return LegendCommands.RemoveFramesCommand;
      }
    }

    public static MapInfoCommand FrameProperties
    {
      get
      {
        return LegendCommands.FramePropertiesCommand;
      }
    }

    public static MapInfoCommand ModifyTheme
    {
      get
      {
        return LegendCommands.ModifyThemeCommand;
      }
    }

    public static MapInfoCommand ToggleGridLines
    {
      get
      {
        return LegendCommands.ToggleGridLinesCommand;
      }
    }

    public static MapInfoCommand SnapToGrid
    {
      get
      {
        return LegendCommands.SnapToGridCommand;
      }
    }

    public static MapInfoCommand AddHorizontalGuideline
    {
      get
      {
        return LegendCommands.AddHorizontalGuidelineCommand;
      }
    }

    public static MapInfoCommand AddVerticalGuideline
    {
      get
      {
        return LegendCommands.AddVerticalGuidelineCommand;
      }
    }

    public static MapInfoCommand SnapToTopGuideline
    {
      get
      {
        return LegendCommands.SnapToTopGuidelineCommand;
      }
    }

    public static MapInfoCommand SnapToBottomGuideline
    {
      get
      {
        return LegendCommands.SnapToBottomGuidelineCommand;
      }
    }

    public static MapInfoCommand SnapToLeftGuideline
    {
      get
      {
        return LegendCommands.SnapToLeftGuidelineCommand;
      }
    }

    public static MapInfoCommand SnapToRightGuideline
    {
      get
      {
        return LegendCommands.SnapToRightGuidelineCommand;
      }
    }

    public static MapInfoCommand QuickRefresh
    {
      get
      {
        return LegendCommands.QuickRefreshCommand;
      }
    }

    public static MapInfoCommand RefreshAll
    {
      get
      {
        return LegendCommands.RefreshAllCommand;
      }
    }

    public static MapInfoCommand DisableGuidelines
    {
      get
      {
        return LegendCommands.DisableGuidelinesCommand;
      }
    }

    public static MapInfoCommand RemoveGuidelines
    {
      get
      {
        return LegendCommands.RemoveGuidelinesCommand;
      }
    }

    [Serializable]
    public class LegendCommand : MapBasicCommand
    {
      public LegendCommand(string name, InputGestureCollection inputGestureCollection)
        : base(string.Empty, name, string.Empty, inputGestureCollection)
      {
      }
    }
  }
}
