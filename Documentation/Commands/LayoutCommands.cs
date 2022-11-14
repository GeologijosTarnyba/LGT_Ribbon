// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LayoutCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class LayoutCommands
  {
    private static readonly LayoutDesignerCommands AddBrowserFrameCommand;
    private static readonly LayoutDesignerCommands AddHorizontalGuidelineCommand;
    private static readonly LayoutDesignerCommands AddMapFrameCommand;
    private static readonly LayoutDesignerCommands AddVerticalGuidelineCommand;
    private static readonly LayoutDesignerCommands AlignHorizontalCenterCommand;
    private static readonly LayoutDesignerCommands AlignVerticalCenterCommand;
    private static readonly LayoutDesignerCommands ChangeFrameStyleCommand;
    private static readonly LayoutDesignerCommands DisableGuidelinesCommand;
    private static readonly LayoutDesignerCommands InsertImageCommand;
    private static readonly LayoutDesignerCommands InsertTextCommand;
    private static readonly LayoutDesignerCommands LineSpacingDoubleCommand;
    private static readonly LayoutDesignerCommands LineSpacingOnePointFiveCommand;
    private static readonly LayoutDesignerCommands LineSpacingSingleCommand;
    private static readonly LayoutDesignerCommands LineStyleCommand;
    private static readonly LayoutDesignerCommands SymbolStyleCommand;
    private static readonly LayoutDesignerCommands PanCommand;
    private static readonly LayoutDesignerCommands RegionStyleCommand;
    private static readonly LayoutDesignerCommands RemoveGuidelinesCommand;
    private static readonly MapBasicRunMenuCommand NewEmptyFrameCommand;
    private static readonly MapBasicRunMenuCommand RemoveSelectedFramesContentCommand;
    private static readonly MapBasicRunMenuCommand RemoveSelectedItemsCommand;
    private static readonly LayoutDesignerCommands SelectCommand;
    private static readonly LayoutDesignerCommands SnapToBottomCommand;
    private static readonly LayoutDesignerCommands SnapToGridCommand;
    private static readonly LayoutDesignerCommands SnapToLeftCommand;
    private static readonly LayoutDesignerCommands SnapToRightCommand;
    private static readonly LayoutDesignerCommands SnapToTopCommand;
    private static readonly LayoutDesignerCommands TextJustifyCenterCommand;
    private static readonly LayoutDesignerCommands TextJustifyLeftCommand;
    private static readonly LayoutDesignerCommands TextJustifyRightCommand;
    private static readonly LayoutDesignerCommands ToggleGridLinesCommand;
    private static readonly LayoutDesignerCommands ZoomInCommand;
    private static readonly LayoutDesignerCommands ZoomOutCommand;
    private static readonly LayoutDesignerCommands AddSymbolCommand;
    private static readonly LayoutDesignerCommands AddLineCommand;
    private static readonly LayoutDesignerCommands AddEllipseCommand;
    private static readonly LayoutDesignerCommands AddRectangleCommand;
    private static readonly LayoutDesignerCommands AddRoundedRectangleCommand;
    private static readonly MapInfoCommand LayoutPageSetupCommand;
    private static readonly MapInfoCommand FitInWindowCommand;
    private static readonly MapInfoCommand ZoomToHundredPercentCommand;
    private static readonly MapInfoCommand ActivateLayoutFrameCommand;
    private static readonly MapInfoCommand SendToBackCommand;
    private static readonly MapInfoCommand BringToFrontCommand;
    private static readonly MapInfoCommand FramePropertiesCommand;
    private static readonly MapInfoCommand LayoutTextStyleCommand;
    private static readonly MapInfoCommand AddLegendsCommand;
    private static readonly MapInfoCommand RefreshLegendsCommand;
    private static readonly MapInfoCommand ModifyThematicCommand;
    private static readonly MapInfoCommand RotateFrameByZeroDegreeCommand;
    private static readonly MapInfoCommand RotateFrameByNinetyDegreeCommand;
    private static readonly MapInfoCommand RotateFrameByTwoSeventyDegreeCommand;
    private static readonly LayoutDesignerCommands AddPolygonCommand;
    private static readonly LayoutDesignerCommands AddPolylineCommand;
    private static readonly MapBasicRunMenuCommand StackUndoCommand;
    private static readonly MapBasicRunMenuCommand StackRedoCommand;
    private static readonly MapBasicRunMenuCommand ToggleSmartGuidesCommand;

    static LayoutCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(2905, nameof (ActivateLayoutFrame), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_ActivateLayoutFrame_Label;
      basicRunMenuCommand1.MenuItemText = Resources.Command_ActivateLayoutFrame_MenuItemText;
      basicRunMenuCommand1.MenuItemToggleText = Resources.Command_ActivateLayoutFrame_MenuItemToggleText;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frame_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frame_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_ActivateLayoutFrame_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_ActivateLayoutFrame_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand1.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2905));
      LayoutCommands.ActivateLayoutFrameCommand = (MapInfoCommand) basicRunMenuCommand1;
      LayoutCommands.ActivateLayoutFrameCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(2904, nameof (FitInWindow), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_FitInWindow_Label;
      basicRunMenuCommand2.MenuItemText = Resources.Command_FitInWindow_MenuItemText;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/fit-to-window_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/fit-to-window_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_FitInWindow_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_FitInWindow_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand2.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2904));
      LayoutCommands.FitInWindowCommand = (MapInfoCommand) basicRunMenuCommand2;
      LayoutCommands.FitInWindowCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(2929, nameof (ZoomToHundredPercent), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_ZoomToHundredPercent_Label;
      basicRunMenuCommand3.MenuItemText = Resources.Command_ZoomToHundredPercent_MenuItemText;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoom100_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoom100_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_ZoomToHundredPercent_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_ZoomToHundredPercent_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand3.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2929));
      LayoutCommands.ZoomToHundredPercentCommand = (MapInfoCommand) basicRunMenuCommand3;
      LayoutCommands.ZoomToHundredPercentCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(2908, nameof (FrameProperties), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_FrameProperties_Label;
      basicRunMenuCommand4.MenuItemText = Resources.Command_FrameProperties_MenuItemText;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frameStyle_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frameStyle_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_FrameProperties_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_FrameProperties_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand4.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2908));
      LayoutCommands.FramePropertiesCommand = (MapInfoCommand) basicRunMenuCommand4;
      LayoutCommands.FramePropertiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(2910, nameof (AddLegends), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_AddLegends_Label;
      basicRunMenuCommand5.MenuItemText = Resources.Command_AddLegends_MenuItemText;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/insertLegend_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/insertLegend_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_AddLegends_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_AddLegends_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_MapLegend;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand5.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(827));
      LayoutCommands.AddLegendsCommand = (MapInfoCommand) basicRunMenuCommand5;
      LayoutCommands.AddLegendsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(2911, nameof (RefreshLegends), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_RefreshLegends_Label;
      basicRunMenuCommand6.MenuItemText = Resources.Command_RefreshLegends_MenuItemText;
      basicRunMenuCommand6.SmallIcon = (string) null;
      basicRunMenuCommand6.LargeIcon = (string) null;
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_RefreshLegends_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_RefreshLegends_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand6.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2911));
      LayoutCommands.RefreshLegendsCommand = (MapInfoCommand) basicRunMenuCommand6;
      LayoutCommands.RefreshLegendsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(2912, nameof (ModifyThematic), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_ModifyThematic_Label;
      basicRunMenuCommand7.MenuItemText = Resources.Command_LegendModifyTheme_MenuItemText;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyTheme_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Legend/modifyTheme_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_ModifyThematic_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_ModifyThematic_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand7.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2912));
      LayoutCommands.ModifyThematicCommand = (MapInfoCommand) basicRunMenuCommand7;
      LayoutCommands.ModifyThematicCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands1 = new LayoutDesignerCommands("LayoutInsertSymbol", (InputGestureCollection) null, "AddShapeCommand", (object) "DrawSymbolClick");
      designerCommands1.Text = Resources.Command_LayoutInsertSymbol_Label;
      designerCommands1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbol_16x16.png";
      designerCommands1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbol_32X32.png";
      designerCommands1.ToolTipDescription = Resources.Command_LayoutInsertSymbol_ToolTip_Description;
      designerCommands1.ToolTipText = Resources.Command_LayoutInsertSymbol_ToolTip_Text;
      designerCommands1.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands1.EnableCommand = false;
      designerCommands1.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands1.CustomHelpId = new int?(MapInfoConstants.InsertSymbolHelpId);
      LayoutCommands.AddSymbolCommand = designerCommands1;
      LayoutCommands.AddSymbolCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands2 = new LayoutDesignerCommands("LayoutInsertLine", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawLineClick");
      designerCommands2.Text = Resources.Command_LayoutInsertLine_Label;
      designerCommands2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertLine_16x16.png";
      designerCommands2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertLine_32X32.png";
      designerCommands2.ToolTipDescription = Resources.Command_LayoutInsertLine_ToolTip_Description;
      designerCommands2.ToolTipText = Resources.Command_LayoutInsertLine_ToolTip_Text;
      designerCommands2.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands2.EnableCommand = false;
      designerCommands2.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands2.CustomHelpId = new int?(MapInfoConstants.InsertLineHelpid);
      LayoutCommands.AddLineCommand = designerCommands2;
      LayoutCommands.AddLineCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands3 = new LayoutDesignerCommands("LayoutInsertEllipse", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawEllipseClick");
      designerCommands3.Text = Resources.Command_LayoutInsertEllipse_Label;
      designerCommands3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertEllipse_16x16.png";
      designerCommands3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertEllipse_32x32.png";
      designerCommands3.ToolTipDescription = Resources.Command_LayoutInsertEllipse_ToolTip_Description;
      designerCommands3.ToolTipText = Resources.Command_LayoutInsertEllipse_ToolTip_Text;
      designerCommands3.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands3.EnableCommand = false;
      designerCommands3.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands3.CustomHelpId = new int?(MapInfoConstants.InsertEllipseHelpId);
      LayoutCommands.AddEllipseCommand = designerCommands3;
      LayoutCommands.AddEllipseCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands4 = new LayoutDesignerCommands("LayoutInsertRectangle", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawRectangleClick");
      designerCommands4.Text = Resources.Command_LayoutInsertRectangle_Label;
      designerCommands4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRectangle_16x16.png";
      designerCommands4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRectangle_32x32.png";
      designerCommands4.ToolTipDescription = Resources.Command_LayoutInsertRectangle_ToolTip_Description;
      designerCommands4.ToolTipText = Resources.Command_LayoutInsertRectangle_ToolTip_Text;
      designerCommands4.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands4.EnableCommand = false;
      designerCommands4.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands4.CustomHelpId = new int?(MapInfoConstants.InsertRectangleHelpId);
      LayoutCommands.AddRectangleCommand = designerCommands4;
      LayoutCommands.AddRectangleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands5 = new LayoutDesignerCommands("LayoutInsertRoundedRectangle", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawRoundedRectClick");
      designerCommands5.Text = Resources.Command_LayoutInsertRoundedRectangle_Label;
      designerCommands5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRoundRectangle_16x16.png";
      designerCommands5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRoundRectangle_32x32.png";
      designerCommands5.ToolTipDescription = Resources.Command_LayoutInsertRoundedRectangle_ToolTip_Description;
      designerCommands5.ToolTipText = Resources.Command_LayoutInsertRoundedRectangle_ToolTip_Text;
      designerCommands5.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands5.EnableCommand = false;
      designerCommands5.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands5.CustomHelpId = new int?(MapInfoConstants.InsertRoundedHelpId);
      LayoutCommands.AddRoundedRectangleCommand = designerCommands5;
      LayoutCommands.AddRoundedRectangleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands6 = new LayoutDesignerCommands("LayoutInsertImage", (InputGestureCollection) null, nameof (InsertImageCommand), (object) null);
      designerCommands6.Text = Resources.Command_LayoutInsertImage_Label;
      designerCommands6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/image_16x16.png";
      designerCommands6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/image_32X32.png";
      designerCommands6.ToolTipDescription = Resources.Command_LayoutInsertImage_ToolTip_Description;
      designerCommands6.ToolTipText = Resources.Command_LayoutInsertImage_ToolTip_Text;
      designerCommands6.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands6.EnableCommand = false;
      designerCommands6.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands6.CustomHelpId = new int?(MapInfoConstants.InsertImageFrameHelpId);
      LayoutCommands.InsertImageCommand = designerCommands6;
      LayoutCommands.InsertImageCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands7 = new LayoutDesignerCommands(nameof (ToggleGridLines), (InputGestureCollection) null, nameof (ToggleGridLinesCommand), (object) null);
      designerCommands7.Text = Resources.Command_ToggleGridLines_Label;
      designerCommands7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/gridlines_16x16.png";
      designerCommands7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/gridlines_32x32.png";
      designerCommands7.ToolTipDescription = Resources.Command_ToggleGridLines_ToolTip_Description;
      designerCommands7.ToolTipText = Resources.Command_ToggleGridLines_ToolTip_Text;
      designerCommands7.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands7.EnableCommand = false;
      designerCommands7.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands7.CustomHelpId = new int?(MapInfoConstants.GridlinesHelpId);
      LayoutCommands.ToggleGridLinesCommand = designerCommands7;
      LayoutCommands.ToggleGridLinesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(2903, nameof (LayoutPageSetup), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_LayoutPageSetup_Label;
      basicRunMenuCommand8.MenuItemText = Resources.Command_LayoutPageSetup_MenuItemText;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/margins_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/margins_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_LayoutPageSetup_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_LayoutPageSetup_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand8.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2903));
      LayoutCommands.LayoutPageSetupCommand = (MapInfoCommand) basicRunMenuCommand8;
      LayoutCommands.LayoutPageSetupCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands8 = new LayoutDesignerCommands(nameof (AddMapFrame), (InputGestureCollection) null, nameof (AddMapFrameCommand), (object) null);
      designerCommands8.Text = Resources.Command_AddMapFrame_Label;
      designerCommands8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newMap_16x16.png";
      designerCommands8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newMap_32x32.png";
      designerCommands8.ToolTipDescription = Resources.Command_AddMapFrame_ToolTip_Description;
      designerCommands8.ToolTipText = Resources.Command_AddMapFrame_ToolTip_Text;
      designerCommands8.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands8.EnableCommand = false;
      designerCommands8.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands8.CustomHelpId = new int?(MapInfoConstants.AddMapFrameHelpId);
      LayoutCommands.AddMapFrameCommand = designerCommands8;
      LayoutCommands.AddMapFrameCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands9 = new LayoutDesignerCommands(nameof (AddBrowserFrame), (InputGestureCollection) null, nameof (AddBrowserFrameCommand), (object) null);
      designerCommands9.Text = Resources.Command_AddBrowserFrame_Label;
      designerCommands9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/NewBrowser_16x16.png";
      designerCommands9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/NewBrowser_32x32.png";
      designerCommands9.ToolTipDescription = Resources.Command_AddBrowserFrame_ToolTip_Description;
      designerCommands9.ToolTipText = Resources.Command_AddBrowserFrame_ToolTip_Text;
      designerCommands9.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands9.EnableCommand = false;
      designerCommands9.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands9.CustomHelpId = new int?(MapInfoConstants.AddBrowserFrameHelpId);
      LayoutCommands.AddBrowserFrameCommand = designerCommands9;
      LayoutCommands.AddBrowserFrameCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands10 = new LayoutDesignerCommands(nameof (InsertText), (InputGestureCollection) null, nameof (InsertTextCommand), (object) null);
      designerCommands10.Text = Resources.Command_InsertText_Label;
      designerCommands10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertTextbox_16x16.png";
      designerCommands10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertTextbox_32x32.png";
      designerCommands10.ToolTipDescription = Resources.Command_InsertText_ToolTip_Description;
      designerCommands10.ToolTipText = Resources.Command_InsertText_ToolTip_Text;
      designerCommands10.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands10.EnableCommand = false;
      designerCommands10.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands10.CustomHelpId = new int?(MapInfoConstants.InsertTextFrameHelpId);
      LayoutCommands.InsertTextCommand = designerCommands10;
      LayoutCommands.InsertTextCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(2909, nameof (LayoutTextStyle), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_LayoutTextStyle_Label;
      basicRunMenuCommand9.MenuItemText = Resources.Command_LayoutTextStyle_MenuItemText;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_LayoutTextStyle_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_LayoutTextStyle_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand9.CustomHelpId = new int?(MapInfoConstants.LayoutTextStyleHelpId);
      LayoutCommands.LayoutTextStyleCommand = (MapInfoCommand) basicRunMenuCommand9;
      LayoutCommands.LayoutTextStyleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands11 = new LayoutDesignerCommands(nameof (AddVerticalGuideline), (InputGestureCollection) null, nameof (AddVerticalGuidelineCommand), (object) null);
      designerCommands11.Text = Resources.Command_AddVerticalGuideline_Label;
      designerCommands11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/addVertGuideline_16x16.png";
      designerCommands11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/addVertGuideline_32x32.png";
      designerCommands11.ToolTipDescription = Resources.Command_AddVerticalGuideline_ToolTip_Description;
      designerCommands11.ToolTipText = Resources.Command_AddVerticalGuideline_Tooltip_Text;
      designerCommands11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_EnableGuidelines;
      designerCommands11.EnableCommand = false;
      designerCommands11.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands11.CustomHelpId = new int?(MapInfoConstants.AddVerticalGuidelineHelpId);
      LayoutCommands.AddVerticalGuidelineCommand = designerCommands11;
      LayoutCommands.AddVerticalGuidelineCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands12 = new LayoutDesignerCommands(nameof (AddHorizontalGuideline), (InputGestureCollection) null, nameof (AddHorizontalGuidelineCommand), (object) null);
      designerCommands12.Text = Resources.Command_AddHorizontalGuideline_Label;
      designerCommands12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/addHorizGuideline_16x16.png";
      designerCommands12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/addHorizGuideline_32x32.png";
      designerCommands12.ToolTipDescription = Resources.Command_AddHorizontalGuideline_ToolTip_Description;
      designerCommands12.ToolTipText = Resources.Command_AddHorizontalGuideline_ToolTip_Text;
      designerCommands12.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_EnableGuidelines;
      designerCommands12.EnableCommand = false;
      designerCommands12.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands12.CustomHelpId = new int?(MapInfoConstants.AddHorizontalGuidelineHelpId);
      LayoutCommands.AddHorizontalGuidelineCommand = designerCommands12;
      LayoutCommands.AddHorizontalGuidelineCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands13 = new LayoutDesignerCommands(nameof (DisableGuidelines), (InputGestureCollection) null, nameof (DisableGuidelinesCommand), (object) null);
      designerCommands13.Text = Resources.Command_DisableGuidelines_Label;
      designerCommands13.MenuItemToggleText = Resources.Command_DisableGuidelines_MenuItemToggleText;
      designerCommands13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/showAlignBars_16x16.png";
      designerCommands13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/showAlignBars_32x32.png";
      designerCommands13.ToolTipDescription = Resources.Command_DisableGuidelines_ToolTip_Description;
      designerCommands13.ToolTipText = Resources.Command_DisableGuidelines_ToolTip_Text;
      designerCommands13.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands13.EnableCommand = false;
      designerCommands13.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands13.CustomHelpId = new int?(MapInfoConstants.DisableGuidelinesHelpId);
      LayoutCommands.DisableGuidelinesCommand = designerCommands13;
      LayoutCommands.DisableGuidelinesCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands14 = new LayoutDesignerCommands(nameof (RemoveGuidelines), (InputGestureCollection) null, nameof (RemoveGuidelinesCommand), (object) null);
      designerCommands14.Text = Resources.Command_RemoveGuidelines_Label;
      designerCommands14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/clearAlignBars_16x16.png";
      designerCommands14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/clearAlignBars_32x32.png";
      designerCommands14.ToolTipDescription = Resources.Command_RemoveGuidelines_ToolTip_Description;
      designerCommands14.ToolTipText = Resources.Command_RemoveGuidelines_ToolTip_Text;
      designerCommands14.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_HasGuidelines;
      designerCommands14.EnableCommand = false;
      designerCommands14.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands14.CustomHelpId = new int?(MapInfoConstants.RemoveAllGuidelinesHelpId);
      LayoutCommands.RemoveGuidelinesCommand = designerCommands14;
      LayoutCommands.RemoveGuidelinesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(2914, nameof (NewEmptyFrame), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_NewEmptyFrame_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newFrame_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newFrame_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_NewEmptyFrame_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_NewEmptyFrame_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand10.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2914));
      LayoutCommands.NewEmptyFrameCommand = basicRunMenuCommand10;
      LayoutCommands.NewEmptyFrameCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(2913, nameof (RemoveSelectedFramesContent), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_RemoveSelectedFramesContent_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/removeContents_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/removeContents_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_RemoveSelectedFramesContent_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_RemoveSelectedFramesContent_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand11.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2913));
      LayoutCommands.RemoveSelectedFramesContentCommand = basicRunMenuCommand11;
      LayoutCommands.RemoveSelectedFramesContentCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(2915, "RemoveSelectedLayoutItems", (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_RemoveSelectedLayoutItems_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/removeFrame_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/removeFrame_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_RemoveSelectedLayoutItems_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_RemoveSelectedLayoutItems_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand12.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2915));
      LayoutCommands.RemoveSelectedItemsCommand = basicRunMenuCommand12;
      LayoutCommands.RemoveSelectedItemsCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands15 = new LayoutDesignerCommands(nameof (SnapToGrid), (InputGestureCollection) null, nameof (SnapToGridCommand), (object) null);
      designerCommands15.Text = Resources.Command_SnapToGrid_Label;
      designerCommands15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/snapToGrid_16x16.png";
      designerCommands15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/snapToGrid_32x32.png";
      designerCommands15.ToolTipDescription = Resources.Command_SnapToGrid_ToolTip_Description;
      designerCommands15.ToolTipText = Resources.Command_SnapToGrid_ToolTip_Text;
      designerCommands15.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands15.EnableCommand = false;
      designerCommands15.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands15.CustomHelpId = new int?(MapInfoConstants.SnapToGridHelpId);
      LayoutCommands.SnapToGridCommand = designerCommands15;
      LayoutCommands.SnapToGridCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands16 = new LayoutDesignerCommands(nameof (SnapToLeft), (InputGestureCollection) null, nameof (SnapToLeftCommand), (object) null);
      designerCommands16.Text = Resources.Command_SnapToLeft_Label;
      designerCommands16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignLeft_16x16.png";
      designerCommands16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignLeft_32x32.png";
      designerCommands16.ToolTipDescription = Resources.Command_SnapToLeft_ToolTip_Description;
      designerCommands16.ToolTipText = Resources.Command_SnapToLeft_ToolTip_Text;
      designerCommands16.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_VerticalGuide;
      designerCommands16.EnableCommand = false;
      designerCommands16.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands16.CustomHelpId = new int?(MapInfoConstants.SnapToLeftHelpId);
      LayoutCommands.SnapToLeftCommand = designerCommands16;
      LayoutCommands.SnapToLeftCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands17 = new LayoutDesignerCommands(nameof (SnapToRight), (InputGestureCollection) null, nameof (SnapToRightCommand), (object) null);
      designerCommands17.Text = Resources.Command_SnapToRight_Label;
      designerCommands17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignRight_16x16.png";
      designerCommands17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignRight_32x32.png";
      designerCommands17.ToolTipDescription = Resources.Command_SnapToRight_ToolTip_Description;
      designerCommands17.ToolTipText = Resources.Command_SnapToRight_ToolTip_Text;
      designerCommands17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_VerticalGuide;
      designerCommands17.EnableCommand = false;
      designerCommands17.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands17.CustomHelpId = new int?(MapInfoConstants.SnapToRightHelpId);
      LayoutCommands.SnapToRightCommand = designerCommands17;
      LayoutCommands.SnapToRightCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands18 = new LayoutDesignerCommands(nameof (SnapToTop), (InputGestureCollection) null, nameof (SnapToTopCommand), (object) null);
      designerCommands18.Text = Resources.Command_SnapToTop_Label;
      designerCommands18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignTop_16x16.png";
      designerCommands18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignTop_32x32.png";
      designerCommands18.ToolTipDescription = Resources.Command_SnapToTop_ToolTip_Description;
      designerCommands18.ToolTipText = Resources.Command_SnapToTop_ToolTip_Text;
      designerCommands18.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_HorizontalGuide;
      designerCommands18.EnableCommand = false;
      designerCommands18.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands18.CustomHelpId = new int?(MapInfoConstants.SnapToTopHelpId);
      LayoutCommands.SnapToTopCommand = designerCommands18;
      LayoutCommands.SnapToTopCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands19 = new LayoutDesignerCommands(nameof (SnapToBottom), (InputGestureCollection) null, nameof (SnapToBottomCommand), (object) null);
      designerCommands19.Text = Resources.Command_SnapToBottom_Label;
      designerCommands19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignBottom_16x16.png";
      designerCommands19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignBottom_32x32.png";
      designerCommands19.ToolTipDescription = Resources.Command_SnapToBottom_ToolTip_Description;
      designerCommands19.ToolTipText = Resources.Command_SnapToBottom_ToolTip_Text;
      designerCommands19.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_HorizontalGuide;
      designerCommands19.EnableCommand = false;
      designerCommands19.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands19.CustomHelpId = new int?(MapInfoConstants.SnapToBottomHelpId);
      LayoutCommands.SnapToBottomCommand = designerCommands19;
      LayoutCommands.SnapToBottomCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands20 = new LayoutDesignerCommands(nameof (AlignHorizontalCenter), (InputGestureCollection) null, nameof (AlignHorizontalCenterCommand), (object) null);
      designerCommands20.Text = Resources.Command_AlignHorizontalCenter_Label;
      designerCommands20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignCenterHor_16x16.png";
      designerCommands20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignCenterHor_32x32.png";
      designerCommands20.ToolTipDescription = Resources.Command_AlignHorizontalCenter_ToolTip_Description;
      designerCommands20.ToolTipText = Resources.Command_AlignHorizontalCenter_ToolTip_Text;
      designerCommands20.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObjects;
      designerCommands20.EnableCommand = false;
      designerCommands20.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands20.CustomHelpId = new int?(MapInfoConstants.AlignHorizontalCenterHelpId);
      LayoutCommands.AlignHorizontalCenterCommand = designerCommands20;
      LayoutCommands.AlignHorizontalCenterCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands21 = new LayoutDesignerCommands(nameof (AlignVerticalCenter), (InputGestureCollection) null, nameof (AlignVerticalCenterCommand), (object) null);
      designerCommands21.Text = Resources.Command_AlignVerticalCenter_Label;
      designerCommands21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignCenterVert_16x16.png";
      designerCommands21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/alignCenterVert_32x32.png";
      designerCommands21.ToolTipDescription = Resources.Command_AlignVerticalCenter_ToolTip_Description;
      designerCommands21.ToolTipText = Resources.Command_AlignVerticalCenter_ToolTip_Text;
      designerCommands21.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObjects;
      designerCommands21.EnableCommand = false;
      designerCommands21.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands21.CustomHelpId = new int?(MapInfoConstants.AlignVerticalCenterHelpId);
      LayoutCommands.AlignVerticalCenterCommand = designerCommands21;
      LayoutCommands.AlignVerticalCenterCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands22 = new LayoutDesignerCommands("LayoutRegionStyle", (InputGestureCollection) null, "ChangeShapeStyleCommand", (object) null);
      designerCommands22.Text = Resources.Command_LayoutRegionStyle_Label;
      designerCommands22.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_16x16.png";
      designerCommands22.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_32x32.png";
      designerCommands22.ToolTipDescription = Resources.Command_LayoutRegionStyle_ToolTip_Description;
      designerCommands22.ToolTipText = Resources.Command_LayoutRegionStyle_ToolTip_Text;
      designerCommands22.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedRegion;
      designerCommands22.EnableCommand = false;
      designerCommands22.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands22.CustomHelpId = new int?(MapInfoConstants.RegionStyleHelpid);
      LayoutCommands.RegionStyleCommand = designerCommands22;
      LayoutCommands.RegionStyleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands23 = new LayoutDesignerCommands(nameof (LineSpacingDouble), (InputGestureCollection) null, "LineSpacingCommand", (object) "Double");
      designerCommands23.Text = Resources.Command_LineSpacingDouble_Label;
      designerCommands23.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_16x16.png";
      designerCommands23.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_32x32.png";
      designerCommands23.ToolTipDescription = Resources.Command_LineSpacingDouble_ToolTip_Description;
      designerCommands23.ToolTipText = Resources.Command_LineSpacingDouble_ToolTip_Text;
      designerCommands23.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands23.EnableCommand = false;
      designerCommands23.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands23.CustomHelpId = new int?(MapInfoConstants.LineSpacingHelpId);
      LayoutCommands.LineSpacingDoubleCommand = designerCommands23;
      LayoutCommands.LineSpacingDoubleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands24 = new LayoutDesignerCommands(nameof (LineSpacingOnePointFive), (InputGestureCollection) null, "LineSpacingCommand", (object) "OnePointFive");
      designerCommands24.Text = Resources.Command_LineSpacingOnePointFive_Label;
      designerCommands24.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_16x16.png";
      designerCommands24.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_32x32.png";
      designerCommands24.ToolTipDescription = Resources.Command_LineSpacingOnePointFive_ToolTip_Description;
      designerCommands24.ToolTipText = Resources.Command_LineSpacingOnePointFive_ToolTip_Text;
      designerCommands24.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedLine;
      designerCommands24.EnableCommand = false;
      designerCommands24.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands24.CustomHelpId = new int?(MapInfoConstants.LineSpacingHelpId);
      LayoutCommands.LineSpacingOnePointFiveCommand = designerCommands24;
      LayoutCommands.LineSpacingOnePointFiveCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands25 = new LayoutDesignerCommands(nameof (LineSpacingSingle), (InputGestureCollection) null, "LineSpacingCommand", (object) "Single");
      designerCommands25.Text = Resources.Command_LineSpacingSingle_Label;
      designerCommands25.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_16x16.png";
      designerCommands25.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineSpacing_32x32.png";
      designerCommands25.ToolTipDescription = Resources.Command_LineSpacingSingle_ToolTip_Description;
      designerCommands25.ToolTipText = Resources.Command_LineSpacingSingle_ToolTip_Text;
      designerCommands25.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedLine;
      designerCommands25.EnableCommand = false;
      designerCommands25.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands25.CustomHelpId = new int?(MapInfoConstants.LineSpacingHelpId);
      LayoutCommands.LineSpacingSingleCommand = designerCommands25;
      LayoutCommands.LineSpacingSingleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands26 = new LayoutDesignerCommands("LayoutLineStyle", (InputGestureCollection) null, "ChangeLineStyleCommand", (object) null);
      designerCommands26.Text = Resources.Command_LayoutLineStyle_Label;
      designerCommands26.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_16x16.png";
      designerCommands26.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_32x32.png";
      designerCommands26.ToolTipDescription = Resources.Command_LayoutLineStyle_ToolTip_Description;
      designerCommands26.ToolTipText = Resources.Command_LayoutLineStyle_ToolTip_Text;
      designerCommands26.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedLine;
      designerCommands26.EnableCommand = false;
      designerCommands26.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands26.CustomHelpId = new int?(MapInfoConstants.LineStyleHelpId);
      LayoutCommands.LineStyleCommand = designerCommands26;
      LayoutCommands.LineStyleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands27 = new LayoutDesignerCommands("LayoutSymbolStyle", (InputGestureCollection) null, "ChangeSymbolStyleCommand", (object) null);
      designerCommands27.Text = Resources.Command_LayoutSymbolStyle_Label;
      designerCommands27.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_16x16.png";
      designerCommands27.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_32x32.png";
      designerCommands27.ToolTipDescription = Resources.Command_LayoutSymbolStyle_ToolTip_Description;
      designerCommands27.ToolTipText = Resources.Command_LayoutSymbolStyle_ToolTip_Text;
      designerCommands27.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands27.EnableCommand = false;
      designerCommands27.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands27.CustomHelpId = new int?(MapInfoConstants.SymbolStyleHelpId);
      LayoutCommands.SymbolStyleCommand = designerCommands27;
      LayoutCommands.SymbolStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(2906, nameof (BringToFront), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_BringToFront_Label;
      basicRunMenuCommand13.MenuItemText = Resources.Command_BringToFront_MenuItemText;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/reorderFront_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/reorderFront_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_BringToFront_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_BringToFront_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand13.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2906));
      LayoutCommands.BringToFrontCommand = (MapInfoCommand) basicRunMenuCommand13;
      LayoutCommands.BringToFrontCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(2907, nameof (SendToBack), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_SendToBack_Label;
      basicRunMenuCommand14.MenuItemText = Resources.Command_SendToBack_MenuItemText;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/reorderBack_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/reorderBack_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_SendToBack_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_SendToBack_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand14.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2907));
      LayoutCommands.SendToBackCommand = (MapInfoCommand) basicRunMenuCommand14;
      LayoutCommands.SendToBackCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands28 = new LayoutDesignerCommands(nameof (TextJustifyLeft), (InputGestureCollection) null, "TextJustifyCommand", (object) TextAlignment.Left.ToString());
      designerCommands28.Text = Resources.Command_TextJustifyLeft_Label;
      designerCommands28.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyLeft_16x16.png";
      designerCommands28.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyLeft_32x32.png";
      designerCommands28.ToolTipDescription = Resources.Command_TextJustifyLeft_ToolTip_Description;
      designerCommands28.ToolTipText = Resources.Command_TextJustifyLeft_ToolTip_Text;
      designerCommands28.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands28.EnableCommand = false;
      designerCommands28.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands28.CustomHelpId = new int?(MapInfoConstants.LeftAlignTextHelpId);
      LayoutCommands.TextJustifyLeftCommand = designerCommands28;
      LayoutCommands.TextJustifyLeftCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands29 = new LayoutDesignerCommands(nameof (TextJustifyRight), (InputGestureCollection) null, "TextJustifyCommand", (object) TextAlignment.Right.ToString());
      designerCommands29.Text = Resources.Command_TextJustifyRight_Label;
      designerCommands29.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyRight_16x16.png";
      designerCommands29.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyRight_32x32.png";
      designerCommands29.ToolTipDescription = Resources.Command_TextJustifyRight_ToolTip_Description;
      designerCommands29.ToolTipText = Resources.Command_TextJustifyRight_ToolTip_Text;
      designerCommands29.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands29.EnableCommand = false;
      designerCommands29.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands29.CustomHelpId = new int?(MapInfoConstants.RightAlignTextHelpId);
      LayoutCommands.TextJustifyRightCommand = designerCommands29;
      LayoutCommands.TextJustifyRightCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands30 = new LayoutDesignerCommands(nameof (TextJustifyCenter), (InputGestureCollection) null, "TextJustifyCommand", (object) TextAlignment.Center.ToString());
      designerCommands30.Text = Resources.Command_TextJustifyCenter_Label;
      designerCommands30.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyCenter_16x16.png";
      designerCommands30.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textJustifyCenter_32x32.png";
      designerCommands30.ToolTipDescription = Resources.Command_TextJustifyCenter_ToolTip_Description;
      designerCommands30.ToolTipText = Resources.Command_TextJustifyCenter_ToolTip_Text;
      designerCommands30.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands30.EnableCommand = false;
      designerCommands30.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands30.CustomHelpId = new int?(MapInfoConstants.CenterTextHelpId);
      LayoutCommands.TextJustifyCenterCommand = designerCommands30;
      LayoutCommands.TextJustifyCenterCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands31 = new LayoutDesignerCommands(nameof (ChangeFrameStyle), (InputGestureCollection) null, nameof (ChangeFrameStyleCommand), (object) null);
      designerCommands31.Text = Resources.Command_ChangeFrameStyle_Label;
      designerCommands31.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frameStyle_16x16.png";
      designerCommands31.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/frameStyle_32x32.png";
      designerCommands31.ToolTipDescription = Resources.Command_ChangeFrameStyle_ToolTip_Description;
      designerCommands31.ToolTipText = Resources.Command_ChangeFrameStyle_ToolTip_Text;
      designerCommands31.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      designerCommands31.EnableCommand = false;
      designerCommands31.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands31.CustomHelpId = new int?(MapInfoConstants.FrameStyleHelpId);
      LayoutCommands.ChangeFrameStyleCommand = designerCommands31;
      LayoutCommands.ChangeFrameStyleCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands32 = new LayoutDesignerCommands("LayoutSelect", (InputGestureCollection) null, nameof (SelectCommand), (object) null);
      designerCommands32.Text = Resources.Command_LayoutSelect_Label;
      designerCommands32.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/selectCanvas_16x16.png";
      designerCommands32.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/selectCanvas_32x32.png";
      designerCommands32.ToolTipDescription = Resources.Command_LayoutSelect_ToolTip_Description;
      designerCommands32.ToolTipText = Resources.Command_LayoutSelect_ToolTip_Text;
      designerCommands32.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands32.EnableCommand = false;
      designerCommands32.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands32.CustomHelpId = new int?(MapInfoConstants.LayoutSelectHelpId);
      LayoutCommands.SelectCommand = designerCommands32;
      LayoutCommands.SelectCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands33 = new LayoutDesignerCommands("LayoutZoomIn", (InputGestureCollection) null, nameof (ZoomInCommand), (object) null);
      designerCommands33.Text = Resources.Command_LayoutZoomIn_Label;
      designerCommands33.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoomInCanvas_16x16.png";
      designerCommands33.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoomInCanvas_32x32.png";
      designerCommands33.ToolTipDescription = Resources.Command_LayoutZoomIn_ToolTip_Description;
      designerCommands33.ToolTipText = Resources.Command_LayoutZoomIn_ToolTip_Text;
      designerCommands33.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands33.EnableCommand = false;
      designerCommands33.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands33.CustomHelpId = new int?(MapInfoConstants.ZoomInHelpId);
      LayoutCommands.ZoomInCommand = designerCommands33;
      LayoutCommands.ZoomInCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands34 = new LayoutDesignerCommands("LayoutZoomOut", (InputGestureCollection) null, nameof (ZoomOutCommand), (object) null);
      designerCommands34.Text = Resources.Command_LayoutZoomOut_Label;
      designerCommands34.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoomOutCanvas_16x16.png";
      designerCommands34.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/zoomOutCanvas_32x32.png";
      designerCommands34.ToolTipDescription = Resources.Command_LayoutZoomOut_ToolTip_Description;
      designerCommands34.ToolTipText = Resources.Command_LayoutZoomOut_ToolTip_Text;
      designerCommands34.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands34.EnableCommand = false;
      designerCommands34.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands34.CustomHelpId = new int?(MapInfoConstants.ZoomOutHelpId);
      LayoutCommands.ZoomOutCommand = designerCommands34;
      LayoutCommands.ZoomOutCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands35 = new LayoutDesignerCommands("LayoutPan", (InputGestureCollection) null, nameof (PanCommand), (object) null);
      designerCommands35.Text = Resources.Command_LayoutPan_Label;
      designerCommands35.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/panCanvas_16x16.png";
      designerCommands35.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/panCanvas_32x32.png";
      designerCommands35.ToolTipDescription = Resources.Command_LayoutPan_ToolTip_Description;
      designerCommands35.ToolTipText = Resources.Command_LayoutPan_ToolTip_Text;
      designerCommands35.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands35.EnableCommand = false;
      designerCommands35.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands35.CustomHelpId = new int?(MapInfoConstants.LayoutPanHelpId);
      LayoutCommands.PanCommand = designerCommands35;
      LayoutCommands.PanCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands36 = new LayoutDesignerCommands(nameof (RotateFrameByZeroDegree), (InputGestureCollection) null, "RotateFrameCommand", (object) 0);
      designerCommands36.Text = Resources.Command_RotateFrameByZeroDegree_Label;
      designerCommands36.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelDirectionHorizontal_16x16.png";
      designerCommands36.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelDirectionHorizontal_32x32.png";
      designerCommands36.EnableCommand = false;
      designerCommands36.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands36.ToolTipDescription = Resources.Command_RotateFrameByZeroDegree_Label;
      designerCommands36.ToolTipText = Resources.Command_RotateFrameByZeroDegree_ToolTip_Text;
      designerCommands36.Category = Resources.Command_Category_LayoutDesignerCommands;
      LayoutCommands.RotateFrameByZeroDegreeCommand = (MapInfoCommand) designerCommands36;
      LayoutCommands.RotateFrameByZeroDegreeCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands37 = new LayoutDesignerCommands(nameof (RotateFrameByNinetyDegree), (InputGestureCollection) null, "RotateFrameCommand", (object) 90);
      designerCommands37.Text = Resources.Command_RotateFrameByNinetyDegree_Label;
      designerCommands37.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelRotate90_16x16.png";
      designerCommands37.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelRotate90_32x32.png";
      designerCommands37.EnableCommand = false;
      designerCommands37.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands37.ToolTipDescription = Resources.Command_RotateFrameByNinetyDegree_Label;
      designerCommands37.ToolTipText = Resources.Command_RotateFrameByNinetyDegree_ToolTip_Text;
      designerCommands37.Category = Resources.Command_Category_LayoutDesignerCommands;
      LayoutCommands.RotateFrameByNinetyDegreeCommand = (MapInfoCommand) designerCommands37;
      LayoutCommands.RotateFrameByNinetyDegreeCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands38 = new LayoutDesignerCommands(nameof (RotateFrameByTwoSeventyDegree), (InputGestureCollection) null, "RotateFrameCommand", (object) 270);
      designerCommands38.Text = Resources.Command_RotateFrameByTwoSeventyDegree_Label;
      designerCommands38.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelRotate270_16x16.png";
      designerCommands38.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/labelRotate270_32x32.png";
      designerCommands38.EnableCommand = false;
      designerCommands38.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedText;
      designerCommands38.ToolTipDescription = Resources.Command_RotateFrameByTwoSeventyDegree_Label;
      designerCommands38.ToolTipText = Resources.Command_RotateFrameByTwoSeventyDegree_ToolTip_Text;
      designerCommands38.Category = Resources.Command_Category_LayoutDesignerCommands;
      LayoutCommands.RotateFrameByTwoSeventyDegreeCommand = (MapInfoCommand) designerCommands38;
      LayoutCommands.RotateFrameByTwoSeventyDegreeCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands39 = new LayoutDesignerCommands("LayoutInsertPolygon", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawPolygonClick");
      designerCommands39.Text = Resources.Command_LayoutInsertPolygon_Label;
      designerCommands39.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolygonRegion_16x16.png";
      designerCommands39.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolygonRegion_32x32.png";
      designerCommands39.ToolTipDescription = Resources.Command_LayoutInsertPolygon_ToolTip_Description;
      designerCommands39.ToolTipText = Resources.Command_LayoutInsertPolygon_ToolTip_Text;
      designerCommands39.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands39.EnableCommand = false;
      designerCommands39.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands39.CustomHelpId = new int?(MapInfoConstants.InsertPolygonHelpId);
      LayoutCommands.AddPolygonCommand = designerCommands39;
      LayoutCommands.AddPolygonCommand.CreateScreenTip();
      LayoutDesignerCommands designerCommands40 = new LayoutDesignerCommands("LayoutInsertPolyline", (InputGestureCollection) null, "AddShapeCommand", (object) "ShapesDrawPolylineClick");
      designerCommands40.Text = Resources.Command_LayoutInsertPolyline_Label;
      designerCommands40.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolyline_16x16.png";
      designerCommands40.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolyline_32x32.png";
      designerCommands40.ToolTipDescription = Resources.Command_LayoutInsertPolyline_ToolTip_Description;
      designerCommands40.ToolTipText = Resources.Command_LayoutInsertPolyline_ToolTip_Text;
      designerCommands40.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow;
      designerCommands40.EnableCommand = false;
      designerCommands40.Category = Resources.Command_Category_LayoutDesignerCommands;
      designerCommands40.CustomHelpId = new int?(MapInfoConstants.InsertPolylineHelpId);
      LayoutCommands.AddPolylineCommand = designerCommands40;
      LayoutCommands.AddPolylineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(2916, nameof (StackUndo), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_StackUndo_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/undo_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/undo_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_StackUndo_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_StackUndo_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_StackUndo_ToolTip_Disabled_Text;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand15.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2916));
      LayoutCommands.StackUndoCommand = basicRunMenuCommand15;
      LayoutCommands.StackUndoCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(2917, nameof (StackRedo), MapInfoCommand.GetGesture(Resources.Command_StackRedo_KeyGesture));
      basicRunMenuCommand16.Text = Resources.Command_StackRedo_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redo_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/redo_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_StackRedo_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_StackRedo_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_StackRedo_ToolTip_Disabled_Text;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand16.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2917));
      LayoutCommands.StackRedoCommand = basicRunMenuCommand16;
      LayoutCommands.StackRedoCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(2930, nameof (ToggleSmartGuides), (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_ToggleSmartGuides_Label;
      basicRunMenuCommand17.MenuItemText = Resources.Command_ToggleSmartGuides_MenuItemText;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/guidelines_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/guidelines_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_ToggleSmartGuides_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_ToggleSmartGuides_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveLayoutWindow_SelectedObject;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_LayoutDesignerCommands;
      basicRunMenuCommand17.CustomHelpId = new int?(MapInfoConstants.GetHelpIdFromMenuId(2930));
      LayoutCommands.ToggleSmartGuidesCommand = basicRunMenuCommand17;
      LayoutCommands.ToggleSmartGuidesCommand.CreateScreenTip();
    }

    public static MapInfoCommand ModifyThematic
    {
      get
      {
        return LayoutCommands.ModifyThematicCommand;
      }
    }

    public static MapInfoCommand RefreshLegends
    {
      get
      {
        return LayoutCommands.RefreshLegendsCommand;
      }
    }

    public static MapInfoCommand AddLegends
    {
      get
      {
        return LayoutCommands.AddLegendsCommand;
      }
    }

    public static MapInfoCommand FitInWindow
    {
      get
      {
        return LayoutCommands.FitInWindowCommand;
      }
    }

    public static MapInfoCommand ZoomToHundredPercent
    {
      get
      {
        return LayoutCommands.ZoomToHundredPercentCommand;
      }
    }

    public static MapInfoCommand FrameProperties
    {
      get
      {
        return LayoutCommands.FramePropertiesCommand;
      }
    }

    public static MapInfoCommand ActivateLayoutFrame
    {
      get
      {
        return LayoutCommands.ActivateLayoutFrameCommand;
      }
    }

    public static MapInfoCommand InsertImage
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.InsertImageCommand;
      }
    }

    public static MapInfoCommand ToggleGridLines
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.ToggleGridLinesCommand;
      }
    }

    public static MapInfoCommand AddMapFrame
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddMapFrameCommand;
      }
    }

    public static MapInfoCommand AddBrowserFrame
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddBrowserFrameCommand;
      }
    }

    public static MapInfoCommand LayoutPageSetup
    {
      get
      {
        return LayoutCommands.LayoutPageSetupCommand;
      }
    }

    public static MapInfoCommand InsertText
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.InsertTextCommand;
      }
    }

    public static MapInfoCommand LayoutTextStyle
    {
      get
      {
        return LayoutCommands.LayoutTextStyleCommand;
      }
    }

    public static MapInfoCommand RegionStyle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.RegionStyleCommand;
      }
    }

    public static MapInfoCommand LineSpacingDouble
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.LineSpacingDoubleCommand;
      }
    }

    public static MapInfoCommand LineSpacingOnePointFive
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.LineSpacingOnePointFiveCommand;
      }
    }

    public static MapInfoCommand LineSpacingSingle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.LineSpacingSingleCommand;
      }
    }

    public static MapInfoCommand LineStyle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.LineStyleCommand;
      }
    }

    public static MapInfoCommand SymbolStyle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SymbolStyleCommand;
      }
    }

    public static MapInfoCommand AddSymbol
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddSymbolCommand;
      }
    }

    public static MapInfoCommand AddLine
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddLineCommand;
      }
    }

    public static MapInfoCommand AddEllipse
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddEllipseCommand;
      }
    }

    public static MapInfoCommand AddRectangle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddRectangleCommand;
      }
    }

    public static MapInfoCommand AddRoundedRectangle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddRoundedRectangleCommand;
      }
    }

    public static MapInfoCommand BringToFront
    {
      get
      {
        return LayoutCommands.BringToFrontCommand;
      }
    }

    public static MapInfoCommand SendToBack
    {
      get
      {
        return LayoutCommands.SendToBackCommand;
      }
    }

    public static MapInfoCommand AddVerticalGuideline
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddVerticalGuidelineCommand;
      }
    }

    public static MapInfoCommand AddHorizontalGuideline
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddHorizontalGuidelineCommand;
      }
    }

    public static MapInfoCommand DisableGuidelines
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.DisableGuidelinesCommand;
      }
    }

    public static MapInfoCommand RemoveGuidelines
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.RemoveGuidelinesCommand;
      }
    }

    public static MapInfoCommand NewEmptyFrame
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.NewEmptyFrameCommand;
      }
    }

    public static MapInfoCommand RemoveSelectedFramesContent
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.RemoveSelectedFramesContentCommand;
      }
    }

    public static MapInfoCommand RemoveSelectedItems
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.RemoveSelectedItemsCommand;
      }
    }

    public static MapInfoCommand SnapToGrid
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SnapToGridCommand;
      }
    }

    public static MapInfoCommand SnapToLeft
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SnapToLeftCommand;
      }
    }

    public static MapInfoCommand SnapToRight
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SnapToRightCommand;
      }
    }

    public static MapInfoCommand SnapToTop
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SnapToTopCommand;
      }
    }

    public static MapInfoCommand SnapToBottom
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SnapToBottomCommand;
      }
    }

    public static MapInfoCommand AlignHorizontalCenter
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AlignHorizontalCenterCommand;
      }
    }

    public static MapInfoCommand AlignVerticalCenter
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AlignVerticalCenterCommand;
      }
    }

    public static MapInfoCommand TextJustifyLeft
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.TextJustifyLeftCommand;
      }
    }

    public static MapInfoCommand TextJustifyRight
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.TextJustifyRightCommand;
      }
    }

    public static MapInfoCommand TextJustifyCenter
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.TextJustifyCenterCommand;
      }
    }

    public static MapInfoCommand ChangeFrameStyle
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.ChangeFrameStyleCommand;
      }
    }

    public static MapInfoCommand Select
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.SelectCommand;
      }
    }

    public static MapInfoCommand ZoomIn
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.ZoomInCommand;
      }
    }

    public static MapInfoCommand ZoomOut
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.ZoomOutCommand;
      }
    }

    public static MapInfoCommand Pan
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.PanCommand;
      }
    }

    public static MapInfoCommand RotateFrameByZeroDegree
    {
      get
      {
        return LayoutCommands.RotateFrameByZeroDegreeCommand;
      }
    }

    public static MapInfoCommand RotateFrameByNinetyDegree
    {
      get
      {
        return LayoutCommands.RotateFrameByNinetyDegreeCommand;
      }
    }

    public static MapInfoCommand RotateFrameByTwoSeventyDegree
    {
      get
      {
        return LayoutCommands.RotateFrameByTwoSeventyDegreeCommand;
      }
    }

    public static MapInfoCommand AddPolygon
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddPolygonCommand;
      }
    }

    public static MapInfoCommand AddPolyline
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.AddPolylineCommand;
      }
    }

    public static MapInfoCommand StackUndo
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.StackUndoCommand;
      }
    }

    public static MapInfoCommand StackRedo
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.StackRedoCommand;
      }
    }

    public static MapInfoCommand ToggleSmartGuides
    {
      get
      {
        return (MapInfoCommand) LayoutCommands.ToggleSmartGuidesCommand;
      }
    }
  }
}
