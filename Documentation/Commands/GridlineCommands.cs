// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.GridlineCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Collections.Generic;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class GridlineCommands
  {
    private static readonly List<MapInfoCommand> _commands = new List<MapInfoCommand>();
    private static readonly MapBasicRunMenuCommand GridlinePropertiesDialogCommand;
    private static readonly MapBasicRunMenuCommand GridlineCreateCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentLeftCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentRightCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentAboveCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentBelowCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentHorizontalCenterCommand;
    private static readonly GridlineLabelAlignmentCommand GridlineLabelAlignmentVerticalCenterCommand;
    private static readonly GridlineLabelDirectionCommand GridlineLabelDirectionHorizontalCommand;
    private static readonly GridlineLabelDirectionCommand GridlineLabelDirectionVerticalCommand;
    private static readonly GridlineLabelOffsetCommand GridlineLabelOffsetCommand;
    private static readonly GridlineLabelMapEdgeOffsetCommand GridlineLabelMapEdgeOffsetCommand;
    private static readonly GridlineLabelPlacementCommand GridlineLabelPlacementCommand;
    private static readonly GridlineLabelFormatCommand GridlineLabelFormatCommand;

    public static IReadOnlyCollection<MapInfoCommand> Commands()
    {
      return (IReadOnlyCollection<MapInfoCommand>) GridlineCommands._commands;
    }

    static GridlineCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(846, nameof (GridlinePropertiesDialog), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_GridlinePropertiesDialog_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/gridlines_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/gridlines_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_GridlinePropertiesDialog_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_GridlinePropertiesDialog_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_GridlinePropertiesDialog_ToolTip_DisabledText;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlinePropertiesDialogCommand = basicRunMenuCommand1;
      GridlineCommands.GridlinePropertiesDialogCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(845, nameof (GridlineCreate), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_GridlineCreate_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/Add_Gridlines_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/Add_Gridlines_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_GridlineCreate_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_GridlineCreate_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_GridlineCreate_ToolTip_DisabledText;
      basicRunMenuCommand2.EnableCommand = true;
      basicRunMenuCommand2.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineCreateCommand = basicRunMenuCommand2;
      GridlineCommands.GridlineCreateCommand.CreateScreenTip();
      GridlineLabelAlignmentCommand alignmentCommand1 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentLeft), (InputGestureCollection) null, "left");
      alignmentCommand1.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand1.ToolTipDescription = Resources.Command_GridlineLabelAlignmentLeft_ToolTip_Description;
      alignmentCommand1.ToolTipText = Resources.Command_GridlineLabelAlignmentLeft_ToolTip_Text;
      alignmentCommand1.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentLeft_ToolTip_DisabledText;
      alignmentCommand1.EnableCommand = true;
      alignmentCommand1.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentLeftCommand = alignmentCommand1;
      GridlineCommands.GridlineLabelAlignmentLeftCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentLeftCommand);
      GridlineLabelAlignmentCommand alignmentCommand2 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentRight), (InputGestureCollection) null, "right");
      alignmentCommand2.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand2.ToolTipDescription = Resources.Command_GridlineLabelAlignmentRight_ToolTip_Description;
      alignmentCommand2.ToolTipText = Resources.Command_GridlineLabelAlignmentRight_ToolTip_Text;
      alignmentCommand2.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentRight_ToolTip_DisabledText;
      alignmentCommand2.EnableCommand = true;
      alignmentCommand2.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentRightCommand = alignmentCommand2;
      GridlineCommands.GridlineLabelAlignmentRightCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentRightCommand);
      GridlineLabelAlignmentCommand alignmentCommand3 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentAbove), (InputGestureCollection) null, "above");
      alignmentCommand3.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand3.ToolTipDescription = Resources.Command_GridlineLabelAlignmentAbove_ToolTip_Description;
      alignmentCommand3.ToolTipText = Resources.Command_GridlineLabelAlignmentAbove_ToolTip_Text;
      alignmentCommand3.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentAbove_ToolTip_DisabledText;
      alignmentCommand3.EnableCommand = true;
      alignmentCommand3.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentAboveCommand = alignmentCommand3;
      GridlineCommands.GridlineLabelAlignmentAboveCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentAboveCommand);
      GridlineLabelAlignmentCommand alignmentCommand4 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentBelow), (InputGestureCollection) null, "below");
      alignmentCommand4.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand4.ToolTipDescription = Resources.Command_GridlineLabelAlignmentBelow_ToolTip_Description;
      alignmentCommand4.ToolTipText = Resources.Command_GridlineLabelAlignmentBelow_ToolTip_Text;
      alignmentCommand4.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentBelow_ToolTip_DisabledText;
      alignmentCommand4.EnableCommand = true;
      alignmentCommand4.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentBelowCommand = alignmentCommand4;
      GridlineCommands.GridlineLabelAlignmentBelowCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentBelowCommand);
      GridlineLabelAlignmentCommand alignmentCommand5 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentHorizontalCenter), (InputGestureCollection) null, "center");
      alignmentCommand5.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand5.ToolTipDescription = Resources.Command_GridlineLabelAlignmentHorizontalCenter_ToolTip_Description;
      alignmentCommand5.ToolTipText = Resources.Command_GridlineLabelAlignmentHorizontalCenter_ToolTip_Text;
      alignmentCommand5.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentHorizontalCenter_ToolTip_DisabledText;
      alignmentCommand5.EnableCommand = true;
      alignmentCommand5.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentHorizontalCenterCommand = alignmentCommand5;
      GridlineCommands.GridlineLabelAlignmentHorizontalCenterCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentHorizontalCenterCommand);
      GridlineLabelAlignmentCommand alignmentCommand6 = new GridlineLabelAlignmentCommand(nameof (GridlineLabelAlignmentVerticalCenter), (InputGestureCollection) null, "center");
      alignmentCommand6.Text = Resources.Command_GridlineLabelAlignment_Label;
      alignmentCommand6.ToolTipDescription = Resources.Command_GridlineLabelAlignmentVerticalCenter_ToolTip_Description;
      alignmentCommand6.ToolTipText = Resources.Command_GridlineLabelAlignmentVerticalCenter_ToolTip_Text;
      alignmentCommand6.ToolTipDisabledText = Resources.Command_GridlineLabelAlignmentVerticalCenter_ToolTip_DisabledText;
      alignmentCommand6.EnableCommand = true;
      alignmentCommand6.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelAlignmentVerticalCenterCommand = alignmentCommand6;
      GridlineCommands.GridlineLabelAlignmentVerticalCenterCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelAlignmentVerticalCenterCommand);
      GridlineLabelDirectionCommand directionCommand1 = new GridlineLabelDirectionCommand(nameof (GridlineLabelDirectionHorizontal), (InputGestureCollection) null, "Off");
      directionCommand1.Text = Resources.Command_GridlineLabelAlignment_Label;
      directionCommand1.ToolTipDescription = Resources.Command_GridlineLabelDirectionHorizontal_ToolTip_Description;
      directionCommand1.ToolTipText = Resources.Command_GridlineLabelDirectionHorizontal_ToolTip_Text;
      directionCommand1.ToolTipDisabledText = Resources.Command_GridlineLabelDirectionHorizontal_ToolTip_DisabledText;
      directionCommand1.EnableCommand = true;
      directionCommand1.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelDirectionHorizontalCommand = directionCommand1;
      GridlineCommands.GridlineLabelDirectionHorizontalCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelDirectionHorizontalCommand);
      GridlineLabelDirectionCommand directionCommand2 = new GridlineLabelDirectionCommand(nameof (GridlineLabelDirectionVertical), (InputGestureCollection) null, "On");
      directionCommand2.Text = Resources.Command_GridlineLabelAlignment_Label;
      directionCommand2.ToolTipDescription = Resources.Command_GridlineLabelDirectionVertical_ToolTip_Description;
      directionCommand2.ToolTipText = Resources.Command_GridlineLabelDirectionVertical_ToolTip_Text;
      directionCommand2.ToolTipDisabledText = Resources.Command_GridlineLabelDirectionVertical_ToolTip_DisabledText;
      directionCommand2.EnableCommand = true;
      directionCommand2.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelDirectionVerticalCommand = directionCommand2;
      GridlineCommands.GridlineLabelDirectionVerticalCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelDirectionVerticalCommand);
      GridlineLabelOffsetCommand labelOffsetCommand = new GridlineLabelOffsetCommand(nameof (GridlineLabelOffset), (InputGestureCollection) null, (string) null);
      labelOffsetCommand.Text = Resources.Command_GridlineLabelAlignment_Label;
      labelOffsetCommand.ToolTipDescription = Resources.Command_GridlineLabelOffset_ToolTip_Description;
      labelOffsetCommand.ToolTipText = Resources.Command_GridlineLabelOffset_ToolTip_Text;
      labelOffsetCommand.ToolTipDisabledText = Resources.Command_GridlineCreate_ToolTip_DisabledText;
      labelOffsetCommand.EnableCommand = true;
      labelOffsetCommand.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelOffsetCommand = labelOffsetCommand;
      GridlineCommands.GridlineLabelOffsetCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelOffsetCommand);
      GridlineLabelMapEdgeOffsetCommand edgeOffsetCommand = new GridlineLabelMapEdgeOffsetCommand(nameof (GridlineLabelMapEdgeOffset), (InputGestureCollection) null, (string) null);
      edgeOffsetCommand.Text = Resources.Command_GridlineLabelAlignment_Label;
      edgeOffsetCommand.ToolTipDescription = Resources.Command_GridlineLabelMapEdgeOffset_ToolTip_Description;
      edgeOffsetCommand.ToolTipText = Resources.Command_GridlineLabelMapEdgeOffset_ToolTip_Text;
      edgeOffsetCommand.ToolTipDisabledText = Resources.Command_GridlineCreate_ToolTip_DisabledText;
      edgeOffsetCommand.EnableCommand = true;
      edgeOffsetCommand.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelMapEdgeOffsetCommand = edgeOffsetCommand;
      GridlineCommands.GridlineLabelMapEdgeOffsetCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelMapEdgeOffsetCommand);
      GridlineLabelPlacementCommand placementCommand = new GridlineLabelPlacementCommand(nameof (GridlineLabelPlacement), (InputGestureCollection) null, (string) null);
      placementCommand.Text = Resources.Command_GridlineLabelAlignment_Label;
      placementCommand.ToolTipDescription = Resources.Command_GridlineLabelMapEdgeOffset_ToolTip_Description;
      placementCommand.ToolTipText = Resources.Command_GridlineLabelMapEdgeOffset_ToolTip_Text;
      placementCommand.ToolTipDisabledText = Resources.Command_GridlineCreate_ToolTip_DisabledText;
      placementCommand.EnableCommand = true;
      placementCommand.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelPlacementCommand = placementCommand;
      GridlineCommands.GridlineLabelPlacementCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelPlacementCommand);
      GridlineLabelFormatCommand labelFormatCommand = new GridlineLabelFormatCommand(nameof (GridlineLabelFormat), (InputGestureCollection) null, (string) null);
      labelFormatCommand.Text = "";
      labelFormatCommand.EnableCommand = true;
      labelFormatCommand.Category = Resources.Command_Category_GridlineCommands;
      GridlineCommands.GridlineLabelFormatCommand = labelFormatCommand;
      GridlineCommands.GridlineLabelFormatCommand.CreateScreenTip();
      GridlineCommands._commands.Add((MapInfoCommand) GridlineCommands.GridlineLabelFormatCommand);
    }

    public static MapBasicCommand GridlinePropertiesDialog
    {
      get
      {
        return (MapBasicCommand) GridlineCommands.GridlinePropertiesDialogCommand;
      }
    }

    public static MapBasicCommand GridlineCreate
    {
      get
      {
        return (MapBasicCommand) GridlineCommands.GridlineCreateCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentLeft
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentLeftCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentRight
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentRightCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentAbove
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentAboveCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentBelow
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentBelowCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentHorizontalCenter
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentHorizontalCenterCommand;
      }
    }

    public static GridlineLabelAlignmentCommand GridlineLabelAlignmentVerticalCenter
    {
      get
      {
        return GridlineCommands.GridlineLabelAlignmentVerticalCenterCommand;
      }
    }

    public static GridlineLabelDirectionCommand GridlineLabelDirectionHorizontal
    {
      get
      {
        return GridlineCommands.GridlineLabelDirectionHorizontalCommand;
      }
    }

    public static GridlineLabelDirectionCommand GridlineLabelDirectionVertical
    {
      get
      {
        return GridlineCommands.GridlineLabelDirectionVerticalCommand;
      }
    }

    public static GridlineLabelOffsetCommand GridlineLabelOffset
    {
      get
      {
        return GridlineCommands.GridlineLabelOffsetCommand;
      }
    }

    public static GridlineLabelMapEdgeOffsetCommand GridlineLabelMapEdgeOffset
    {
      get
      {
        return GridlineCommands.GridlineLabelMapEdgeOffsetCommand;
      }
    }

    public static GridlineLabelPlacementCommand GridlineLabelPlacement
    {
      get
      {
        return GridlineCommands.GridlineLabelPlacementCommand;
      }
    }

    public static GridlineLabelFormatCommand GridlineLabelFormat
    {
      get
      {
        return GridlineCommands.GridlineLabelFormatCommand;
      }
    }
  }
}
