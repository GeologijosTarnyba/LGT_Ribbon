// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LabelRulesCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Collections.Generic;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public class LabelRulesCommands
  {
    private static readonly List<MapInfoCommand> _commands = new List<MapInfoCommand>();
    private static readonly LabelRulesCommand LayerRegionLabelAutoRuleCommand;
    private static readonly LabelRulesCommand LayerRegionLabelCalloutCommand;
    private static readonly LabelRulesCommand LayerRegionLabelOverflowCommand;
    private static readonly LabelRulesCommand LayerRegionLabelCentroidCommand;
    private static readonly LabelRulesCommand LayerRegionLabelAutoPosCommand;
    private static readonly LabelRulesCommand LayerRegionLabelAutoPosOverflowCommand;
    private static readonly LabelRulesCommand LayerRegionLabelAutoPosCalloutCommand;
    private static readonly LabelRulesCommand LayerLineLabelCurvedDefaultCommand;
    private static readonly LabelRulesCommand LayerLineLabelCurvedWithFallbackCommand;
    private static readonly LabelRulesCommand LayerLineLabelRotatedCommand;
    private static readonly LabelRulesCommand LayerLineLabelHorizontalCommand;
    private static readonly LabelRulesCommand LayerPointsLabelDefaultCommand;

    public static IReadOnlyCollection<MapInfoCommand> Commands()
    {
      return (IReadOnlyCollection<MapInfoCommand>) LabelRulesCommands._commands;
    }

    static LabelRulesCommands()
    {
      LabelRulesCommand labelRulesCommand1 = new LabelRulesCommand("Auto Size (Default)", "Auto Size Default", (InputGestureCollection) null, (object) LabelRules.RegionsAutoSizeDefault);
      labelRulesCommand1.Text = Resources.Command_LayerRegionLabelAutoRule_Text;
      labelRulesCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoSize_16x16.png";
      labelRulesCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoSize_32x32.png";
      labelRulesCommand1.ToolTipDescription = Resources.Command_LayerRegionLabelAutoRule_ToolTip_Description;
      labelRulesCommand1.ToolTipText = Resources.Command_LayerRegionLabelAutoRule_ToolTip_Text;
      labelRulesCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand1.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelAutoRuleCommand = labelRulesCommand1;
      LabelRulesCommands.LayerRegionLabelAutoRuleCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelAutoRuleCommand);
      LabelRulesCommand labelRulesCommand2 = new LabelRulesCommand("Auto Size with Callout", "Auto Size with Callout", (InputGestureCollection) null, (object) LabelRules.RegionsAutoSizeWithCallouts);
      labelRulesCommand2.Text = Resources.Command_LayerRegionLabelCalloutCommand_Text;
      labelRulesCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutosizeCallouts_16x16.png";
      labelRulesCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutosizeCallouts_32x32.png";
      labelRulesCommand2.ToolTipDescription = Resources.Command_LayerRegionLabelCalloutCommand_ToolTip_Description;
      labelRulesCommand2.ToolTipText = Resources.Command_LayerRegionLabelCalloutCommand_ToolTip_Text;
      labelRulesCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand2.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelCalloutCommand = labelRulesCommand2;
      LabelRulesCommands.LayerRegionLabelCalloutCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelCalloutCommand);
      LabelRulesCommand labelRulesCommand3 = new LabelRulesCommand("Auto Size with Overflow", "Auto Size with Overflow", (InputGestureCollection) null, (object) LabelRules.RegionsAutoSizeWithOverflow);
      labelRulesCommand3.Text = Resources.Command_LayerRegionLabelOverflowCommand_Text;
      labelRulesCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutosizeOverflow_16x16.png";
      labelRulesCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutosizeOverflow_32x32.png";
      labelRulesCommand3.ToolTipDescription = Resources.Command_LayerRegionLabelOverflowCommand_ToolTip_Description;
      labelRulesCommand3.ToolTipText = Resources.Command_LayerRegionLabelOverflowCommand_ToolTip_Text;
      labelRulesCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand3.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelOverflowCommand = labelRulesCommand3;
      LabelRulesCommands.LayerRegionLabelOverflowCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelOverflowCommand);
      LabelRulesCommand labelRulesCommand4 = new LabelRulesCommand("Centroid", "Centroid", (InputGestureCollection) null, (object) LabelRules.RegionsCentroid);
      labelRulesCommand4.Text = Resources.Command_LayerRegionLabelCentroidCommand_Text;
      labelRulesCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCentroid_16x16.png";
      labelRulesCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCentroid_32x32.png";
      labelRulesCommand4.ToolTipDescription = Resources.Command_LayerRegionLabelCentroidCommand_ToolTip_Description;
      labelRulesCommand4.ToolTipText = Resources.Command_LayerRegionLabelCentroidCommand_ToolTip_Text;
      labelRulesCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand4.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelCentroidCommand = labelRulesCommand4;
      LabelRulesCommands.LayerRegionLabelCentroidCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelCentroidCommand);
      LabelRulesCommand labelRulesCommand5 = new LabelRulesCommand("Auto Position", "Auto Position", (InputGestureCollection) null, (object) LabelRules.RegionAutoPosition);
      labelRulesCommand5.Text = Resources.Command_LayerRegionLabelAutoPosCommand_Text;
      labelRulesCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPosition_16x16.png";
      labelRulesCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPosition_32x32.png";
      labelRulesCommand5.ToolTipDescription = Resources.Command_LayerRegionLabelAutoPosCommand_ToolTip_Description;
      labelRulesCommand5.ToolTipText = Resources.Command_LayerRegionLabelAutoPosCommand_ToolTip_Text;
      labelRulesCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand5.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelAutoPosCommand = labelRulesCommand5;
      LabelRulesCommands.LayerRegionLabelAutoPosCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelAutoPosCommand);
      LabelRulesCommand labelRulesCommand6 = new LabelRulesCommand("Auto Position with Overflow", "Auto Position with Overflow", (InputGestureCollection) null, (object) LabelRules.RegionAutoPositionWithOverflow);
      labelRulesCommand6.Text = Resources.Command_LayerRegionLabelAutoPosOverflowCommand_Text;
      labelRulesCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPositionOverflow_16x16.png";
      labelRulesCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPositionOverflow_32x32.png";
      labelRulesCommand6.ToolTipDescription = Resources.Command_LayerRegionLabelAutoPosOverflowCommand_ToolTip_Description;
      labelRulesCommand6.ToolTipText = Resources.Command_LayerRegionLabelAutoPosOverflowCommand_ToolTip_Text;
      labelRulesCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand6.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelAutoPosOverflowCommand = labelRulesCommand6;
      LabelRulesCommands.LayerRegionLabelAutoPosOverflowCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelAutoPosOverflowCommand);
      LabelRulesCommand labelRulesCommand7 = new LabelRulesCommand("Auto Position with Callout", "Auto Position with Callout", (InputGestureCollection) null, (object) LabelRules.RegionAutoPostitionWithCallout);
      labelRulesCommand7.Text = Resources.Command_LayerRegionLabelAutoPosCalloutCommand_Text;
      labelRulesCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPositionCallout_16x16.png";
      labelRulesCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelAutoPositionCallout_32x32.png";
      labelRulesCommand7.ToolTipDescription = Resources.Command_LayerRegionLabelAutoPosCalloutCommand_ToolTip_Description;
      labelRulesCommand7.ToolTipText = Resources.Command_LayerRegionLabelAutoPosCalloutCommand_ToolTip_Text;
      labelRulesCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandRegionsSupport;
      labelRulesCommand7.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerRegionLabelAutoPosCalloutCommand = labelRulesCommand7;
      LabelRulesCommands.LayerRegionLabelAutoPosCalloutCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerRegionLabelAutoPosCalloutCommand);
      LabelRulesCommand labelRulesCommand8 = new LabelRulesCommand("Curved (Default)", "Curved", (InputGestureCollection) null, (object) LabelRules.LinesCurvedDefault);
      labelRulesCommand8.Text = Resources.Command_LayerLineLabelCurvedDefaultCommand_Text;
      labelRulesCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCurved_16x16_B.png";
      labelRulesCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCurved_32x32_B.png";
      labelRulesCommand8.ToolTipDescription = Resources.Command_LayerLineLabelCurvedDefaultCommand_ToolTip_Description;
      labelRulesCommand8.ToolTipText = Resources.Command_LayerLineLabelCurvedDefaultCommand_ToolTip_Text;
      labelRulesCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandLinesSupport;
      labelRulesCommand8.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerLineLabelCurvedDefaultCommand = labelRulesCommand8;
      LabelRulesCommands.LayerLineLabelCurvedDefaultCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerLineLabelCurvedDefaultCommand);
      LabelRulesCommand labelRulesCommand9 = new LabelRulesCommand("Curved with Fallback", "Curved with Fallback", (InputGestureCollection) null, (object) LabelRules.LinesCurvedWithFallback);
      labelRulesCommand9.Text = Resources.Command_LayerLineLabelCurvedWithFallbackCommand_Text;
      labelRulesCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCurvedFallback_16x16_B.png";
      labelRulesCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelCurvedFallback_32x32_B.png";
      labelRulesCommand9.ToolTipDescription = Resources.Command_LayerLineLabelCurvedWithFallbackCommand_ToolTip_Description;
      labelRulesCommand9.ToolTipText = Resources.Command_LayerLineLabelCurvedWithFallbackCommand_ToolTip_Text;
      labelRulesCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandLinesSupport;
      labelRulesCommand9.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerLineLabelCurvedWithFallbackCommand = labelRulesCommand9;
      LabelRulesCommands.LayerLineLabelCurvedWithFallbackCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerLineLabelCurvedWithFallbackCommand);
      LabelRulesCommand labelRulesCommand10 = new LabelRulesCommand("Rotated", "Rotated", (InputGestureCollection) null, (object) LabelRules.LinesRotated);
      labelRulesCommand10.Text = Resources.Command_LayerLineLabelRotatedCommand_Text;
      labelRulesCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelRotated_16x16.png";
      labelRulesCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelRotated_32x32.png";
      labelRulesCommand10.ToolTipDescription = Resources.Command_LayerLineLabelRotatedCommand_ToolTip_Description;
      labelRulesCommand10.ToolTipText = Resources.Command_LayerLineLabelRotatedCommand_ToolTip_Text;
      labelRulesCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandLinesSupport;
      labelRulesCommand10.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerLineLabelRotatedCommand = labelRulesCommand10;
      LabelRulesCommands.LayerLineLabelRotatedCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerLineLabelRotatedCommand);
      LabelRulesCommand labelRulesCommand11 = new LabelRulesCommand("Horizontal", "Horizontal", (InputGestureCollection) null, (object) LabelRules.LinesHorizontal);
      labelRulesCommand11.Text = Resources.Command_LayerLineLabelHorizontalCommand_Text;
      labelRulesCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelHorizontal_16x16.png";
      labelRulesCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelHorizontal_32x32.png";
      labelRulesCommand11.ToolTipDescription = Resources.Command_LayerLineLabelHorizontalCommand_ToolTip_Description;
      labelRulesCommand11.ToolTipText = Resources.Command_LayerLineLabelHorizontalCommand_ToolTip_Text;
      labelRulesCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandLinesSupport;
      labelRulesCommand11.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerLineLabelHorizontalCommand = labelRulesCommand11;
      LabelRulesCommands.LayerLineLabelHorizontalCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerLineLabelHorizontalCommand);
      LabelRulesCommand labelRulesCommand12 = new LabelRulesCommand("Default", "Points Default", (InputGestureCollection) null, (object) LabelRules.PointsDefault);
      labelRulesCommand12.Text = Resources.Command_LayerPointsLabelDefaultCommand_Text;
      labelRulesCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelPoint_16x16.png";
      labelRulesCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelPoint_32x32.png";
      labelRulesCommand12.ToolTipDescription = Resources.Command_LayerPointsLabelDefaultCommand_ToolTip_Description;
      labelRulesCommand12.ToolTipText = Resources.Command_LayerPointsLabelDefaultCommand_ToolTip_Text;
      labelRulesCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelandPointsSupport;
      labelRulesCommand12.Category = Resources.Command_Category_LayerLabelCommands;
      LabelRulesCommands.LayerPointsLabelDefaultCommand = labelRulesCommand12;
      LabelRulesCommands.LayerPointsLabelDefaultCommand.CreateScreenTip();
      LabelRulesCommands._commands.Add((MapInfoCommand) LabelRulesCommands.LayerPointsLabelDefaultCommand);
    }

    public static LabelRulesCommand LayerRegionLabelAutoPosCallout
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelAutoPosCalloutCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelAutoPosOverflow
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelAutoPosOverflowCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelAutoPos
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelAutoPosCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelAutoRule
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelAutoRuleCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelCallout
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelCalloutCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelOverflow
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelOverflowCommand;
      }
    }

    public static LabelRulesCommand LayerRegionLabelCentroid
    {
      get
      {
        return LabelRulesCommands.LayerRegionLabelCentroidCommand;
      }
    }

    public static LabelRulesCommand LayerLineLabelCurvedDefault
    {
      get
      {
        return LabelRulesCommands.LayerLineLabelCurvedDefaultCommand;
      }
    }

    public static LabelRulesCommand LayerLineLabelCurvedWithFallback
    {
      get
      {
        return LabelRulesCommands.LayerLineLabelCurvedWithFallbackCommand;
      }
    }

    public static LabelRulesCommand LayerLineLabelRotated
    {
      get
      {
        return LabelRulesCommands.LayerLineLabelRotatedCommand;
      }
    }

    public static LabelRulesCommand LayerLineLabelHorizontal
    {
      get
      {
        return LabelRulesCommands.LayerLineLabelHorizontalCommand;
      }
    }

    public static LabelRulesCommand LayerPointsLabelDefault
    {
      get
      {
        return LabelRulesCommands.LayerPointsLabelDefaultCommand;
      }
    }
  }
}
