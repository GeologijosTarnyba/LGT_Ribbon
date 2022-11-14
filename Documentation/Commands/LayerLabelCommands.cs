// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LayerLabelCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using MapInfo.MiPro.Base;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class LayerLabelCommands
  {
    private static readonly LayerLabelFontController _layerLabelFontController = new LayerLabelFontController();
    private static readonly List<MapInfoCommand> _commands = new List<MapInfoCommand>();
    private static readonly LayerLabelCommands.LayerLabelCommand AllCapsCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand BoldCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand ExpandedCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand FontColorCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand FontSizeCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand FontFamilyCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand HaloCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand HighlightCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand ItalicCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand ShadowCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand UnderlineCommand;
    private static readonly LayerLabelCommands.ModifyFontSizeCommand IncreaseFontSizeCommand;
    private static readonly LayerLabelCommands.ModifyFontSizeCommand DecreaseFontSizeCommand;
    private static readonly LayerLabelCommands.LayerLabelCommand BackgroundColorCommand;
    private static readonly MapInfoCommand AllowDuplicateCommand;
    private static readonly MapInfoCommand LabelPartialObjectCommand;
    private static readonly MapInfoCommand DiscardOverlapLabelCommand;
    private static readonly MapInfoCommand PositionRetryCommand;
    private static readonly MapInfoCommand AllowOverlapLabelCommand;
    private static readonly MapInfoCommand LabelPositionCommand;
    private static readonly MapInfoCommand LineLeaderNoneCommand;
    private static readonly MapInfoCommand LineLeaderSimpleCommand;
    private static readonly MapInfoCommand LineLeaderArrowCommand;
    private static readonly LayerLabelCommands.LayerLabelLabelUsingCommand LabelUsingCommand;
    private static readonly MapInfoCommand AbbreviationsUsingCommand;
    private static readonly LayerLabelCommands.LabelPreviewOnOffCommand LabelPreviewCommand;

    static LayerLabelCommands()
    {
      LayerLabelCommands.LayerLabelCommand layerLabelCommand1 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (AllCaps), nameof (AllCaps), (InputGestureCollection) null);
      layerLabelCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textAllCaps_16x16.png";
      layerLabelCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textAllCaps_32x32.png";
      layerLabelCommand1.ToolTipDescription = Resources.Command_LayerLabelAllCaps_ToolTip_Description;
      layerLabelCommand1.ToolTipText = Resources.Command_LayerLabelAllCaps_ToolTip_Text;
      layerLabelCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand1.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand1.ToolName = MapInfoConstants.ToolNameFontAllCaps;
      LayerLabelCommands.AllCapsCommand = layerLabelCommand1;
      LayerLabelCommands.AllCapsCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.AllCapsCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand2 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Bold), nameof (Bold), (InputGestureCollection) null);
      layerLabelCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/bold_16x16.png";
      layerLabelCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/bold_32x32.png";
      layerLabelCommand2.ToolTipDescription = Resources.Command_LayerLabelBold_ToolTip_Description;
      layerLabelCommand2.ToolTipText = Resources.Command_LayerLabelBold_ToolTip_Text;
      layerLabelCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand2.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand2.ToolName = MapInfoConstants.ToolNameFontBold;
      LayerLabelCommands.BoldCommand = layerLabelCommand2;
      LayerLabelCommands.BoldCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.BoldCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand3 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Expanded), nameof (Expanded), (InputGestureCollection) null);
      layerLabelCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textExpanded_16x16.png";
      layerLabelCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textExpanded_32x32.png";
      layerLabelCommand3.ToolTipDescription = Resources.Command_LayerLabelExpanded_ToolTip_Description;
      layerLabelCommand3.ToolTipText = Resources.Command_LayerLabelExpanded_ToolTip_Text;
      layerLabelCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand3.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand3.ToolName = MapInfoConstants.ToolNameFontDblSpace;
      LayerLabelCommands.ExpandedCommand = layerLabelCommand3;
      LayerLabelCommands.ExpandedCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.ExpandedCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand4 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (FontColor), nameof (FontColor), (InputGestureCollection) null);
      layerLabelCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/fontColor_16x16.png";
      layerLabelCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/fontColor_32x32.png";
      layerLabelCommand4.ToolTipDescription = Resources.Command_LayerLabelFontColor_ToolTip_Description;
      layerLabelCommand4.ToolTipText = Resources.Command_LayerLabelFontColor_ToolTip_Text;
      layerLabelCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand4.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand4.ToolName = MapInfoConstants.ToolNameFontFgColor;
      layerLabelCommand4.Enabled = true;
      LayerLabelCommands.FontColorCommand = layerLabelCommand4;
      LayerLabelCommands.FontColorCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.FontColorCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand5 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (FontSize), nameof (FontSize), (InputGestureCollection) null);
      layerLabelCommand5.ToolTipDescription = Resources.Command_LayerLabelFontSize_ToolTip_Description;
      layerLabelCommand5.ToolTipText = Resources.Command_LayerLabelFontSize_ToolTip_Text;
      layerLabelCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand5.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand5.ToolName = MapInfoConstants.ToolNameFontSize;
      LayerLabelCommands.FontSizeCommand = layerLabelCommand5;
      LayerLabelCommands.FontSizeCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.FontSizeCommand);
      LayerLabelCommands.ModifyFontSizeCommand modifyFontSizeCommand1 = new LayerLabelCommands.ModifyFontSizeCommand(LayerLabelCommands._layerLabelFontController, nameof (IncreaseFontSize), nameof (IncreaseFontSize), (InputGestureCollection) null);
      modifyFontSizeCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/increaseFont_16x16.png";
      modifyFontSizeCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/increaseFont_32x32.png";
      modifyFontSizeCommand1.ToolTipDescription = Resources.Command_LayerLabelIncreaseFontSize_ToolTip_Description;
      modifyFontSizeCommand1.ToolTipText = Resources.Command_LayerLabelIncreaseFontSize_ToolTip_Text;
      modifyFontSizeCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      modifyFontSizeCommand1.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.IncreaseFontSizeCommand = modifyFontSizeCommand1;
      LayerLabelCommands.IncreaseFontSizeCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.IncreaseFontSizeCommand);
      LayerLabelCommands.ModifyFontSizeCommand modifyFontSizeCommand2 = new LayerLabelCommands.ModifyFontSizeCommand(LayerLabelCommands._layerLabelFontController, nameof (DecreaseFontSize), nameof (DecreaseFontSize), (InputGestureCollection) null);
      modifyFontSizeCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/decreaseFont_16x16.png";
      modifyFontSizeCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/decreaseFont_32x32.png";
      modifyFontSizeCommand2.ToolTipDescription = Resources.Command_LayerLabelDecreaseFontSize_ToolTip_Description;
      modifyFontSizeCommand2.ToolTipText = Resources.Command_LayerLabelDecreaseFontSize_ToolTip_Text;
      modifyFontSizeCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      modifyFontSizeCommand2.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.DecreaseFontSizeCommand = modifyFontSizeCommand2;
      LayerLabelCommands.DecreaseFontSizeCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.DecreaseFontSizeCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand6 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (FontFamily), nameof (FontFamily), (InputGestureCollection) null);
      layerLabelCommand6.ToolTipDescription = Resources.Command_LayerLabelFontFamily_ToolTip_Description;
      layerLabelCommand6.ToolTipText = Resources.Command_LayerLabelFontFamily_ToolTip_Text;
      layerLabelCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand6.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand6.ToolName = MapInfoConstants.ToolNameFontFamily;
      LayerLabelCommands.FontFamilyCommand = layerLabelCommand6;
      LayerLabelCommands.FontFamilyCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.FontFamilyCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand7 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Halo), nameof (Halo), (InputGestureCollection) null);
      layerLabelCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textHalo_16x16.png";
      layerLabelCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textHalo_32x32.png";
      layerLabelCommand7.ToolTipDescription = Resources.Command_LayerLabelHalo_ToolTip_Description;
      layerLabelCommand7.ToolTipText = Resources.Command_LayerLabelHalo_ToolTip_Text;
      layerLabelCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand7.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand7.ToolName = MapInfoConstants.ToolNameFontBgColor | MapInfoConstants.ToolNameFontHalo;
      LayerLabelCommands.HaloCommand = layerLabelCommand7;
      LayerLabelCommands.HaloCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.HaloCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand8 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Highlight), nameof (Highlight), (InputGestureCollection) null);
      layerLabelCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/backgroundFill_16x16.png";
      layerLabelCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/backgroundFill_32x32.png";
      layerLabelCommand8.ToolTipDescription = Resources.Command_LayerLabelHighlight_ToolTip_Description;
      layerLabelCommand8.ToolTipText = Resources.Command_LayerLabelHighlight_ToolTip_Text;
      layerLabelCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand8.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand8.ToolName = MapInfoConstants.ToolNameFontBgColor | MapInfoConstants.ToolNameFontHalo;
      LayerLabelCommands.HighlightCommand = layerLabelCommand8;
      LayerLabelCommands.HighlightCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.HighlightCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand9 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Italic), nameof (Italic), (InputGestureCollection) null);
      layerLabelCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/italic_16x16.png";
      layerLabelCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/italic_32x32.png";
      layerLabelCommand9.ToolTipDescription = Resources.Command_LayerLabelItalic_ToolTip_Description;
      layerLabelCommand9.ToolTipText = Resources.Command_LayerLabelItalic_ToolTip_Text;
      layerLabelCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand9.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand9.ToolName = MapInfoConstants.ToolNameFontItalic;
      LayerLabelCommands.ItalicCommand = layerLabelCommand9;
      LayerLabelCommands.ItalicCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.ItalicCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand10 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Shadow), nameof (Shadow), (InputGestureCollection) null);
      layerLabelCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textShadow_16x16.png";
      layerLabelCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textShadow_32x32.png";
      layerLabelCommand10.ToolTipDescription = Resources.Command_LayerLabelShadow_ToolTip_Description;
      layerLabelCommand10.ToolTipText = Resources.Command_LayerLabelShadow_ToolTip_Text;
      layerLabelCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand10.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand10.ToolName = MapInfoConstants.ToolNameFontShadow;
      LayerLabelCommands.ShadowCommand = layerLabelCommand10;
      LayerLabelCommands.ShadowCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.ShadowCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand11 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (Underline), nameof (Underline), (InputGestureCollection) null);
      layerLabelCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/underline_16x16.png";
      layerLabelCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/underline_32x32.png";
      layerLabelCommand11.ToolTipDescription = Resources.Command_LayerLabelUnderline_ToolTip_Description;
      layerLabelCommand11.ToolTipText = Resources.Command_LayerLabelUnderline_ToolTip_Text;
      layerLabelCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand11.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand11.ToolName = MapInfoConstants.ToolNameFontUnderline;
      LayerLabelCommands.UnderlineCommand = layerLabelCommand11;
      LayerLabelCommands.UnderlineCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.UnderlineCommand);
      LayerLabelCommands.LayerLabelCommand layerLabelCommand12 = new LayerLabelCommands.LayerLabelCommand(LayerLabelCommands._layerLabelFontController, nameof (BackgroundColor), nameof (BackgroundColor), (InputGestureCollection) null);
      layerLabelCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/backgroundFill_16x16.png";
      layerLabelCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/backgroundFill_32x32.png";
      layerLabelCommand12.ToolTipDescription = Resources.Command_LayerLabelBackgroundColor_ToolTip_Description;
      layerLabelCommand12.ToolTipText = Resources.Command_LayerLabelBackgroundColor_ToolTip_Text;
      layerLabelCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      layerLabelCommand12.Category = Resources.Command_Category_LayerLabelCommands;
      layerLabelCommand12.ToolName = MapInfoConstants.ToolNameFontBgColor;
      layerLabelCommand12.Enabled = true;
      LayerLabelCommands.BackgroundColorCommand = layerLabelCommand12;
      LayerLabelCommands.BackgroundColorCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.BackgroundColorCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand1 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (AllowDuplicate), nameof (AllowDuplicate), (InputGestureCollection) null);
      labelPropsCommand1.Text = Resources.Command_AllowDuplicate_Text;
      labelPropsCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_16x16.png";
      labelPropsCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_32x32.png";
      labelPropsCommand1.ToolTipDescription = Resources.Command_AllowDuplicate_ToolTip_Description;
      labelPropsCommand1.ToolTipText = Resources.Command_AllowDuplicate_ToolTip_Text;
      labelPropsCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand1.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.AllowDuplicateCommand = (MapInfoCommand) labelPropsCommand1;
      LayerLabelCommands.AllowDuplicateCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.AllowDuplicateCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand2 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (LabelPartialObject), nameof (LabelPartialObject), (InputGestureCollection) null);
      labelPropsCommand2.Text = Resources.Command_LabelPartialObject_Text;
      labelPropsCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_16x16.png";
      labelPropsCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_32x32.png";
      labelPropsCommand2.ToolTipDescription = Resources.Command_LabelPartialObject_ToolTip_Description;
      labelPropsCommand2.ToolTipText = Resources.Command_LabelPartialObject_ToolTip_Text;
      labelPropsCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand2.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LabelPartialObjectCommand = (MapInfoCommand) labelPropsCommand2;
      LayerLabelCommands.LabelPartialObjectCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.LabelPartialObjectCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand3 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (DiscardOverlapLabel), nameof (DiscardOverlapLabel), (InputGestureCollection) null);
      labelPropsCommand3.Text = Resources.Command_DiscardOverlapLabel_Text;
      labelPropsCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_16x16.png";
      labelPropsCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_32x32.png";
      labelPropsCommand3.ToolTipDescription = Resources.Command_DiscardOverlapLabel_ToolTip_Description;
      labelPropsCommand3.ToolTipText = Resources.Command_DiscardOverlapLabel_ToolTip_Text;
      labelPropsCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand3.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.DiscardOverlapLabelCommand = (MapInfoCommand) labelPropsCommand3;
      LayerLabelCommands.DiscardOverlapLabelCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.DiscardOverlapLabelCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand4 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (AllowOverlapLabel), nameof (AllowOverlapLabel), (InputGestureCollection) null);
      labelPropsCommand4.Text = Resources.Command_AllowOverlapLabel_Text;
      labelPropsCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_16x16.png";
      labelPropsCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_32x32.png";
      labelPropsCommand4.ToolTipDescription = Resources.Command_AllowOverlapLabel_ToolTip_Description;
      labelPropsCommand4.ToolTipText = Resources.Command_AllowOverlapLabel_ToolTip_Text;
      labelPropsCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand4.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.AllowOverlapLabelCommand = (MapInfoCommand) labelPropsCommand4;
      LayerLabelCommands.AllowOverlapLabelCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.AllowOverlapLabelCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand5 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (PositionRetry), nameof (PositionRetry), (InputGestureCollection) null);
      labelPropsCommand5.Text = Resources.Command_PositionRetry_Text;
      labelPropsCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_16x16.png";
      labelPropsCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/labelLeader_32x32.png";
      labelPropsCommand5.ToolTipDescription = Resources.Command_PositionRetry_ToolTip_Description;
      labelPropsCommand5.ToolTipText = Resources.Command_PositionRetry_ToolTip_Text;
      labelPropsCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand5.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.PositionRetryCommand = (MapInfoCommand) labelPropsCommand5;
      LayerLabelCommands.PositionRetryCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.PositionRetryCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand6 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (LabelPosition), nameof (LabelPosition), (InputGestureCollection) null);
      labelPropsCommand6.Text = Resources.Command_LabelPosition_Text;
      labelPropsCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/anchorPointTopLeft_16x16.png";
      labelPropsCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/anchorPointTopLeft_32x32.png";
      labelPropsCommand6.ToolTipDescription = Resources.Command_LabelPosition_ToolTip_Description;
      labelPropsCommand6.ToolTipText = Resources.Command_LabelPosition_ToolTip_Text;
      labelPropsCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand6.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LabelPositionCommand = (MapInfoCommand) labelPropsCommand6;
      LayerLabelCommands.LabelPositionCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.LabelPositionCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand7 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (LineLeaderNone), nameof (LineLeaderNone), (InputGestureCollection) null);
      labelPropsCommand7.Text = Resources.Command_LineLeaderNone_Text;
      labelPropsCommand7.ToolTipDescription = Resources.Command_LineLeaderNone_ToolTip_Description;
      labelPropsCommand7.ToolTipText = Resources.Command_LineLeaderNone_ToolTip_Text;
      labelPropsCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand7.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LineLeaderNoneCommand = (MapInfoCommand) labelPropsCommand7;
      LayerLabelCommands.LineLeaderNoneCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.LineLeaderNoneCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand8 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (LineLeaderSimple), nameof (LineLeaderSimple), (InputGestureCollection) null);
      labelPropsCommand8.Text = Resources.Command_LineLeaderSimple_Text;
      labelPropsCommand8.ToolTipDescription = Resources.Command_LineLeaderSimple_ToolTip_Description;
      labelPropsCommand8.ToolTipText = Resources.Command_LineLeaderSimple_ToolTip_Text;
      labelPropsCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand8.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LineLeaderSimpleCommand = (MapInfoCommand) labelPropsCommand8;
      LayerLabelCommands.LineLeaderSimpleCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.LineLeaderSimpleCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand9 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (LineLeaderArrow), nameof (LineLeaderArrow), (InputGestureCollection) null);
      labelPropsCommand9.Text = Resources.Command_LineLeaderArrow_Text;
      labelPropsCommand9.ToolTipDescription = Resources.Command_LineLeaderArrow_ToolTip_Description;
      labelPropsCommand9.ToolTipText = Resources.Command_LineLeaderArrow_ToolTip_Text;
      labelPropsCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand9.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LineLeaderArrowCommand = (MapInfoCommand) labelPropsCommand9;
      LayerLabelCommands.LineLeaderArrowCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.LineLeaderArrowCommand);
      LayerLabelCommands.LayerLabelLabelUsingCommand labelUsingCommand = new LayerLabelCommands.LayerLabelLabelUsingCommand(nameof (LabelUsing), nameof (LabelUsing), (InputGestureCollection) null);
      labelUsingCommand.ToolTipDescription = Resources.Command_LayerLabelLabelUsing_ToolTip_Description;
      labelUsingCommand.ToolTipText = Resources.Command_LayerLabelLabelUsing_ToolTip_Text;
      labelUsingCommand.ToolTipDisabledText = Resources.Command_Disabled_LabelUsing;
      labelUsingCommand.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.LabelUsingCommand = labelUsingCommand;
      LayerLabelCommands.LabelUsingCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.LabelUsingCommand);
      LayerLabelCommands.LayerLabelPropsCommand labelPropsCommand10 = new LayerLabelCommands.LayerLabelPropsCommand(nameof (AbbreviationsUsing), nameof (AbbreviationsUsing), (InputGestureCollection) null);
      labelPropsCommand10.Text = Resources.Command_AbbreviationsUsing_Text;
      labelPropsCommand10.ToolTipDescription = Resources.Command_LayerLabelAbbreviationsUsing_ToolTip_Description;
      labelPropsCommand10.ToolTipText = Resources.Command_LayerLabelAbbreviationsUsing_ToolTip_Text;
      labelPropsCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      labelPropsCommand10.Category = Resources.Command_Category_LayerLabelCommands;
      LayerLabelCommands.AbbreviationsUsingCommand = (MapInfoCommand) labelPropsCommand10;
      LayerLabelCommands.AbbreviationsUsingCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add(LayerLabelCommands.AbbreviationsUsingCommand);
      LayerLabelCommands.LabelPreviewOnOffCommand previewOnOffCommand = new LayerLabelCommands.LabelPreviewOnOffCommand(LayerLabelCommands._layerLabelFontController, "LabelPreviewOnOff", "LabelPreviewOnOff", (InputGestureCollection) null);
      previewOnOffCommand.Text = Resources.Command_LabelPreviewOnOff_Label;
      previewOnOffCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/previewOn_16x16.png";
      previewOnOffCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/previewOn_32x32.png";
      previewOnOffCommand.ToolTipDescription = Resources.Command_LabelPreviewOnOff_ToolTip_Description;
      previewOnOffCommand.ToolTipText = Resources.Command_LabelPreviewOnOff_ToolTip_Text;
      previewOnOffCommand.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayersWithLabelSupport;
      previewOnOffCommand.Category = Resources.Command_Category_LayerLabelCommands;
      previewOnOffCommand.Enabled = true;
      LayerLabelCommands.LabelPreviewCommand = previewOnOffCommand;
      LayerLabelCommands.LabelPreviewCommand.CreateScreenTip();
      LayerLabelCommands._commands.Add((MapInfoCommand) LayerLabelCommands.LabelPreviewCommand);
    }

    public static MapInfoCommand LineLeaderNone
    {
      get
      {
        return LayerLabelCommands.LineLeaderNoneCommand;
      }
    }

    public static MapInfoCommand LineLeaderSimple
    {
      get
      {
        return LayerLabelCommands.LineLeaderSimpleCommand;
      }
    }

    public static MapInfoCommand LineLeaderArrow
    {
      get
      {
        return LayerLabelCommands.LineLeaderArrowCommand;
      }
    }

    public static MapInfoCommand DiscardOverlapLabel
    {
      get
      {
        return LayerLabelCommands.DiscardOverlapLabelCommand;
      }
    }

    public static MapInfoCommand AllowOverlapLabel
    {
      get
      {
        return LayerLabelCommands.AllowOverlapLabelCommand;
      }
    }

    public static MapInfoCommand PositionRetry
    {
      get
      {
        return LayerLabelCommands.PositionRetryCommand;
      }
    }

    public static MapInfoCommand AllowDuplicate
    {
      get
      {
        return LayerLabelCommands.AllowDuplicateCommand;
      }
    }

    public static MapInfoCommand LabelPartialObject
    {
      get
      {
        return LayerLabelCommands.LabelPartialObjectCommand;
      }
    }

    public static MapInfoCommand LabelPosition
    {
      get
      {
        return LayerLabelCommands.LabelPositionCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand AllCaps
    {
      get
      {
        return LayerLabelCommands.AllCapsCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Bold
    {
      get
      {
        return LayerLabelCommands.BoldCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Expanded
    {
      get
      {
        return LayerLabelCommands.ExpandedCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand FontColor
    {
      get
      {
        return LayerLabelCommands.FontColorCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand FontSize
    {
      get
      {
        return LayerLabelCommands.FontSizeCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand FontFamily
    {
      get
      {
        return LayerLabelCommands.FontFamilyCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Halo
    {
      get
      {
        return LayerLabelCommands.HaloCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Highlight
    {
      get
      {
        return LayerLabelCommands.HighlightCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Italic
    {
      get
      {
        return LayerLabelCommands.ItalicCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Shadow
    {
      get
      {
        return LayerLabelCommands.ShadowCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand Underline
    {
      get
      {
        return LayerLabelCommands.UnderlineCommand;
      }
    }

    public static LayerLabelCommands.LayerLabelCommand BackgroundColor
    {
      get
      {
        return LayerLabelCommands.BackgroundColorCommand;
      }
    }

    public static LayerLabelCommands.ModifyFontSizeCommand IncreaseFontSize
    {
      get
      {
        return LayerLabelCommands.IncreaseFontSizeCommand;
      }
    }

    public static LayerLabelCommands.ModifyFontSizeCommand DecreaseFontSize
    {
      get
      {
        return LayerLabelCommands.DecreaseFontSizeCommand;
      }
    }

    public static IReadOnlyCollection<MapInfoCommand> Commands()
    {
      return (IReadOnlyCollection<MapInfoCommand>) LayerLabelCommands._commands;
    }

    public static LayerLabelFontController Controller
    {
      get
      {
        return LayerLabelCommands._layerLabelFontController;
      }
    }

    public static LayerLabelCommands.LayerLabelLabelUsingCommand LabelUsing
    {
      get
      {
        return LayerLabelCommands.LabelUsingCommand;
      }
    }

    public static MapInfoCommand AbbreviationsUsing
    {
      get
      {
        return LayerLabelCommands.AbbreviationsUsingCommand;
      }
    }

    public static LayerLabelCommands.LabelPreviewOnOffCommand LabelPreview
    {
      get
      {
        return LayerLabelCommands.LabelPreviewCommand;
      }
    }

    [Serializable]
    public class LayerLabelCommand : MapInfoCommand
    {
      private LayerLabelFontController _layerLabelFontController;

      public LayerLabelCommand(
        LayerLabelFontController layerLabelFontController,
        string text,
        string name,
        InputGestureCollection inputGestureCollection)
        : base(text, name, inputGestureCollection)
      {
        this._layerLabelFontController = layerLabelFontController;
      }

      public override bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
      {
        return this._layerLabelFontController.IsSelectedLayersDisplayType();
      }

      public override void Execute(object sender, ExecutedRoutedEventArgs e)
      {
        this._layerLabelFontController.UpdateSelectedLayers(this.ToolName);
      }

      public int ToolName { get; set; }
    }

    [Serializable]
    public class LabelPreviewOnOffCommand : MapInfoCommand
    {
      private LayerLabelFontController _layerLabelFontController;

      public LabelPreviewOnOffCommand(
        LayerLabelFontController layerLabelFontController,
        string text,
        string name,
        InputGestureCollection inputGestureCollection)
        : base(text, name, inputGestureCollection)
      {
        this._layerLabelFontController = layerLabelFontController;
      }

      public override bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
      {
        return true;
      }
    }

    [Serializable]
    public class ModifyFontSizeCommand : LayerLabelCommands.LayerLabelCommand
    {
      public ModifyFontSizeCommand(
        LayerLabelFontController layerLabelFontController,
        string text,
        string name,
        InputGestureCollection inputGestureCollection)
        : base(layerLabelFontController, text, name, inputGestureCollection)
      {
      }

      public override void Execute(object sender, ExecutedRoutedEventArgs e)
      {
        int fontSizeDiff = e.Parameter.ToString().Equals("increment") ? this.GetIncrementValue() : this.GetDecrementValue();
        LayerLabelCommands._layerLabelFontController.ModifyFontSizeOfSelectedLayers(fontSizeDiff);
      }

      private int GetIncrementValue()
      {
        int fontSize = LayerLabelCommands._layerLabelFontController.FontDefinition.FontSize.HasValue ? LayerLabelCommands._layerLabelFontController.FontDefinition.FontSize.Value : 8;
        return FontHelper.IncrementFontSize(fontSize) - fontSize;
      }

      private int GetDecrementValue()
      {
        int fontSize = LayerLabelCommands._layerLabelFontController.FontDefinition.FontSize.HasValue ? LayerLabelCommands._layerLabelFontController.FontDefinition.FontSize.Value : 8;
        return FontHelper.DecrementFontSize(fontSize) - fontSize;
      }
    }

    [Serializable]
    public class LayerLabelPropsCommand : MapInfoCommand
    {
      public LayerLabelPropsCommand(
        string text,
        string name,
        Type ownerType,
        InputGestureCollection inputGestureCollection)
        : base(text, name, ownerType, inputGestureCollection)
      {
      }

      public LayerLabelPropsCommand(
        string text,
        string name,
        InputGestureCollection inputGestureCollection)
        : base(text, name, inputGestureCollection)
      {
      }

      public override bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
      {
        if (LayerPropsController.LayerController != null)
          return LayerPropsController.LayerController.LabelsExist;
        return false;
      }

      public override void Execute(object sender, ExecutedRoutedEventArgs e)
      {
        if (LayerPropsController.LayerController == null)
          return;
        LayerPropsController.LayerController.ApplyChanges();
      }
    }

    [Serializable]
    public class LayerLabelLabelUsingCommand : MapInfoCommand
    {
      public LayerLabelLabelUsingCommand(
        string text,
        string name,
        Type ownerType,
        InputGestureCollection inputGestureCollection)
        : base(text, name, ownerType, inputGestureCollection)
      {
      }

      public LayerLabelLabelUsingCommand(
        string text,
        string name,
        InputGestureCollection inputGestureCollection)
        : base(text, name, inputGestureCollection)
      {
      }

      public override bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
      {
        if (LayerPropsController.LayerController != null)
          return LayerPropsController.LayerController.IsExpressionEnabled;
        return false;
      }
    }
  }
}
