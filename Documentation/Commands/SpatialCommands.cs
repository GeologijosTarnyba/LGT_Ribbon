// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.SpatialCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class SpatialCommands
  {
    private static readonly MapInfoCommand InsertSymbolCommand;
    private static readonly MapInfoCommand InsertTextCommand;
    private static readonly MapInfoCommand InsertLineCommand;
    private static readonly MapInfoCommand InsertPolylineCommand;
    private static readonly MapInfoCommand InsertArcCommand;
    private static readonly MapInfoCommand InsertPolygonCommand;
    private static readonly MapInfoCommand InsertEllipseCommand;
    private static readonly MapInfoCommand InsertRectangleCommand;
    private static readonly MapInfoCommand InsertRoundedRectangleCommand;
    private static readonly MapInfoCommand BufferCommand;
    private static readonly MapInfoCommand ConvexHullCommand;
    private static readonly MapInfoCommand ConvertToRegionCommand;
    private static readonly MapInfoCommand ConvertToPolylineCommand;
    private static readonly MapInfoCommand EncloseCommand;
    private static readonly MapInfoCommand CreateDriveRegionsCommand;
    private static readonly MapInfoCommand DriveRegionsTableCommand;
    private static readonly MapInfoCommand VoronoiCommand;
    private static readonly MapInfoCommand CheckRegionsCommand;
    private static readonly MapInfoCommand CleanCommand;
    private static readonly MapInfoCommand SnapCommand;
    private static readonly MapInfoCommand SmoothCommand;
    private static readonly MapInfoCommand UnsmoothCommand;
    private static readonly MapInfoCommand CombineObjectsCommand;
    private static readonly MapInfoCommand DisaggregateCommand;
    private static readonly MapInfoCommand LineStyleCommand;
    private static readonly MapInfoCommand RegionStyleCommand;
    private static readonly MapInfoCommand TextStyleCommand;
    private static readonly MapInfoCommand SymbolStyleCommand;
    private static readonly MapInfoCommand SetTargetCommand;
    private static readonly MapInfoCommand ClearTargetCommand;
    private static readonly MapInfoCommand EraseTargetCommand;
    private static readonly MapInfoCommand EraseOutsideTargetCommand;
    private static readonly MapInfoCommand SplitTargetCommand;
    private static readonly MapInfoCommand PolylineSplitCommand;
    private static readonly MapInfoCommand PolylineSplitAtNodeCommand;
    private static readonly MapInfoCommand OffsetObjectCommand;
    private static readonly MapInfoCommand RotateObjectCommand;
    private static readonly MapInfoCommand ReshapeCommand;
    private static readonly MapInfoCommand OverlayNodeCommand;
    private static readonly MapInfoCommand DigitizerSetupCommand;
    private static readonly MapInfoCommand VoronoiTableCommand;

    static SpatialCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(803, nameof (DigitizerSetup), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_DigitizerSetup_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/digitizerSetup_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/digitizerSetup_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_DigitizerSetup_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_DigitizerSetup_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedDigitizerSetup;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.DigitizerSetupCommand = (MapInfoCommand) basicRunMenuCommand1;
      SpatialCommands.DigitizerSetupCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(1601, nameof (Reshape), MapInfoCommand.GetGesture(Resources.Command_Reshape_KeyGesture));
      basicRunMenuCommand2.Text = Resources.Command_Reshape_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/reshapeNodes_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/reshapeNodes_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_Reshape_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_Reshape_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.ReshapeCommand = (MapInfoCommand) basicRunMenuCommand2;
      SpatialCommands.ReshapeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(1615, nameof (OverlayNode), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_OverlayNode_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/overlayNodes_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/overlayNodes_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_OverlayNode_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_OverlayNode_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSetTargetSelect;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.OverlayNodeCommand = (MapInfoCommand) basicRunMenuCommand3;
      SpatialCommands.OverlayNodeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(1618, nameof (CheckRegions), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_CheckRegions_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/checkRegions_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/checkRegions_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_CheckRegions_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_CheckRegions_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.CheckRegionsCommand = (MapInfoCommand) basicRunMenuCommand4;
      SpatialCommands.CheckRegionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(1619, nameof (Clean), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_Clean_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/cleanObjects_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/cleanObjects_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_Clean_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_Clean_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.CleanCommand = (MapInfoCommand) basicRunMenuCommand5;
      SpatialCommands.CleanCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(1620, nameof (Snap), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_Snap_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/snapThin_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/snapThin_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_Snap_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_Snap_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.SnapCommand = (MapInfoCommand) basicRunMenuCommand6;
      SpatialCommands.SnapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(1602, nameof (Smooth), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_Smooth_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/smoothLines_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/smoothLines_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_Smooth_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_Smooth_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapPolylineSelection;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.SmoothCommand = (MapInfoCommand) basicRunMenuCommand7;
      SpatialCommands.SmoothCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(1603, nameof (Unsmooth), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_Unsmooth_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/unsmoothLines_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/unsmoothLines_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_Unsmooth_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_Unsmooth_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapPolylineSelection;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.UnsmoothCommand = (MapInfoCommand) basicRunMenuCommand8;
      SpatialCommands.UnsmoothCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(1607, nameof (ConvertToRegion), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_ConvertToRegion_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/convertToRegions_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/convertToRegions_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_ConvertToRegion_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_ConvertToRegion_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.ConvertToRegionCommand = (MapInfoCommand) basicRunMenuCommand9;
      SpatialCommands.ConvertToRegionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(1604, nameof (ConvertToPolyline), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_ConvertToPolyline_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/convertToPolylines_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/convertToPolylines_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_ConvertToPolyline_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_ConvertToPolyline_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.ConvertToPolylineCommand = (MapInfoCommand) basicRunMenuCommand10;
      SpatialCommands.ConvertToPolylineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(1617, nameof (Enclose), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_Enclose_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/enclose_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/enclose_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_Enclose_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_Enclose_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.EncloseCommand = (MapInfoCommand) basicRunMenuCommand11;
      SpatialCommands.EncloseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(1627, nameof (CreateDriveRegions), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_CreateDriveRegions_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/driveRegions_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/driveRegions_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_CreateDriveRegions_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_CreateDriveRegions_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.CreateDriveRegionsCommand = (MapInfoCommand) basicRunMenuCommand12;
      SpatialCommands.CreateDriveRegionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(425, nameof (DriveRegionsTable), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_DriveRegionsTable_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/driveRegionsTable_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/driveRegionsTable_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_DriveRegionsTable_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_DriveRegionsTable_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.DriveRegionsTableCommand = (MapInfoCommand) basicRunMenuCommand13;
      SpatialCommands.DriveRegionsTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(1622, nameof (Voronoi), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_Voronoi_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/voronoi_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/voronoi_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_Voronoi_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_Voronoi_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.VoronoiCommand = (MapInfoCommand) basicRunMenuCommand14;
      SpatialCommands.VoronoiCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(1711, nameof (InsertSymbol), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_InsertPoint_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbol_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbol_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_InsertPoint_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_InsertPoint_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertSymbolCommand = (MapInfoCommand) basicRunMenuCommand15;
      SpatialCommands.InsertSymbolCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(1709, "SpatialInsertText", (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_SpatialInsertText_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/insertText_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/insertText_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_SpatialInsertText_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_SpatialInsertText_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertTextCommand = (MapInfoCommand) basicRunMenuCommand16;
      SpatialCommands.InsertTextCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(1712, nameof (InsertLine), (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_InsertLine_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertLine_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertLine_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_InsertLine_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_InsertLine_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertLineCommand = (MapInfoCommand) basicRunMenuCommand17;
      SpatialCommands.InsertLineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(1713, nameof (InsertPolyline), (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_InsertPolyline_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolyline_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolyline_32x32.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_InsertPolyline_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_InsertPolyline_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand18.EnableCommand = false;
      basicRunMenuCommand18.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertPolylineCommand = (MapInfoCommand) basicRunMenuCommand18;
      SpatialCommands.InsertPolylineCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(1716, nameof (InsertArc), (InputGestureCollection) null);
      basicRunMenuCommand19.Text = Resources.Command_InsertArc_Label;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertArc_16x16.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertArc_32x32.png";
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_InsertArc_ToolTip_Description;
      basicRunMenuCommand19.ToolTipText = Resources.Command_InsertArc_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand19.EnableCommand = false;
      basicRunMenuCommand19.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertArcCommand = (MapInfoCommand) basicRunMenuCommand19;
      SpatialCommands.InsertArcCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand20 = new MapBasicRunMenuCommand(1714, nameof (InsertPolygon), (InputGestureCollection) null);
      basicRunMenuCommand20.Text = Resources.Command_InsertPolygon_Label;
      basicRunMenuCommand20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolygonRegion_16x16.png";
      basicRunMenuCommand20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertPolygonRegion_32x32.png";
      basicRunMenuCommand20.ToolTipDescription = Resources.Command_InsertPolygon_ToolTip_Description;
      basicRunMenuCommand20.ToolTipText = Resources.Command_InsertPolygon_ToolTip_Text;
      basicRunMenuCommand20.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand20.EnableCommand = false;
      basicRunMenuCommand20.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertPolygonCommand = (MapInfoCommand) basicRunMenuCommand20;
      SpatialCommands.InsertPolygonCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand21 = new MapBasicRunMenuCommand(1715, nameof (InsertEllipse), (InputGestureCollection) null);
      basicRunMenuCommand21.Text = Resources.Command_InsertEllipse_Label;
      basicRunMenuCommand21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertEllipse_16x16.png";
      basicRunMenuCommand21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertEllipse_32x32.png";
      basicRunMenuCommand21.ToolTipDescription = Resources.Command_InsertEllipse_ToolTip_Description;
      basicRunMenuCommand21.ToolTipText = Resources.Command_InsertEllipse_ToolTip_Text;
      basicRunMenuCommand21.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand21.EnableCommand = false;
      basicRunMenuCommand21.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertEllipseCommand = (MapInfoCommand) basicRunMenuCommand21;
      SpatialCommands.InsertEllipseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand22 = new MapBasicRunMenuCommand(1717, nameof (InsertRectangle), (InputGestureCollection) null);
      basicRunMenuCommand22.Text = Resources.Command_InsertRectangle_Label;
      basicRunMenuCommand22.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRectangle_16x16.png";
      basicRunMenuCommand22.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRectangle_32x32.png";
      basicRunMenuCommand22.ToolTipDescription = Resources.Command_InsertRectangle_ToolTip_Description;
      basicRunMenuCommand22.ToolTipText = Resources.Command_InsertRectangle_ToolTip_Text;
      basicRunMenuCommand22.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand22.EnableCommand = false;
      basicRunMenuCommand22.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertRectangleCommand = (MapInfoCommand) basicRunMenuCommand22;
      SpatialCommands.InsertRectangleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand23 = new MapBasicRunMenuCommand(1718, "InsertRoundRectangle", (InputGestureCollection) null);
      basicRunMenuCommand23.Text = Resources.Command_InsertRoundRectangle_Label;
      basicRunMenuCommand23.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRoundRectangle_16x16.png";
      basicRunMenuCommand23.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/insertRoundRectangle_32x32.png";
      basicRunMenuCommand23.ToolTipDescription = Resources.Command_InsertRoundRectangle_ToolTip_Description;
      basicRunMenuCommand23.ToolTipText = Resources.Command_InsertRoundRectangle_ToolTip_Text;
      basicRunMenuCommand23.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableLayer;
      basicRunMenuCommand23.EnableCommand = false;
      basicRunMenuCommand23.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.InsertRoundedRectangleCommand = (MapInfoCommand) basicRunMenuCommand23;
      SpatialCommands.InsertRoundedRectangleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand24 = new MapBasicRunMenuCommand(1606, nameof (Buffer), (InputGestureCollection) null);
      basicRunMenuCommand24.Text = Resources.Command_Buffer_Label;
      basicRunMenuCommand24.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/Buffer_16x16.png";
      basicRunMenuCommand24.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/Buffer_32x32.png";
      basicRunMenuCommand24.ToolTipDescription = Resources.Command_Buffer_ToolTip_Description;
      basicRunMenuCommand24.ToolTipText = Resources.Command_Buffer_ToolTip_Text;
      basicRunMenuCommand24.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand24.EnableCommand = false;
      basicRunMenuCommand24.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.BufferCommand = (MapInfoCommand) basicRunMenuCommand24;
      SpatialCommands.BufferCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand25 = new MapBasicRunMenuCommand(1616, nameof (ConvexHull), (InputGestureCollection) null);
      basicRunMenuCommand25.Text = Resources.Command_ConvexHull_Label;
      basicRunMenuCommand25.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/ConvexHull_16x16.png";
      basicRunMenuCommand25.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/ConvexHull_32x32.png";
      basicRunMenuCommand25.ToolTipDescription = Resources.Command_ConvexHull_ToolTip_Description;
      basicRunMenuCommand25.ToolTipText = Resources.Command_ConvexHull_ToolTip_Text;
      basicRunMenuCommand25.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand25.EnableCommand = false;
      basicRunMenuCommand25.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.ConvexHullCommand = (MapInfoCommand) basicRunMenuCommand25;
      SpatialCommands.ConvexHullCommand.CreateScreenTip();
      SpatialCommands.LineStyleCommand = (MapInfoCommand) new MapBasicRunMenuCommand(501, nameof (LineStyle), MapInfoCommand.GetGesture(Resources.Command_LineStyle_KeyGesture), Resources.Command_LineStyle_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_32x32.png", Resources.Command_LineStyle_ToolTip_Description, Resources.Command_LineStyle_ToolTip_Text, Resources.Command_AlwaysEnabled, true, Resources.Command_Category_SpatialCommands);
      SpatialCommands.RegionStyleCommand = (MapInfoCommand) new MapBasicRunMenuCommand(502, nameof (RegionStyle), MapInfoCommand.GetGesture(Resources.Command_RegionStyle_KeyGesture), Resources.Command_RegionStyle_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_32x32.png", Resources.Command_RegionStyle_ToolTip_Description, Resources.Command_RegionStyle_ToolTip_Text, Resources.Command_AlwaysEnabled, true, Resources.Command_Category_SpatialCommands);
      SpatialCommands.TextStyleCommand = (MapInfoCommand) new MapBasicRunMenuCommand(504, nameof (TextStyle), MapInfoCommand.GetGesture(Resources.Command_TextStyle_KeyGesture), Resources.Command_TextStyle_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_32x32.png", Resources.Command_TextStyle_ToolTip_Description, Resources.Command_TextStyle_ToolTip_Text, Resources.Command_AlwaysEnabled, true, Resources.Command_Category_SpatialCommands);
      SpatialCommands.SymbolStyleCommand = (MapInfoCommand) new MapBasicRunMenuCommand(503, nameof (SymbolStyle), MapInfoCommand.GetGesture(Resources.Command_PointStyle_KeyGesture), Resources.Command_PointStyle_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_32x32.png", Resources.Command_PointStyle_ToolTip_Description, Resources.Command_PointStyle_ToolTip_Text, Resources.Command_AlwaysEnabled, true, Resources.Command_Category_SpatialCommands);
      SpatialCommands.SetTargetCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1610, nameof (SetTarget), MapInfoCommand.GetGesture(Resources.Command_SetTarget_KeyGesture), Resources.Command_SetTarget_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/setTarget_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/setTarget_32x32.png", Resources.Command_SetTarget_ToolTip_Description, Resources.Command_SetTarget_ToolTip_Text, Resources.Command_Disabled_NeedActiveMapEditableSelection, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.ClearTargetCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1611, nameof (ClearTarget), MapInfoCommand.GetGesture(Resources.Command_ClearTarget_KeyGesture), Resources.Command_ClearTarget_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clearTarget_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clearTarget_32x32.png", Resources.Command_ClearTarget_ToolTip_Description, Resources.Command_ClearTarget_ToolTip_Text, Resources.Command_Disabled_NeedSetTarget, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.EraseTargetCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1613, nameof (EraseTarget), (InputGestureCollection) null, Resources.Command_EraseTarget_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/erase_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/erase_32x32.png", Resources.Command_EraseTarget_ToolTip_Description, Resources.Command_EraseTarget_ToolTip_Text, Resources.Command_Disabled_EraseTarget, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.EraseOutsideTargetCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1614, nameof (EraseOutsideTarget), (InputGestureCollection) null, Resources.Command_EraseOutsideTarget_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/eraseOutside_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/eraseOutside_32x32.png", Resources.Command_EraseOutsideTarget_ToolTip_Description, Resources.Command_EraseOutsideTarget_ToolTip_Text, Resources.Command_Disabled_EraseTarget, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.CombineObjectsCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1605, nameof (CombineObjects), (InputGestureCollection) null, Resources.Command_CombineObjects_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/combineSelectObj_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/combineSelectObj_32x32.png", Resources.Command_CombineObjects_ToolTip_Description, Resources.Command_CombineObjects_ToolTip_Text, Resources.Command_Disabled_NeedMultipleSelection, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.DisaggregateCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1621, nameof (Disaggregate), (InputGestureCollection) null, Resources.Command_Disaggregate_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/disaggregateObject_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/disaggregateObject_32x32.png", Resources.Command_Disaggregate_ToolTip_Description, Resources.Command_Disaggregate_ToolTip_Text, Resources.Command_Disabled_NeedActiveMapEditableSelection, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.SplitTargetCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1612, nameof (SplitTarget), (InputGestureCollection) null, Resources.Command_SplitTarget_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/split_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/split_32x32.png", Resources.Command_SplitTarget_ToolTip_Description, Resources.Command_SplitTarget_ToolTip_Text, Resources.Command_Disabled_NeedSetTargetSelectCut, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.PolylineSplitCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1623, nameof (PolylineSplit), (InputGestureCollection) null, Resources.Command_PolylineSplit_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/polylineSplit_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/polylineSplit_32x32.png", Resources.Command_PolylineSplit_ToolTip_Description, Resources.Command_PolylineSplit_ToolTip_Text, Resources.Command_Disabled_NeedSetTargetSelectCut, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.PolylineSplitAtNodeCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1626, nameof (PolylineSplitAtNode), (InputGestureCollection) null, Resources.Command_PolylineSplitAtNode_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/polylineSplitNode_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/polylineSplitNode_32x32.png", Resources.Command_PolylineSplitAtNode_ToolTip_Description, Resources.Command_PolylineSplitAtNode_ToolTip_Text, Resources.Command_Disabled_PolylineSplitAtNode, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.OffsetObjectCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1624, nameof (OffsetObject), (InputGestureCollection) null, Resources.Command_OffsetObject_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/offsetObject_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/offsetObject_32x32.png", Resources.Command_OffsetObject_ToolTip_Description, Resources.Command_OffsetObject_ToolTip_Text, Resources.Command_Disabled_NeedActiveMapEditableSelection, false, Resources.Command_Category_SpatialCommands);
      SpatialCommands.RotateObjectCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1625, nameof (RotateObject), (InputGestureCollection) null, Resources.Command_RotateObject_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/rotateObject_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/rotateObject_32x32.png", Resources.Command_RotateObject_ToolTip_Description, Resources.Command_RotateObject_ToolTip_Text, Resources.Command_Disabled_NeedActiveMapEditableSelection, false, Resources.Command_Category_SpatialCommands);
      MapBasicRunMenuCommand basicRunMenuCommand26 = new MapBasicRunMenuCommand(420, nameof (VoronoiTable), (InputGestureCollection) null);
      basicRunMenuCommand26.Text = Resources.Command_VoronoiTable_Label;
      basicRunMenuCommand26.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/voronoiTable_16x16.png";
      basicRunMenuCommand26.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/voronoiTable_32x32.png";
      basicRunMenuCommand26.ToolTipDescription = Resources.Command_VoronoiTable_ToolTip_Description;
      basicRunMenuCommand26.ToolTipText = Resources.Command_VoronoiTable_ToolTip_Text;
      basicRunMenuCommand26.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand26.EnableCommand = false;
      basicRunMenuCommand26.Category = Resources.Command_Category_SpatialCommands;
      SpatialCommands.VoronoiTableCommand = (MapInfoCommand) basicRunMenuCommand26;
      SpatialCommands.VoronoiTableCommand.CreateScreenTip();
    }

    public static MapInfoCommand InsertSymbol
    {
      get
      {
        return SpatialCommands.InsertSymbolCommand;
      }
    }

    public static MapInfoCommand InsertText
    {
      get
      {
        return SpatialCommands.InsertTextCommand;
      }
    }

    public static MapInfoCommand InsertLine
    {
      get
      {
        return SpatialCommands.InsertLineCommand;
      }
    }

    public static MapInfoCommand InsertPolyline
    {
      get
      {
        return SpatialCommands.InsertPolylineCommand;
      }
    }

    public static MapInfoCommand InsertArc
    {
      get
      {
        return SpatialCommands.InsertArcCommand;
      }
    }

    public static MapInfoCommand InsertPolygon
    {
      get
      {
        return SpatialCommands.InsertPolygonCommand;
      }
    }

    public static MapInfoCommand InsertEllipse
    {
      get
      {
        return SpatialCommands.InsertEllipseCommand;
      }
    }

    public static MapInfoCommand InsertRectangle
    {
      get
      {
        return SpatialCommands.InsertRectangleCommand;
      }
    }

    public static MapInfoCommand InsertRoundedRectangle
    {
      get
      {
        return SpatialCommands.InsertRoundedRectangleCommand;
      }
    }

    public static MapInfoCommand Buffer
    {
      get
      {
        return SpatialCommands.BufferCommand;
      }
    }

    public static MapInfoCommand ConvexHull
    {
      get
      {
        return SpatialCommands.ConvexHullCommand;
      }
    }

    public static MapInfoCommand ConvertToRegion
    {
      get
      {
        return SpatialCommands.ConvertToRegionCommand;
      }
    }

    public static MapInfoCommand ConvertToPolyline
    {
      get
      {
        return SpatialCommands.ConvertToPolylineCommand;
      }
    }

    public static MapInfoCommand Enclose
    {
      get
      {
        return SpatialCommands.EncloseCommand;
      }
    }

    public static MapInfoCommand CreateDriveRegions
    {
      get
      {
        return SpatialCommands.CreateDriveRegionsCommand;
      }
    }

    public static MapInfoCommand DriveRegionsTable
    {
      get
      {
        return SpatialCommands.DriveRegionsTableCommand;
      }
    }

    public static MapInfoCommand Voronoi
    {
      get
      {
        return SpatialCommands.VoronoiCommand;
      }
    }

    public static MapInfoCommand CheckRegions
    {
      get
      {
        return SpatialCommands.CheckRegionsCommand;
      }
    }

    public static MapInfoCommand Clean
    {
      get
      {
        return SpatialCommands.CleanCommand;
      }
    }

    public static MapInfoCommand Snap
    {
      get
      {
        return SpatialCommands.SnapCommand;
      }
    }

    public static MapInfoCommand Smooth
    {
      get
      {
        return SpatialCommands.SmoothCommand;
      }
    }

    public static MapInfoCommand Unsmooth
    {
      get
      {
        return SpatialCommands.UnsmoothCommand;
      }
    }

    public static MapInfoCommand LineStyle
    {
      get
      {
        return SpatialCommands.LineStyleCommand;
      }
    }

    public static MapInfoCommand RegionStyle
    {
      get
      {
        return SpatialCommands.RegionStyleCommand;
      }
    }

    public static MapInfoCommand TextStyle
    {
      get
      {
        return SpatialCommands.TextStyleCommand;
      }
    }

    public static MapInfoCommand SymbolStyle
    {
      get
      {
        return SpatialCommands.SymbolStyleCommand;
      }
    }

    public static MapInfoCommand SetTarget
    {
      get
      {
        return SpatialCommands.SetTargetCommand;
      }
    }

    public static MapInfoCommand ClearTarget
    {
      get
      {
        return SpatialCommands.ClearTargetCommand;
      }
    }

    public static MapInfoCommand EraseTarget
    {
      get
      {
        return SpatialCommands.EraseTargetCommand;
      }
    }

    public static MapInfoCommand EraseOutsideTarget
    {
      get
      {
        return SpatialCommands.EraseOutsideTargetCommand;
      }
    }

    public static MapInfoCommand CombineObjects
    {
      get
      {
        return SpatialCommands.CombineObjectsCommand;
      }
    }

    public static MapInfoCommand Disaggregate
    {
      get
      {
        return SpatialCommands.DisaggregateCommand;
      }
    }

    public static MapInfoCommand SplitTarget
    {
      get
      {
        return SpatialCommands.SplitTargetCommand;
      }
    }

    public static MapInfoCommand PolylineSplit
    {
      get
      {
        return SpatialCommands.PolylineSplitCommand;
      }
    }

    public static MapInfoCommand PolylineSplitAtNode
    {
      get
      {
        return SpatialCommands.PolylineSplitAtNodeCommand;
      }
    }

    public static MapInfoCommand OffsetObject
    {
      get
      {
        return SpatialCommands.OffsetObjectCommand;
      }
    }

    public static MapInfoCommand RotateObject
    {
      get
      {
        return SpatialCommands.RotateObjectCommand;
      }
    }

    public static MapInfoCommand Reshape
    {
      get
      {
        return SpatialCommands.ReshapeCommand;
      }
    }

    public static MapInfoCommand OverlayNode
    {
      get
      {
        return SpatialCommands.OverlayNodeCommand;
      }
    }

    public static MapInfoCommand DigitizerSetup
    {
      get
      {
        return SpatialCommands.DigitizerSetupCommand;
      }
    }

    public static MapInfoCommand VoronoiTable
    {
      get
      {
        return SpatialCommands.VoronoiTableCommand;
      }
    }
  }
}
