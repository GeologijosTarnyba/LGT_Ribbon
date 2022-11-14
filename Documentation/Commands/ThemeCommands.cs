// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.ThemeCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Collections.Generic;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class ThemeCommands
  {
    private static ThemeBarCommand _thmBarStackedCommand;
    private static ThemeBarCommand _thmBarStackedGraduatedCommand;
    private static ThemeBarCommand _thmBarMultipleCommand;
    private static ThemeBarCommand _thmBarMultipleIndependentScaleCommand;
    private static ThemeBarCommand _thmBarMethodSquareRootCommand;
    private static ThemeBarCommand _thmBarMethodLogCommand;
    private static ThemeBarCommand _thmBarMethodConstantCommand;
    private static ThemeBarCommand _thmBarHeightCommand;
    private static ThemeBarCommand _thmBarWidthCommand;
    private static ThemeBarCommand _thmBarOrientationCommand;
    private static ThemeDotDensityCommand _thmDotDensitySetFieldCommand;
    private static ThemeDotDensityCommand _thmDotDensityCircleCommand;
    private static ThemeDotDensityCommand _thmDotDensitySquareCommand;
    private static ThemeDotDensityCommand _thmDotDensitySetSizeCommand;
    private static ThemeDotDensityCommand _thmDotDensitySetValuePerDotCommand;
    private static ThemeDotDensityCommand _thmDotDensitySetColorCommand;
    private static ThemeFileCommand _thmSaveAsTemplateCommand;
    private static ThemeFileCommand _thmSaveAsDefaultCommand;
    private static ThemeFileCommand _thmRemoveDefaultCommand;
    private static ThemeFileCommand _thmRefreshDataCommand;
    private static MapInfoCommand _individualValueColorPaletteColorChangedCommand;
    private static ThemeIndividualCommand _thmIndividualSetFieldCommand;
    private static PieThemeCommand _thmPieWholePiesCommand;
    private static PieThemeCommand _thmPieHalfPiesCommand;
    private static PieThemeCommand _thmPieGraduationSqRootCommand;
    private static PieThemeCommand _thmPieGraduationConstantCommand;
    private static PieThemeCommand _thmPieGraduationLogCommand;
    private static PieThemeCommand _thmPieGraduationNoneCommand;
    private static PieThemeCommand _thmPiePlacementCommand;
    private static PieThemeCommand _thmPieSizeCommand;
    private static PieThemeCommand _thmPieAngleCommand;
    private static ThemeRangeCommand _thmRangeSetFieldCommand;
    private static ThemeRangeCommand _thmRangeSetRangesCommand;
    private static ThemeRangeCommand _thmRangeSetRoundByCommand;
    private static ThemeRangeCommand _thmRangeEqualCountCommand;
    private static ThemeRangeCommand _thmRangeEqualRangeCommand;
    private static ThemeRangeCommand _thmRangeStdDevCommand;
    private static ThemeRangeCommand _thmRangeNaturalBreakCommand;
    private static ThemeRangeCommand _thmRangeQuantileCommand;
    private static ThemeRangeCommand _thmRangeCustomCommand;
    private static MapInfoCommand _thmRangeColorPaletteColorChangedCommand;
    private static ThemeSymbolCommand _thmSymbolSetFieldCommand;
    private static ThemeSymbolCommand _thmSymbolMethodSquareRootCommand;
    private static ThemeSymbolCommand _thmSymbolMethodLogCommand;
    private static ThemeSymbolCommand _thmSymbolMethodConstantCommand;
    private static ThemeSymbolCommand _thmSymbolShowNegativeValueSymbolCommand;
    private static ThemeSymbolCommand _thmSymbolSetNegativeSymbolCommand;
    private static ThemeSymbolCommand _thmSymbolSetPositiveSymbolCommand;
    private static ThemeSymbolCommand _thmSymbolSetSymbolSizeCommand;
    private static ThemeSymbolCommand _thmSymbolSetValueAtMaxCommand;
    private static ThemeCommand _thmCustomizeCommand;

    public static ThemeBarCommand ThmBarStacked
    {
      get
      {
        return ThemeCommands._thmBarStackedCommand;
      }
    }

    public static ThemeBarCommand ThmBarStackedGraduated
    {
      get
      {
        return ThemeCommands._thmBarStackedGraduatedCommand;
      }
    }

    public static ThemeBarCommand ThmBarMultiple
    {
      get
      {
        return ThemeCommands._thmBarMultipleCommand;
      }
    }

    public static ThemeBarCommand ThmBarMultipleIndependentScale
    {
      get
      {
        return ThemeCommands._thmBarMultipleIndependentScaleCommand;
      }
    }

    public static ThemeBarCommand ThmBarMethodLog
    {
      get
      {
        return ThemeCommands._thmBarMethodLogCommand;
      }
    }

    public static ThemeBarCommand ThmBarMethodSquareRoot
    {
      get
      {
        return ThemeCommands._thmBarMethodSquareRootCommand;
      }
    }

    public static ThemeBarCommand ThmBarMethodConstant
    {
      get
      {
        return ThemeCommands._thmBarMethodConstantCommand;
      }
    }

    public static ThemeBarCommand ThmBarHeight
    {
      get
      {
        return ThemeCommands._thmBarHeightCommand;
      }
    }

    public static ThemeBarCommand ThmBarWidth
    {
      get
      {
        return ThemeCommands._thmBarWidthCommand;
      }
    }

    public static ThemeBarCommand ThmBarOrientation
    {
      get
      {
        return ThemeCommands._thmBarOrientationCommand;
      }
    }

    private static void InitializeBarThemeCommands()
    {
      ThemeBarCommand themeBarCommand1 = new ThemeBarCommand(ThemeCommandId.ThmBarStacked, "", (InputGestureCollection) null);
      themeBarCommand1.Text = Resources.Command_ThmBarStacked_Label;
      themeBarCommand1.ToolTipDescription = Resources.Command_ThmBarStacked_ToolTip_Description;
      themeBarCommand1.ToolTipText = Resources.Command_ThmBarStacked_ToolTip_Text;
      themeBarCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarStacked_16x16.png";
      themeBarCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarStacked_32x32.png";
      themeBarCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarStackedCommand = themeBarCommand1;
      ThemeCommands._thmBarStackedCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarStacked);
      ThemeBarCommand themeBarCommand2 = new ThemeBarCommand(ThemeCommandId.ThmBarStackedGraduated, "", (InputGestureCollection) null);
      themeBarCommand2.Text = Resources.Command_ThmBarStackedGraduated_Label;
      themeBarCommand2.ToolTipDescription = Resources.Command_ThmBarStackedGraduated_ToolTip_Description;
      themeBarCommand2.ToolTipText = Resources.Command_ThmBarStackedGraduated_ToolTip_Text;
      themeBarCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarStackedGrad_16x16.png";
      themeBarCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarStackedGrad_32x32.png";
      themeBarCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarStackedGraduatedCommand = themeBarCommand2;
      ThemeCommands._thmBarStackedGraduatedCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarStackedGraduated);
      ThemeBarCommand themeBarCommand3 = new ThemeBarCommand(ThemeCommandId.ThmBarMultiple, "", (InputGestureCollection) null);
      themeBarCommand3.Text = Resources.Command_ThmBarMultiple_Label;
      themeBarCommand3.ToolTipDescription = Resources.Command_ThmBarMultiple_ToolTip_Description;
      themeBarCommand3.ToolTipText = Resources.Command_ThmBarMultiple_ToolTip_Text;
      themeBarCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarMulti_16x16.png";
      themeBarCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarMulti_32x32.png";
      themeBarCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarMultipleCommand = themeBarCommand3;
      ThemeCommands._thmBarMultipleCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarMultiple);
      ThemeBarCommand themeBarCommand4 = new ThemeBarCommand(ThemeCommandId.ThmBarMultipleIndependentScale, "", (InputGestureCollection) null);
      themeBarCommand4.Text = Resources.Command_ThmBarMultipleIndependentScale_Label;
      themeBarCommand4.ToolTipDescription = Resources.Command_ThmBarMultipleIndependentScale_ToolTip_Description;
      themeBarCommand4.ToolTipText = Resources.Command_ThmBarMultipleIndependentScale_ToolTip_Text;
      themeBarCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarMultiIndep_16x16.png";
      themeBarCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeBarMultiIndep_32x32.png";
      themeBarCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarMultipleIndependentScaleCommand = themeBarCommand4;
      ThemeCommands._thmBarMultipleIndependentScaleCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarMultipleIndependentScale);
      ThemeBarCommand themeBarCommand5 = new ThemeBarCommand(ThemeCommandId.ThmBarMethodSquareRoot, "", (InputGestureCollection) null);
      themeBarCommand5.Text = Resources.Command_ThmBarMethodSquareRoot_Label;
      themeBarCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_16x16.png";
      themeBarCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_32x32.png";
      themeBarCommand5.ToolTipDescription = Resources.Command_ThmBarMethodSquareRoot_ToolTip_Description;
      themeBarCommand5.ToolTipText = Resources.Command_ThmBarMethodSquareRoot_ToolTip_Text;
      themeBarCommand5.ToolTipDisabledText = Resources.Command_ThmBarMethodSquareRoot_ToolTip_DisabledText;
      themeBarCommand5.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarMethodSquareRootCommand = themeBarCommand5;
      ThemeCommands._thmBarMethodSquareRootCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarMethodSquareRoot);
      ThemeBarCommand themeBarCommand6 = new ThemeBarCommand(ThemeCommandId.ThmBarMethodConstant, "", (InputGestureCollection) null);
      themeBarCommand6.Text = Resources.Command_ThmBarMethodConstant_Label;
      themeBarCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_16x16.png";
      themeBarCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_32x32.png";
      themeBarCommand6.ToolTipDescription = Resources.Command_ThmBarMethodConstant_ToolTip_Description;
      themeBarCommand6.ToolTipText = Resources.Command_ThmBarMethodConstant_ToolTip_Text;
      themeBarCommand6.ToolTipDisabledText = Resources.Command_ThmBarMethodConstant_ToolTip_DisabledText;
      themeBarCommand6.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarMethodConstantCommand = themeBarCommand6;
      ThemeCommands._thmBarMethodConstantCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarMethodConstant);
      ThemeBarCommand themeBarCommand7 = new ThemeBarCommand(ThemeCommandId.ThmBarMethodLog, "", (InputGestureCollection) null);
      themeBarCommand7.Text = Resources.Command_ThmBarMethodLog_Label;
      themeBarCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_16x16.png";
      themeBarCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_32x32.png";
      themeBarCommand7.ToolTipDescription = Resources.Command_ThmBarMethodLog_ToolTip_Description;
      themeBarCommand7.ToolTipText = Resources.Command_ThmBarMethodLog_ToolTip_Text;
      themeBarCommand7.ToolTipDisabledText = Resources.Command_ThmBarMethodLog_ToolTip_DisabledText;
      themeBarCommand7.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarMethodLogCommand = themeBarCommand7;
      ThemeCommands._thmBarMethodLogCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarMethodLog);
      ThemeBarCommand themeBarCommand8 = new ThemeBarCommand(ThemeCommandId.ThmBarHeight, "", (InputGestureCollection) null);
      themeBarCommand8.Text = Resources.Command_ThmBarHeight_Label;
      themeBarCommand8.ToolTipDescription = Resources.Command_ThmBarHeight_ToolTip_Description;
      themeBarCommand8.ToolTipText = Resources.Command_ThmBarHeight_ToolTip_Text;
      themeBarCommand8.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarHeightCommand = themeBarCommand8;
      ThemeCommands._thmBarHeightCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarHeight);
      ThemeBarCommand themeBarCommand9 = new ThemeBarCommand(ThemeCommandId.ThmBarWidth, "", (InputGestureCollection) null);
      themeBarCommand9.Text = Resources.Command_ThmBarWidth_Label;
      themeBarCommand9.ToolTipDescription = Resources.Command_ThmBarWidth_ToolTip_Description;
      themeBarCommand9.ToolTipText = Resources.Command_ThmBarWidth_ToolTip_Text;
      themeBarCommand9.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarWidthCommand = themeBarCommand9;
      ThemeCommands._thmBarWidthCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarWidth);
      ThemeBarCommand themeBarCommand10 = new ThemeBarCommand(ThemeCommandId.ThmBarOrientation, "", (InputGestureCollection) null);
      themeBarCommand10.Text = Resources.Command_ThmBarOrientation_Label;
      themeBarCommand10.ToolTipDescription = Resources.Command_ThmBarOrientation_ToolTip_Description;
      themeBarCommand10.ToolTipText = Resources.Command_ThmBarOrientation_ToolTip_Text;
      themeBarCommand10.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmBarOrientationCommand = themeBarCommand10;
      ThemeCommands._thmBarOrientationCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmBarOrientation);
    }

    public static ThemeDotDensityCommand ThmDotDensitySetField
    {
      get
      {
        return ThemeCommands._thmDotDensitySetFieldCommand;
      }
    }

    public static ThemeDotDensityCommand ThmDotDensityCircleCommand
    {
      get
      {
        return ThemeCommands._thmDotDensityCircleCommand;
      }
    }

    public static ThemeDotDensityCommand ThmDotDensitySquareCommand
    {
      get
      {
        return ThemeCommands._thmDotDensitySquareCommand;
      }
    }

    public static ThemeDotDensityCommand ThmDotDensitySetSize
    {
      get
      {
        return ThemeCommands._thmDotDensitySetSizeCommand;
      }
    }

    public static ThemeDotDensityCommand ThmDotDensitySetValuePerDot
    {
      get
      {
        return ThemeCommands._thmDotDensitySetValuePerDotCommand;
      }
    }

    public static ThemeDotDensityCommand ThmDotDensitySetColor
    {
      get
      {
        return ThemeCommands._thmDotDensitySetColorCommand;
      }
    }

    private static void InitializeDotDensityThemeCommands()
    {
      ThemeDotDensityCommand dotDensityCommand1 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensitySetField, "", (InputGestureCollection) null);
      dotDensityCommand1.Text = Resources.Command_ThmDotDensitySetField_Label;
      dotDensityCommand1.ToolTipDescription = Resources.Command_ThmDotDensitySetField_ToolTip_Description;
      dotDensityCommand1.ToolTipText = Resources.Command_ThmDotDensitySetField_ToolTip_Text;
      dotDensityCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensitySetFieldCommand = dotDensityCommand1;
      ThemeCommands._thmDotDensitySetFieldCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmDotDensitySetField);
      ThemeDotDensityCommand dotDensityCommand2 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensityChartTypeCircle, "", (InputGestureCollection) null);
      dotDensityCommand2.Text = Resources.Command_ThmDotDensityChartTypeCircle_Label;
      dotDensityCommand2.ToolTipDescription = Resources.Command_ThmDotDensityChartTypeCircle_ToolTip_Description;
      dotDensityCommand2.ToolTipText = Resources.Command_ThmDotDensityChartTypeCircle_ToolTip_Text;
      dotDensityCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeDotCircle_16x16.png";
      dotDensityCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeDotCircle_32x32.png";
      dotDensityCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensityCircleCommand = dotDensityCommand2;
      ThemeCommands._thmDotDensityCircleCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmDotDensityCircleCommand);
      ThemeDotDensityCommand dotDensityCommand3 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensityChartTypeSquare, "", (InputGestureCollection) null);
      dotDensityCommand3.Text = Resources.Command_ThmDotDensityChartTypeSquare_Label;
      dotDensityCommand3.ToolTipDescription = Resources.Command_ThmDotDensityChartTypeSquare_ToolTip_Description;
      dotDensityCommand3.ToolTipText = Resources.Command_ThmDotDensityChartTypeSquare_ToolTip_Text;
      dotDensityCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeDotSquare_16x16.png";
      dotDensityCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeDotSquare_32x32.png";
      dotDensityCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensitySquareCommand = dotDensityCommand3;
      ThemeCommands._thmDotDensitySquareCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmDotDensitySquareCommand);
      ThemeDotDensityCommand dotDensityCommand4 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensitySetSize, "", (InputGestureCollection) null);
      dotDensityCommand4.Text = Resources.Command_ThmDotDensitySetSize_Label;
      dotDensityCommand4.ToolTipDescription = Resources.Command_ThmDotDensitySetSize_ToolTip_Description;
      dotDensityCommand4.ToolTipText = Resources.Command_ThmDotDensitySetSize_ToolTip_Text;
      dotDensityCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensitySetSizeCommand = dotDensityCommand4;
      ThemeCommands._thmDotDensitySetSizeCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmDotDensitySetSize);
      ThemeDotDensityCommand dotDensityCommand5 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensitySetMaxSizeValue, "", (InputGestureCollection) null);
      dotDensityCommand5.Text = Resources.Command_ThmDotDensitySetValuePerDot_Label;
      dotDensityCommand5.ToolTipDescription = Resources.Command_ThmDotDensitySetValuePerDot_ToolTip_Description;
      dotDensityCommand5.ToolTipText = Resources.Command_ThmDotDensitySetValuePerDot_ToolTip_Text;
      dotDensityCommand5.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensitySetValuePerDotCommand = dotDensityCommand5;
      ThemeCommands._thmDotDensitySetValuePerDotCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmDotDensitySetValuePerDot);
      ThemeDotDensityCommand dotDensityCommand6 = new ThemeDotDensityCommand(ThemeCommandId.ThmDotDensitySetColor, "", (InputGestureCollection) null);
      dotDensityCommand6.Text = "";
      dotDensityCommand6.ToolTipDescription = string.Empty;
      dotDensityCommand6.ToolTipText = string.Empty;
      dotDensityCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      dotDensityCommand6.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmDotDensitySetColorCommand = dotDensityCommand6;
      ThemeCommands._thmDotDensitySetColorCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmDotDensitySetColor);
    }

    public static ThemeFileCommand ThmSaveAsTemplate
    {
      get
      {
        return ThemeCommands._thmSaveAsTemplateCommand;
      }
    }

    public static ThemeFileCommand ThmSaveAsDefault
    {
      get
      {
        return ThemeCommands._thmSaveAsDefaultCommand;
      }
    }

    public static ThemeFileCommand ThmRemoveDefault
    {
      get
      {
        return ThemeCommands._thmRemoveDefaultCommand;
      }
    }

    public static ThemeFileCommand ThmRefreshData
    {
      get
      {
        return ThemeCommands._thmRefreshDataCommand;
      }
    }

    private static void InitializeThemeFileCommands()
    {
      ThemeFileCommand themeFileCommand1 = new ThemeFileCommand(ThemeCommandId.ThmSaveAsTemplate, "", (InputGestureCollection) null);
      themeFileCommand1.Text = Resources.Command_ThmSaveAsTemplate_Label;
      themeFileCommand1.ToolTipDescription = Resources.Command_ThmSaveAsTemplate_ToolTip_Description;
      themeFileCommand1.ToolTipText = Resources.Command_ThmSaveAsTemplate_ToolTip_Text;
      themeFileCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeFileCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/saveThemeTemplate_16x16.png";
      themeFileCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/saveThemeTemplate_32x32.png";
      themeFileCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSaveAsTemplateCommand = themeFileCommand1;
      ThemeCommands._thmSaveAsTemplateCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSaveAsTemplate);
      ThemeFileCommand themeFileCommand2 = new ThemeFileCommand(ThemeCommandId.ThmSaveAsDefault, "", (InputGestureCollection) null);
      themeFileCommand2.Text = Resources.Command_ThmSaveAsDefault_Label;
      themeFileCommand2.ToolTipDescription = Resources.Command_ThmSaveAsDefault_ToolTip_Description;
      themeFileCommand2.ToolTipText = Resources.Command_ThmSaveAsDefault_ToolTip_Text;
      themeFileCommand2.ToolTipDisabledText = Resources.Command_Disabled_CanSaveThemeAsDefault;
      themeFileCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/saveasDefaultTheme_16x16.png";
      themeFileCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/saveasDefaultTheme_32x32.png";
      themeFileCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSaveAsDefaultCommand = themeFileCommand2;
      ThemeCommands._thmSaveAsDefaultCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSaveAsDefault);
      ThemeFileCommand themeFileCommand3 = new ThemeFileCommand(ThemeCommandId.ThmRemoveDefault, "", (InputGestureCollection) null);
      themeFileCommand3.Text = Resources.Command_ThmRemoveDefault_Label;
      themeFileCommand3.ToolTipDescription = Resources.Command_ThmRemoveDefault_ToolTip_Description;
      themeFileCommand3.ToolTipText = Resources.Command_ThmRemoveDefault_ToolTip_Text;
      themeFileCommand3.ToolTipDisabledText = Resources.Command_Disabled_CanRemoveDefaultTheme;
      themeFileCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/removeDefaultTheme_16x16.png";
      themeFileCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/removeDefaultTheme_32x32.png";
      themeFileCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRemoveDefaultCommand = themeFileCommand3;
      ThemeCommands._thmRemoveDefaultCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRemoveDefault);
      ThemeFileCommand themeFileCommand4 = new ThemeFileCommand(ThemeCommandId.ThmRefreshData, "", (InputGestureCollection) null);
      themeFileCommand4.Text = Resources.Command_ThmRefreshData_Label;
      themeFileCommand4.ToolTipDescription = Resources.Command_ThmRefreshData_ToolTip_Description;
      themeFileCommand4.ToolTipText = Resources.Command_ThmRefreshData_ToolTip_Text;
      themeFileCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeFileCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/rescanThemeData_32x32.png";
      themeFileCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/rescanThemeData_16x16.png";
      themeFileCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRefreshDataCommand = themeFileCommand4;
      ThemeCommands._thmRefreshDataCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRefreshData);
    }

    public static ThemeIndividualCommand ThmIndividualSetField
    {
      get
      {
        return ThemeCommands._thmIndividualSetFieldCommand;
      }
    }

    public static MapInfoCommand ThmIndividualValueColorPaletteColorChanged
    {
      get
      {
        return ThemeCommands._individualValueColorPaletteColorChangedCommand;
      }
    }

    private static void InitializeIndividualThemeCommands()
    {
      ThemeIndividualCommand individualCommand1 = new ThemeIndividualCommand(ThemeCommandId.ThmIndividualSetField, "", (InputGestureCollection) null);
      individualCommand1.Text = Resources.Command_ThmIndividualSetField_Label;
      individualCommand1.ToolTipDescription = Resources.Command_ThmIndividualSetField_ToolTip_Description;
      individualCommand1.ToolTipText = Resources.Command_ThmIndividualSetField_ToolTip_Text;
      individualCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmIndividualSetFieldCommand = individualCommand1;
      ThemeCommands._thmIndividualSetFieldCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmIndividualSetField);
      ThemeIndividualCommand individualCommand2 = new ThemeIndividualCommand(ThemeCommandId.ThmIndividualValueColorChanged, "", (InputGestureCollection) null);
      individualCommand2.Text = Resources.Command_ThemeIndividualValueColorPalette_Caption;
      individualCommand2.ToolTipDescription = Resources.Command_ThemeIndividualValueColorPalette_ToolTip_Description;
      individualCommand2.ToolTipText = Resources.Command_ThemeIndividualValueColorPalette_ToolTip_Text;
      individualCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      individualCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePalettes_32x32.png";
      individualCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePalettes_16x16.png";
      individualCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._individualValueColorPaletteColorChangedCommand = (MapInfoCommand) individualCommand2;
      ThemeCommands._individualValueColorPaletteColorChangedCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add(ThemeCommands.ThmIndividualValueColorPaletteColorChanged);
    }

    public static PieThemeCommand ThmPieWholePies
    {
      get
      {
        return ThemeCommands._thmPieWholePiesCommand;
      }
    }

    public static PieThemeCommand ThmPieHalfPies
    {
      get
      {
        return ThemeCommands._thmPieHalfPiesCommand;
      }
    }

    public static PieThemeCommand ThmPieGraduationSqRoot
    {
      get
      {
        return ThemeCommands._thmPieGraduationSqRootCommand;
      }
    }

    public static PieThemeCommand ThmPieGraduationConstant
    {
      get
      {
        return ThemeCommands._thmPieGraduationConstantCommand;
      }
    }

    public static PieThemeCommand ThmPieGraduationLog
    {
      get
      {
        return ThemeCommands._thmPieGraduationLogCommand;
      }
    }

    public static PieThemeCommand ThmPieGraduationNone
    {
      get
      {
        return ThemeCommands._thmPieGraduationNoneCommand;
      }
    }

    public static PieThemeCommand ThmPiePlacement
    {
      get
      {
        return ThemeCommands._thmPiePlacementCommand;
      }
    }

    public static PieThemeCommand ThmPieSize
    {
      get
      {
        return ThemeCommands._thmPieSizeCommand;
      }
    }

    public static PieThemeCommand ThmPieAngle
    {
      get
      {
        return ThemeCommands._thmPieAngleCommand;
      }
    }

    private static void InitializePieThemeCommands()
    {
      PieThemeCommand pieThemeCommand1 = new PieThemeCommand(ThemeCommandId.ThmPieWholePies, "", (InputGestureCollection) null);
      pieThemeCommand1.Text = Resources.Command_ThmPieWholePies_Label;
      pieThemeCommand1.MenuItemText = Resources.Command_ThmPieWholePies_MenuItemText;
      pieThemeCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePieFull_16x16.PNG";
      pieThemeCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePieFull_32x32.PNG";
      pieThemeCommand1.ToolTipDescription = Resources.Command_ThmPieWholePies_ToolTip_Description;
      pieThemeCommand1.ToolTipText = Resources.Command_ThmPieWholePies_ToolTip_Text;
      pieThemeCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieWholePiesCommand = pieThemeCommand1;
      ThemeCommands._thmPieWholePiesCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieWholePiesCommand);
      PieThemeCommand pieThemeCommand2 = new PieThemeCommand(ThemeCommandId.ThmPieHalfPies, "", (InputGestureCollection) null);
      pieThemeCommand2.Text = Resources.Command_ThmPieHalfPies_Label;
      pieThemeCommand2.MenuItemText = Resources.Command_ThmPieHalfPies_MenuItemText;
      pieThemeCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePieHalf_16x16.png";
      pieThemeCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePieHalf_32x32.png";
      pieThemeCommand2.ToolTipDescription = Resources.Command_ThmPieHalfPies_ToolTip_Description;
      pieThemeCommand2.ToolTipText = Resources.Command_ThmPieHalfPies_ToolTip_Text;
      pieThemeCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieHalfPiesCommand = pieThemeCommand2;
      ThemeCommands._thmPieHalfPiesCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieHalfPiesCommand);
      PieThemeCommand pieThemeCommand3 = new PieThemeCommand(ThemeCommandId.ThmPieGraduationSqRoot, "", (InputGestureCollection) null);
      pieThemeCommand3.Text = Resources.Command_ThmPieGraduationSqRoot_Label;
      pieThemeCommand3.MenuItemText = Resources.Command_ThmPieGraduationSqRoot_MenuItemText;
      pieThemeCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_16x16.png";
      pieThemeCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_32x32.png";
      pieThemeCommand3.ToolTipDescription = Resources.Command_ThmPieGraduationSqRoot_ToolTip_Description;
      pieThemeCommand3.ToolTipText = Resources.Command_ThmPieGraduationSqRoot_ToolTip_Text;
      pieThemeCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieGraduationSqRootCommand = pieThemeCommand3;
      ThemeCommands._thmPieGraduationSqRootCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieGraduationSqRootCommand);
      PieThemeCommand pieThemeCommand4 = new PieThemeCommand(ThemeCommandId.ThmPieGraduationConstant, "", (InputGestureCollection) null);
      pieThemeCommand4.Text = Resources.Command_ThmPieGraduationConstant_Label;
      pieThemeCommand4.MenuItemText = Resources.Command_ThmPieGraduationConstant_MenuItemText;
      pieThemeCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_16x16.png";
      pieThemeCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_32x32.png";
      pieThemeCommand4.ToolTipDescription = Resources.Command_ThmPieGraduationConstant_ToolTip_Description;
      pieThemeCommand4.ToolTipText = Resources.Command_ThmPieGraduationConstant_ToolTip_Text;
      pieThemeCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieGraduationConstantCommand = pieThemeCommand4;
      ThemeCommands._thmPieGraduationConstantCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieGraduationConstantCommand);
      PieThemeCommand pieThemeCommand5 = new PieThemeCommand(ThemeCommandId.ThmPieGraduationLog, "", (InputGestureCollection) null);
      pieThemeCommand5.Text = Resources.Command_ThmPieGraduationLog_Label;
      pieThemeCommand5.MenuItemText = Resources.Command_ThmPieGraduationLog_MenuItemText;
      pieThemeCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_16x16.png";
      pieThemeCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_32x32.png";
      pieThemeCommand5.ToolTipDescription = Resources.Command_ThmPieGraduationLog_ToolTip_Description;
      pieThemeCommand5.ToolTipText = Resources.Command_ThmPieGraduationLog_ToolTip_Text;
      pieThemeCommand5.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieGraduationLogCommand = pieThemeCommand5;
      ThemeCommands._thmPieGraduationLogCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieGraduationLogCommand);
      PieThemeCommand pieThemeCommand6 = new PieThemeCommand(ThemeCommandId.ThmPieGraduationNone, "", (InputGestureCollection) null);
      pieThemeCommand6.Text = Resources.Command_ThmPieGraduationNone_Label;
      pieThemeCommand6.MenuItemText = Resources.Command_ThmPieGraduationNone_MenuItemText;
      pieThemeCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationNone_16x16.png";
      pieThemeCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationNone_32x32.png";
      pieThemeCommand6.ToolTipDescription = Resources.Command_ThmPieGraduationNone_ToolTip_Description;
      pieThemeCommand6.ToolTipText = Resources.Command_ThmPieGraduationNone_ToolTip_Text;
      pieThemeCommand6.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieGraduationNoneCommand = pieThemeCommand6;
      ThemeCommands._thmPieGraduationNoneCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieGraduationNoneCommand);
      PieThemeCommand pieThemeCommand7 = new PieThemeCommand(ThemeCommandId.ThmPieSize, "", (InputGestureCollection) null);
      pieThemeCommand7.ToolTipText = Resources.Command_ThmPieSize_ToolTip_Text;
      pieThemeCommand7.ToolTipDescription = Resources.Command_ThmPieSize_ToolTip_Description;
      pieThemeCommand7.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieSizeCommand = pieThemeCommand7;
      ThemeCommands._thmPieSizeCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieSizeCommand);
      PieThemeCommand pieThemeCommand8 = new PieThemeCommand(ThemeCommandId.ThmPieAngle, "", (InputGestureCollection) null);
      pieThemeCommand8.ToolTipText = Resources.Command_ThmPieAngle_ToolTip_Text;
      pieThemeCommand8.ToolTipDescription = Resources.Command_ThmPieAngle_ToolTip_Description;
      pieThemeCommand8.ToolTipDisabledText = Resources.Command_ThmPieAngle_ToolTip_DisabledText;
      pieThemeCommand8.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPieAngleCommand = pieThemeCommand8;
      ThemeCommands._thmPieAngleCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPieAngleCommand);
      PieThemeCommand pieThemeCommand9 = new PieThemeCommand(ThemeCommandId.ThmPiePlacement, "", (InputGestureCollection) null);
      pieThemeCommand9.ToolTipText = Resources.Command_ThmPiePlacement_ToolTip_Text;
      pieThemeCommand9.ToolTipDescription = Resources.Command_ThmPiePlacement_ToolTip_Description;
      pieThemeCommand9.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmPiePlacementCommand = pieThemeCommand9;
      ThemeCommands._thmPiePlacementCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands._thmPiePlacementCommand);
    }

    public static ThemeRangeCommand ThmRangeSetField
    {
      get
      {
        return ThemeCommands._thmRangeSetFieldCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeSetRanges
    {
      get
      {
        return ThemeCommands._thmRangeSetRangesCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeSetRoundBy
    {
      get
      {
        return ThemeCommands._thmRangeSetRoundByCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeEqualCount
    {
      get
      {
        return ThemeCommands._thmRangeEqualCountCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeEqualRange
    {
      get
      {
        return ThemeCommands._thmRangeEqualRangeCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeStdDev
    {
      get
      {
        return ThemeCommands._thmRangeStdDevCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeNaturalBreak
    {
      get
      {
        return ThemeCommands._thmRangeNaturalBreakCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeQuantile
    {
      get
      {
        return ThemeCommands._thmRangeQuantileCommand;
      }
    }

    public static ThemeRangeCommand ThmRangeCustom
    {
      get
      {
        return ThemeCommands._thmRangeCustomCommand;
      }
    }

    public static MapInfoCommand ThmRangeColorPaletteColorChanged
    {
      get
      {
        return ThemeCommands._thmRangeColorPaletteColorChangedCommand;
      }
    }

    private static void InitializeRangedThemeCommands()
    {
      ThemeRangeCommand themeRangeCommand1 = new ThemeRangeCommand(ThemeCommandId.ThmRangeSetField, "", (InputGestureCollection) null);
      themeRangeCommand1.Text = Resources.Command_ThmRangeSetField_Label;
      themeRangeCommand1.ToolTipDescription = Resources.Command_ThmRangeSetField_ToolTip_Description;
      themeRangeCommand1.ToolTipText = Resources.Command_ThmRangeSetField_ToolTip_Text;
      themeRangeCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeSetFieldCommand = themeRangeCommand1;
      ThemeCommands._thmRangeSetFieldCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeSetField);
      ThemeRangeCommand themeRangeCommand2 = new ThemeRangeCommand(ThemeCommandId.ThmRangeSetRanges, "", (InputGestureCollection) null);
      themeRangeCommand2.Text = Resources.Command_ThmRangeSetRanges_Label;
      themeRangeCommand2.ToolTipDescription = Resources.Command_ThmRangeSetRanges_ToolTip_Description;
      themeRangeCommand2.ToolTipText = Resources.Command_ThmRangeSetRanges_ToolTip_Text;
      themeRangeCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeSetRangesCommand = themeRangeCommand2;
      ThemeCommands._thmRangeSetRangesCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeSetRanges);
      ThemeRangeCommand themeRangeCommand3 = new ThemeRangeCommand(ThemeCommandId.ThmRangeSetRoundBy, "", (InputGestureCollection) null);
      themeRangeCommand3.Text = Resources.Command_ThmRangeSetRoundByCommand_Label;
      themeRangeCommand3.ToolTipDescription = Resources.Command_ThmRangeSetRoundByCommand_ToolTip_Description;
      themeRangeCommand3.ToolTipText = Resources.Command_ThmRangeSetRoundByCommand_ToolTip_Text;
      themeRangeCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeSetRoundByCommand = themeRangeCommand3;
      ThemeCommands._thmRangeSetRoundByCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeSetRoundBy);
      ThemeRangeCommand themeRangeCommand4 = new ThemeRangeCommand(ThemeCommandId.ThmRangeEqualCount, "", (InputGestureCollection) null);
      themeRangeCommand4.Text = Resources.Command_ThmRangeEqualCount_Label;
      themeRangeCommand4.ToolTipDescription = Resources.Command_ThmRangeEqualCount_ToolTip_Description;
      themeRangeCommand4.ToolTipText = Resources.Command_ThmRangeEqualCount_ToolTip_Text;
      themeRangeCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedEqualCount_32x32.png";
      themeRangeCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedEqualCount_16x16.png";
      themeRangeCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeEqualCountCommand = themeRangeCommand4;
      ThemeCommands._thmRangeEqualCountCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeEqualCount);
      ThemeRangeCommand themeRangeCommand5 = new ThemeRangeCommand(ThemeCommandId.ThmRangeEqualRange, "", (InputGestureCollection) null);
      themeRangeCommand5.Text = Resources.Command_ThmRangeEqualRanges_Label;
      themeRangeCommand5.ToolTipDescription = Resources.Command_ThmRangeEqualRanges_ToolTip_Description;
      themeRangeCommand5.ToolTipText = Resources.Command_ThmRangeEqualRanges_ToolTip_Text;
      themeRangeCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedEqualRange_32x32.png";
      themeRangeCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedEqualRange_16x16.png";
      themeRangeCommand5.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeEqualRangeCommand = themeRangeCommand5;
      ThemeCommands._thmRangeEqualRangeCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeEqualRange);
      ThemeRangeCommand themeRangeCommand6 = new ThemeRangeCommand(ThemeCommandId.ThmRangeStdDev, "", (InputGestureCollection) null);
      themeRangeCommand6.Text = Resources.Command_ThmRangeStdDev_Label;
      themeRangeCommand6.ToolTipDescription = Resources.Command_ThmRangeStdDev_ToolTip_Description;
      themeRangeCommand6.ToolTipText = Resources.Command_ThmRangeStdDev_ToolTip_Text;
      themeRangeCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeRangeCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedStdDev_32x32.png";
      themeRangeCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedStdDev_16x16.png";
      themeRangeCommand6.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeStdDevCommand = themeRangeCommand6;
      ThemeCommands._thmRangeStdDevCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeStdDev);
      ThemeRangeCommand themeRangeCommand7 = new ThemeRangeCommand(ThemeCommandId.ThmRangeNaturalBreak, "", (InputGestureCollection) null);
      themeRangeCommand7.Text = Resources.Command_ThmRangeNaturalBreak_Label;
      themeRangeCommand7.ToolTipDescription = Resources.Command_ThmRangeNaturalBreak_ToolTip_Description;
      themeRangeCommand7.ToolTipText = Resources.Command_ThmRangeNaturalBreak_ToolTip_Text;
      themeRangeCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedNatBreak_32x32.png";
      themeRangeCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedNatBreak_16x16.png";
      themeRangeCommand7.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeNaturalBreakCommand = themeRangeCommand7;
      ThemeCommands._thmRangeNaturalBreakCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeNaturalBreak);
      ThemeRangeCommand themeRangeCommand8 = new ThemeRangeCommand(ThemeCommandId.ThmRangeQuantile, "", (InputGestureCollection) null);
      themeRangeCommand8.Text = Resources.Command_ThmRangeQuantile_Label;
      themeRangeCommand8.ToolTipDescription = Resources.Command_ThmRangeQuantile_ToolTip_Description;
      themeRangeCommand8.ToolTipText = Resources.Command_ThmRangeQuantile_ToolTip_Text;
      themeRangeCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeRangeCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedQuantile_32x32.png";
      themeRangeCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedQuantile_16x16.png";
      themeRangeCommand8.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeQuantileCommand = themeRangeCommand8;
      ThemeCommands._thmRangeQuantileCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeQuantile);
      ThemeRangeCommand themeRangeCommand9 = new ThemeRangeCommand(ThemeCommandId.ThmRangeCustom, "", (InputGestureCollection) null);
      themeRangeCommand9.Text = Resources.Command_ThmRangeCustom_Label;
      themeRangeCommand9.ToolTipDescription = Resources.Command_ThmRangeCustom_ToolTip_Description;
      themeRangeCommand9.ToolTipText = Resources.Command_ThmRangeCustom_ToolTip_Text;
      themeRangeCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeRangeCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedCustom_32x32.png";
      themeRangeCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeRangedCustom_16x16.png";
      themeRangeCommand9.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeCustomCommand = themeRangeCommand9;
      ThemeCommands._thmRangeCustomCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmRangeCustom);
      ThemeRangeCommand themeRangeCommand10 = new ThemeRangeCommand(ThemeCommandId.ThemeColorPaletteColorChanged, "", (InputGestureCollection) null);
      themeRangeCommand10.Text = Resources.Command_ThemeRangedColorPalette_Caption;
      themeRangeCommand10.ToolTipDescription = Resources.Command_ThemeRangedColorPalette_ToolTip_Description;
      themeRangeCommand10.ToolTipText = Resources.Command_ThemeRangedColorPalette_ToolTip_Text;
      themeRangeCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedThematic;
      themeRangeCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePalettes_32x32.png";
      themeRangeCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themePalettes_16x16.png";
      themeRangeCommand10.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmRangeColorPaletteColorChangedCommand = (MapInfoCommand) themeRangeCommand10;
      ThemeCommands._thmRangeColorPaletteColorChangedCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add(ThemeCommands.ThmRangeColorPaletteColorChanged);
    }

    public static ThemeSymbolCommand ThmSymbolSetField
    {
      get
      {
        return ThemeCommands._thmSymbolSetFieldCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolMethodLog
    {
      get
      {
        return ThemeCommands._thmSymbolMethodLogCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolMethodSquareRoot
    {
      get
      {
        return ThemeCommands._thmSymbolMethodSquareRootCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolMethodConstant
    {
      get
      {
        return ThemeCommands._thmSymbolMethodConstantCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolShowNegativeValueSymbol
    {
      get
      {
        return ThemeCommands._thmSymbolShowNegativeValueSymbolCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolSetNegativeSymbol
    {
      get
      {
        return ThemeCommands._thmSymbolSetNegativeSymbolCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolSetPositiveSymbol
    {
      get
      {
        return ThemeCommands._thmSymbolSetPositiveSymbolCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolSetSymbolSize
    {
      get
      {
        return ThemeCommands._thmSymbolSetSymbolSizeCommand;
      }
    }

    public static ThemeSymbolCommand ThmSymbolSetValueAtMax
    {
      get
      {
        return ThemeCommands._thmSymbolSetValueAtMaxCommand;
      }
    }

    private static void InitializeSymbolThemeCommands()
    {
      ThemeSymbolCommand themeSymbolCommand1 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolSetField, "", (InputGestureCollection) null);
      themeSymbolCommand1.Text = Resources.Command_ThmSymbolSetField_Label;
      themeSymbolCommand1.ToolTipDescription = Resources.Command_ThmSymbolSetField_ToolTip_Description;
      themeSymbolCommand1.ToolTipText = Resources.Command_ThmSymbolSetField_ToolTip_Text;
      themeSymbolCommand1.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolSetFieldCommand = themeSymbolCommand1;
      ThemeCommands._thmSymbolSetFieldCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolSetField);
      ThemeSymbolCommand themeSymbolCommand2 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolMethodSquareRoot, "", (InputGestureCollection) null);
      themeSymbolCommand2.Text = Resources.Command_ThmSymbolMethodSquareRoot_Label;
      themeSymbolCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_16x16.png";
      themeSymbolCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationSqrt_32x32.png";
      themeSymbolCommand2.ToolTipDescription = Resources.Command_ThmSymbolMethodSquareRoot_ToolTip_Description;
      themeSymbolCommand2.ToolTipText = Resources.Command_ThmSymbolMethodSquareRoot_ToolTip_Text;
      themeSymbolCommand2.ToolTipDisabledText = Resources.Command_ThmSymbolMethodSquareRoot_ToolTip_DisabledText;
      themeSymbolCommand2.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolMethodSquareRootCommand = themeSymbolCommand2;
      ThemeCommands._thmSymbolMethodSquareRootCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolMethodSquareRoot);
      ThemeSymbolCommand themeSymbolCommand3 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolMethodConstant, "", (InputGestureCollection) null);
      themeSymbolCommand3.Text = Resources.Command_ThmSymbolMethodConstant_Label;
      themeSymbolCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_16x16.png";
      themeSymbolCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationConstant_32x32.png";
      themeSymbolCommand3.ToolTipDescription = Resources.Command_ThmSymbolMethodConstant_ToolTip_Description;
      themeSymbolCommand3.ToolTipText = Resources.Command_ThmSymbolMethodConstant_ToolTip_Text;
      themeSymbolCommand3.ToolTipDisabledText = Resources.Command_ThmSymbolMethodConstant_ToolTip_DisabledText;
      themeSymbolCommand3.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolMethodConstantCommand = themeSymbolCommand3;
      ThemeCommands._thmSymbolMethodConstantCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolMethodConstant);
      ThemeSymbolCommand themeSymbolCommand4 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolMethodLog, "", (InputGestureCollection) null);
      themeSymbolCommand4.Text = Resources.Command_ThmSymbolMethodLog_Label;
      themeSymbolCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_16x16.png";
      themeSymbolCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeGraduationLog_32x32.png";
      themeSymbolCommand4.ToolTipDescription = Resources.Command_ThmSymbolMethodLog_ToolTip_Description;
      themeSymbolCommand4.ToolTipText = Resources.Command_ThmSymbolMethodLog_ToolTip_Text;
      themeSymbolCommand4.ToolTipDisabledText = Resources.Command_ThmSymbolMethodLog_ToolTip_DisabledText;
      themeSymbolCommand4.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolMethodLogCommand = themeSymbolCommand4;
      ThemeCommands._thmSymbolMethodLogCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolMethodLog);
      ThemeSymbolCommand themeSymbolCommand5 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolShowNegativeValueSymbol, "", (InputGestureCollection) null);
      themeSymbolCommand5.Text = Resources.Command_ThmSymbolShowNegativeValueSymbol_Label;
      themeSymbolCommand5.ToolTipDescription = Resources.Command_ThmSymbolShowNegativeValueSymbol_ToolTip_Description;
      themeSymbolCommand5.ToolTipText = Resources.Command_ThmSymbolShowNegativeValueSymbol_ToolTip_Text;
      themeSymbolCommand5.ToolTipDisabledText = Resources.Command_ThmSymbolShowNegativeValueSymbol_ToolTip_DisabledText;
      themeSymbolCommand5.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolShowNegativeValueSymbolCommand = themeSymbolCommand5;
      ThemeCommands._thmSymbolShowNegativeValueSymbolCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolShowNegativeValueSymbol);
      ThemeSymbolCommand themeSymbolCommand6 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolSetNegativeSymbol, "", (InputGestureCollection) null);
      themeSymbolCommand6.Text = Resources.Command_ThmSymbolSetNegativeSymbol_Label;
      themeSymbolCommand6.ToolTipDescription = Resources.Command_ThmSymbolSetNegativeSymbol_ToolTip_Description;
      themeSymbolCommand6.ToolTipText = Resources.Command_ThmSymbolSetNegativeSymbol_ToolTip_Text;
      themeSymbolCommand6.ToolTipDisabledText = Resources.Command_ThmSymbolSetNegativeSymbol_ToolTip_DisabledText;
      themeSymbolCommand6.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolSetNegativeSymbolCommand = themeSymbolCommand6;
      ThemeCommands._thmSymbolSetNegativeSymbolCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolSetNegativeSymbol);
      ThemeSymbolCommand themeSymbolCommand7 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolSetPositiveSymbol, "", (InputGestureCollection) null);
      themeSymbolCommand7.Text = Resources.Command_ThmSymbolSetPositiveSymbol_Label;
      themeSymbolCommand7.ToolTipDescription = Resources.Command_ThmSymbolSetPositiveSymbol_ToolTip_Description;
      themeSymbolCommand7.ToolTipText = Resources.Command_ThmSymbolSetPositiveSymbol_ToolTip_Text;
      themeSymbolCommand7.ToolTipDisabledText = Resources.Command_ThmSymbolSetPositiveSymbol_ToolTip_DisabledText;
      themeSymbolCommand7.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolSetPositiveSymbolCommand = themeSymbolCommand7;
      ThemeCommands._thmSymbolSetPositiveSymbolCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolSetPositiveSymbol);
      ThemeSymbolCommand themeSymbolCommand8 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolSetSymbolSize, "", (InputGestureCollection) null);
      themeSymbolCommand8.Text = Resources.Command_ThmSymbolSetSymbolSize_Label;
      themeSymbolCommand8.ToolTipDescription = Resources.Command_ThmSymbolSetSymbolSize_ToolTip_Description;
      themeSymbolCommand8.ToolTipText = Resources.Command_ThmSymbolSetSymbolSize_ToolTip_Text;
      themeSymbolCommand8.ToolTipDisabledText = Resources.Command_ThemeStyle_ToolTip_DisabledText;
      themeSymbolCommand8.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolSetSymbolSizeCommand = themeSymbolCommand8;
      ThemeCommands._thmSymbolSetSymbolSizeCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolSetSymbolSize);
      ThemeSymbolCommand themeSymbolCommand9 = new ThemeSymbolCommand(ThemeCommandId.ThmSymbolSetValueAtMax, "", (InputGestureCollection) null);
      themeSymbolCommand9.Text = Resources.Command_ThmSymbolSetValueAtMax_Label;
      themeSymbolCommand9.ToolTipDescription = Resources.Command_ThmSymbolSetValueAtMax_ToolTip_Description;
      themeSymbolCommand9.ToolTipText = Resources.Command_ThmSymbolSetValueAtMax_ToolTip_Text;
      themeSymbolCommand9.ToolTipDisabledText = Resources.Command_ThemeStyle_ToolTip_DisabledText;
      themeSymbolCommand9.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmSymbolSetValueAtMaxCommand = themeSymbolCommand9;
      ThemeCommands._thmSymbolSetValueAtMaxCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmSymbolSetValueAtMax);
    }

    public static ThemeCommand ThmCustomize
    {
      get
      {
        return ThemeCommands._thmCustomizeCommand;
      }
    }

    public static List<MapInfoCommand> ThemeCommandList { get; set; }

    static ThemeCommands()
    {
      ThemeCommands.ThemeCommandList = new List<MapInfoCommand>();
      ThemeCommands.InitializeThemeCommands();
      ThemeCommands.InitializeThemeFileCommands();
      ThemeCommands.InitializeRangedThemeCommands();
      ThemeCommands.InitializePieThemeCommands();
      ThemeCommands.InitializeBarThemeCommands();
      ThemeCommands.InitializeSymbolThemeCommands();
      ThemeCommands.InitializeIndividualThemeCommands();
      ThemeCommands.InitializeDotDensityThemeCommands();
    }

    private static void InitializeThemeCommands()
    {
      ThemeCommand themeCommand = new ThemeCommand(ThemeCommandId.ThmCustomize, "", (InputGestureCollection) null);
      themeCommand.Text = Resources.Command_ThemeStyle_Label;
      themeCommand.ToolTipDescription = Resources.Command_ThemeStyle_ToolTip_Description;
      themeCommand.ToolTipText = Resources.Command_ThemeStyle_ToolTip_Text;
      themeCommand.ToolTipDisabledText = Resources.Command_ThemeStyle_ToolTip_DisabledText;
      themeCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeCustomize_16x16.png";
      themeCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Thematics/themeCustomize_32x32.png";
      themeCommand.Enabled = true;
      themeCommand.Category = Resources.Command_Category_ThemeCommands;
      ThemeCommands._thmCustomizeCommand = themeCommand;
      ThemeCommands._thmCustomizeCommand.CreateScreenTip();
      ThemeCommands.ThemeCommandList.Add((MapInfoCommand) ThemeCommands.ThmCustomize);
    }
  }
}
