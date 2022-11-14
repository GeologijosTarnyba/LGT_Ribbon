// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.TableCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class TableCommands
  {
    private static readonly MapInfoCommand RevertTableCommand;
    private static readonly MapInfoCommand UpdateColumnCommand;
    private static readonly MapInfoCommand AppendCommand;
    private static readonly MapInfoCommand GeoCodeCommand;
    private static readonly MapInfoCommand WebGeoCodeCommand;
    private static readonly MapInfoCommand CreatePointsCommand;
    private static readonly MapInfoCommand MergeUsingColumnCommand;
    private static readonly MapInfoCommand BufferCommand;
    private static readonly MapInfoCommand ExportCommand;
    private static readonly MapInfoCommand MakeMappableCommand;
    private static readonly MapInfoCommand ChangeSymbolCommand;
    private static readonly MapInfoCommand UnlinkCommand;
    private static readonly MapInfoCommand RefreshDBMSCommand;
    private static readonly MapInfoCommand RasterStyleCommand;
    private static readonly MapInfoCommand RasterRegCommand;
    private static readonly MapInfoCommand UniversalDataRefreshCommand;
    private static readonly MapInfoCommand AddToLibraryCommand;
    private static readonly MapInfoCommand ViewEditMetadataCommand;
    private static readonly MapInfoCommand ModifyStructureCommand;
    private static readonly MapInfoCommand DeleteCommand;
    private static readonly MapInfoCommand RenameCommand;
    private static readonly MapInfoCommand PackCommand;
    private static readonly MapInfoCommand HotlinkOptionsCommand;
    private static readonly MapInfoCommand OpenDBMSTableCommand;
    private static readonly MapInfoCommand CloseDBMSTableCommand;
    private static readonly MapInfoCommand CloseDBMSConnectionCommand;
    private static readonly MapInfoCommand CalcColStatsCommand;

    static TableCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(3101, nameof (OpenDBMSTable), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_OpenDBMSTable_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/openTable_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/openTable_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_OpenDBMSTable_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_OpenDBMSTable_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.Category = Resources.Command_Category_TableCommands;
      TableCommands.OpenDBMSTableCommand = (MapInfoCommand) basicRunMenuCommand1;
      TableCommands.OpenDBMSTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(3102, nameof (CloseDBMSTable), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_CloseDBMSTable_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_CloseDBMSTable_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_CloseDBMSTable_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand2.Category = Resources.Command_Category_TableCommands;
      TableCommands.CloseDBMSTableCommand = (MapInfoCommand) basicRunMenuCommand2;
      TableCommands.CloseDBMSTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(3103, nameof (CloseDBMSConnection), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_CloseDBMSConnection_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeDbms_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeDbms_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_CloseDBMSConnection_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_CloseDBMSConnection_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenDBMSConnection;
      basicRunMenuCommand3.Category = Resources.Command_Category_TableCommands;
      TableCommands.CloseDBMSConnectionCommand = (MapInfoCommand) basicRunMenuCommand3;
      TableCommands.CloseDBMSConnectionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(1740, nameof (AddToLibrary), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_AddToLibrary_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToLibrary_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToLibrary_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_AddToLibrary_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_AddToLibrary_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedLibraryServices;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_TableCommands;
      TableCommands.AddToLibraryCommand = (MapInfoCommand) basicRunMenuCommand4;
      TableCommands.AddToLibraryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(1741, nameof (ViewEditMetadata), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_ViewEditMetadata_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/viewEditMetadata_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/viewEditMetadata_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_ViewEditMetadata_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_ViewEditMetadata_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedManagedTable;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_TableCommands;
      TableCommands.ViewEditMetadataCommand = (MapInfoCommand) basicRunMenuCommand5;
      TableCommands.ViewEditMetadataCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(107, nameof (RevertTable), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_RevertTable_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/revertTable_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/revertTable_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_RevertTable_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_RevertTable_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedEditedTable;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_TableCommands;
      TableCommands.RevertTableCommand = (MapInfoCommand) basicRunMenuCommand6;
      TableCommands.RevertTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(405, nameof (UpdateColumn), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_UpdateColumn_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/updateColumn_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/updateColumn_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_UpdateColumn_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_UpdateColumn_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedNonReadOnlyOpenTable;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_TableCommands;
      TableCommands.UpdateColumnCommand = (MapInfoCommand) basicRunMenuCommand7;
      TableCommands.UpdateColumnCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(411, nameof (Append), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_Append_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/appendRows_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/appendRows_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_Append_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_Append_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedTwoOrMoreOpenTable;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_TableCommands;
      TableCommands.AppendCommand = (MapInfoCommand) basicRunMenuCommand8;
      TableCommands.AppendCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(407, "Geocode", (InputGestureCollection) null);
      basicRunMenuCommand9.DisplayText = Resources.Command_Geocode_Label;
      basicRunMenuCommand9.Text = Resources.Command_Geocode_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/geocode_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/geocode_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_Geocode_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_Geocode_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedTwoOrMoreOpenTable;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_TableCommands;
      TableCommands.GeoCodeCommand = (MapInfoCommand) basicRunMenuCommand9;
      TableCommands.GeoCodeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(424, "WebGeocode", (InputGestureCollection) null);
      basicRunMenuCommand10.DisplayText = Resources.Command_WebGeocode_Label;
      basicRunMenuCommand10.Text = Resources.Command_Geocode_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/geocodeServer_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/geocodeServer_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_WebGeocode_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_WebGeocode_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedTwoOrMoreOpenTable;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_TableCommands;
      TableCommands.WebGeoCodeCommand = (MapInfoCommand) basicRunMenuCommand10;
      TableCommands.WebGeoCodeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(408, nameof (CreatePoints), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_CreatePoints_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/createPoints_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/createPoints_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_CreatePoints_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_CreatePoints_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveBrowserWindow;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_TableCommands;
      TableCommands.CreatePointsCommand = (MapInfoCommand) basicRunMenuCommand11;
      TableCommands.CreatePointsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(406, nameof (MergeUsingColumn), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_MergeUsingColumn_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/combineUsingCol_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/combineUsingCol_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_MergeUsingColumn_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_MergeUsingColumn_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_TableCommands;
      TableCommands.MergeUsingColumnCommand = (MapInfoCommand) basicRunMenuCommand12;
      TableCommands.MergeUsingColumnCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(419, "BufferTable", (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_BufferTable_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/bufferTable_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/bufferTable_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_BufferTable_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_BufferTable_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_TableCommands;
      TableCommands.BufferCommand = (MapInfoCommand) basicRunMenuCommand13;
      TableCommands.BufferCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(402, nameof (Export), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_Export_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/exportTable_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/exportTable_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_Export_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_Export_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_TableCommands;
      TableCommands.ExportCommand = (MapInfoCommand) basicRunMenuCommand14;
      TableCommands.ExportCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(404, "TableModifyStructure", (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_TableModifyStructure_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/modifyTableStructure_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/modifyTableStructure_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_TableModifyStructure_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_TableModifyStructure_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_TableCommands;
      TableCommands.ModifyStructureCommand = (MapInfoCommand) basicRunMenuCommand15;
      TableCommands.ModifyStructureCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(409, "TableDelete", (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_TableDelete_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/deleteTable_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/deleteTable_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_TableDelete_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_TableDelete_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.Category = Resources.Command_Category_TableCommands;
      TableCommands.DeleteCommand = (MapInfoCommand) basicRunMenuCommand16;
      TableCommands.DeleteCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(410, "TableRename", (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_TableRename_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/renameTable_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/renameTable_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_TableRename_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_TableRename_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_TableCommands;
      TableCommands.RenameCommand = (MapInfoCommand) basicRunMenuCommand17;
      TableCommands.RenameCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(403, "TablePack", (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_TablePack_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/packTable_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/packTable_32x32.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_TablePack_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_TablePack_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand18.EnableCommand = false;
      basicRunMenuCommand18.Category = Resources.Command_Category_TableCommands;
      TableCommands.PackCommand = (MapInfoCommand) basicRunMenuCommand18;
      TableCommands.PackCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(415, nameof (MakeMappable), (InputGestureCollection) null);
      basicRunMenuCommand19.Text = Resources.Command_MakeMappable_Label;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/makeDatabaseMappable_16x16.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/makeDatabaseMappable_32x32.png";
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_MakeMappable_ToolTip_Description;
      basicRunMenuCommand19.ToolTipText = Resources.Command_MakeMappable_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand19.EnableCommand = true;
      basicRunMenuCommand19.Category = Resources.Command_Category_TableCommands;
      TableCommands.MakeMappableCommand = (MapInfoCommand) basicRunMenuCommand19;
      TableCommands.MakeMappableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand20 = new MapBasicRunMenuCommand(418, nameof (ChangeSymbol), (InputGestureCollection) null);
      basicRunMenuCommand20.Text = Resources.Command_ChangeSymbol_Label;
      basicRunMenuCommand20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/changeTableSymbol_16x16.png";
      basicRunMenuCommand20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/changeTableSymbol_32x32.png";
      basicRunMenuCommand20.ToolTipDescription = Resources.Command_ChangeSymbol_ToolTip_Description;
      basicRunMenuCommand20.ToolTipText = Resources.Command_ChangeSymbol_ToolTip_Text;
      basicRunMenuCommand20.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand20.EnableCommand = true;
      basicRunMenuCommand20.Category = Resources.Command_Category_TableCommands;
      TableCommands.ChangeSymbolCommand = (MapInfoCommand) basicRunMenuCommand20;
      TableCommands.ChangeSymbolCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand21 = new MapBasicRunMenuCommand(416, nameof (Unlink), (InputGestureCollection) null);
      basicRunMenuCommand21.Text = Resources.Command_Unlink_Label;
      basicRunMenuCommand21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/unlinkDBMSTable_16x16.png";
      basicRunMenuCommand21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/unlinkDBMSTable_32x32.png";
      basicRunMenuCommand21.ToolTipDescription = Resources.Command_Unlink_ToolTip_Description;
      basicRunMenuCommand21.ToolTipText = Resources.Command_Unlink_ToolTip_Text;
      basicRunMenuCommand21.ToolTipDisabledText = Resources.Command_Disabled_NeedLinkedTableNoPendingEdits;
      basicRunMenuCommand21.EnableCommand = false;
      basicRunMenuCommand21.Category = Resources.Command_Category_TableCommands;
      TableCommands.UnlinkCommand = (MapInfoCommand) basicRunMenuCommand21;
      TableCommands.UnlinkCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand22 = new MapBasicRunMenuCommand(417, nameof (RefreshDBMS), (InputGestureCollection) null);
      basicRunMenuCommand22.Text = Resources.Command_RefreshDBMS_Label;
      basicRunMenuCommand22.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/refreshDBMSTable_16x16.png";
      basicRunMenuCommand22.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/refreshDBMSTable_32x32.png";
      basicRunMenuCommand22.ToolTipDescription = Resources.Command_RefreshDBMS_ToolTip_Description;
      basicRunMenuCommand22.ToolTipText = Resources.Command_RefreshDBMS_ToolTip_Text;
      basicRunMenuCommand22.ToolTipDisabledText = Resources.Command_Disabled_NeedLinkedTableNoPendingEdits;
      basicRunMenuCommand22.EnableCommand = false;
      basicRunMenuCommand22.Category = Resources.Command_Category_TableCommands;
      TableCommands.RefreshDBMSCommand = (MapInfoCommand) basicRunMenuCommand22;
      TableCommands.RefreshDBMSCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand23 = new MapBasicRunMenuCommand(714, nameof (HotlinkOptions), (InputGestureCollection) null);
      basicRunMenuCommand23.Text = Resources.Command_HotlinkOptions_Label;
      basicRunMenuCommand23.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/hotLinkOptions_16x16.png";
      basicRunMenuCommand23.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/hotLinkOptions_32x32.png";
      basicRunMenuCommand23.ToolTipDescription = Resources.Command_HotLinkOptions_ToolTip_Description;
      basicRunMenuCommand23.ToolTipText = Resources.Command_HotLinkOptions_ToolTip_Text;
      basicRunMenuCommand23.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveBrowserWindow;
      basicRunMenuCommand23.EnableCommand = false;
      basicRunMenuCommand23.CustomHelpId = new int?(MapInfoConstants.HotlinkOptionsHelpId);
      basicRunMenuCommand23.Category = Resources.Command_Category_TableCommands;
      TableCommands.HotlinkOptionsCommand = (MapInfoCommand) basicRunMenuCommand23;
      TableCommands.HotlinkOptionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand24 = new MapBasicRunMenuCommand(414, nameof (RasterStyle), (InputGestureCollection) null);
      basicRunMenuCommand24.Text = Resources.Command_RasterStyle_Label;
      basicRunMenuCommand24.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterImageStyle_16x16.png";
      basicRunMenuCommand24.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterImageStyle_32x32.png";
      basicRunMenuCommand24.ToolTipDescription = Resources.Command_RasterStyle_ToolTip_Description;
      basicRunMenuCommand24.ToolTipText = Resources.Command_RasterStyle_ToolTip_Text;
      basicRunMenuCommand24.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenRasterImageTable;
      basicRunMenuCommand24.EnableCommand = false;
      basicRunMenuCommand24.Category = Resources.Command_Category_TableCommands;
      TableCommands.RasterStyleCommand = (MapInfoCommand) basicRunMenuCommand24;
      TableCommands.RasterStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand25 = new MapBasicRunMenuCommand(413, nameof (RasterReg), (InputGestureCollection) null);
      basicRunMenuCommand25.Text = Resources.Command_RasterReg_Label;
      basicRunMenuCommand25.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterRegistration_16x16.png";
      basicRunMenuCommand25.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterRegistration_32x32.png";
      basicRunMenuCommand25.ToolTipDescription = Resources.Command_RasterReg_ToolTip_Description;
      basicRunMenuCommand25.ToolTipText = Resources.Command_RasterReg_ToolTip_Text;
      basicRunMenuCommand25.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenRasterImageTable;
      basicRunMenuCommand25.EnableCommand = false;
      basicRunMenuCommand25.Category = Resources.Command_Category_TableCommands;
      TableCommands.RasterRegCommand = (MapInfoCommand) basicRunMenuCommand25;
      TableCommands.RasterRegCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand26 = new MapBasicRunMenuCommand(426, nameof (UniversalDataRefresh), (InputGestureCollection) null);
      basicRunMenuCommand26.Text = Resources.Command_UniversalDataRefresh_Label;
      basicRunMenuCommand26.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_16x16.png";
      basicRunMenuCommand26.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_32x32.png";
      basicRunMenuCommand26.ToolTipDescription = Resources.Command_UniversalDataRefresh_ToolTip_Description;
      basicRunMenuCommand26.ToolTipText = Resources.Command_UniversalDataRefresh_ToolTip_Text;
      basicRunMenuCommand26.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenUniversalDataTable;
      basicRunMenuCommand26.EnableCommand = false;
      basicRunMenuCommand26.Category = Resources.Command_Category_TableCommands;
      TableCommands.UniversalDataRefreshCommand = (MapInfoCommand) basicRunMenuCommand26;
      TableCommands.UniversalDataRefreshCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand27 = new MapBasicRunMenuCommand(309, nameof (CalcColStats), (InputGestureCollection) null);
      basicRunMenuCommand27.Text = Resources.Command_CalcColStats_Label;
      basicRunMenuCommand27.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/calcStatistics_16x16.png";
      basicRunMenuCommand27.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/calcStatistics_32x32.png";
      basicRunMenuCommand27.ToolTipDescription = Resources.Command_CalcColStats_ToolTip_Description;
      basicRunMenuCommand27.ToolTipText = Resources.Command_CalcColStats_ToolTip_Text;
      basicRunMenuCommand27.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableWithNumericColumn;
      basicRunMenuCommand27.EnableCommand = false;
      basicRunMenuCommand27.Category = Resources.Command_Category_TableCommands;
      TableCommands.CalcColStatsCommand = (MapInfoCommand) basicRunMenuCommand27;
      TableCommands.CalcColStatsCommand.CreateScreenTip();
    }

    public static MapInfoCommand AddToLibrary
    {
      get
      {
        return TableCommands.AddToLibraryCommand;
      }
    }

    public static MapInfoCommand ViewEditMetadata
    {
      get
      {
        return TableCommands.ViewEditMetadataCommand;
      }
    }

    public static MapInfoCommand RevertTable
    {
      get
      {
        return TableCommands.RevertTableCommand;
      }
    }

    public static MapInfoCommand UpdateColumn
    {
      get
      {
        return TableCommands.UpdateColumnCommand;
      }
    }

    public static MapInfoCommand Append
    {
      get
      {
        return TableCommands.AppendCommand;
      }
    }

    public static MapInfoCommand GeoCode
    {
      get
      {
        return TableCommands.GeoCodeCommand;
      }
    }

    public static MapInfoCommand WebGeoCode
    {
      get
      {
        return TableCommands.WebGeoCodeCommand;
      }
    }

    public static MapInfoCommand CreatePoints
    {
      get
      {
        return TableCommands.CreatePointsCommand;
      }
    }

    public static MapInfoCommand MergeUsingColumn
    {
      get
      {
        return TableCommands.MergeUsingColumnCommand;
      }
    }

    public static MapInfoCommand Buffer
    {
      get
      {
        return TableCommands.BufferCommand;
      }
    }

    public static MapInfoCommand Export
    {
      get
      {
        return TableCommands.ExportCommand;
      }
    }

    public static MapInfoCommand ModifyStructure
    {
      get
      {
        return TableCommands.ModifyStructureCommand;
      }
    }

    public static MapInfoCommand Delete
    {
      get
      {
        return TableCommands.DeleteCommand;
      }
    }

    public static MapInfoCommand Rename
    {
      get
      {
        return TableCommands.RenameCommand;
      }
    }

    public static MapInfoCommand Pack
    {
      get
      {
        return TableCommands.PackCommand;
      }
    }

    public static MapInfoCommand MakeMappable
    {
      get
      {
        return TableCommands.MakeMappableCommand;
      }
    }

    public static MapInfoCommand ChangeSymbol
    {
      get
      {
        return TableCommands.ChangeSymbolCommand;
      }
    }

    public static MapInfoCommand Unlink
    {
      get
      {
        return TableCommands.UnlinkCommand;
      }
    }

    public static MapInfoCommand RefreshDBMS
    {
      get
      {
        return TableCommands.RefreshDBMSCommand;
      }
    }

    public static MapInfoCommand HotlinkOptions
    {
      get
      {
        return TableCommands.HotlinkOptionsCommand;
      }
    }

    public static MapInfoCommand RasterStyle
    {
      get
      {
        return TableCommands.RasterStyleCommand;
      }
    }

    public static MapInfoCommand RasterReg
    {
      get
      {
        return TableCommands.RasterRegCommand;
      }
    }

    public static MapInfoCommand UniversalDataRefresh
    {
      get
      {
        return TableCommands.UniversalDataRefreshCommand;
      }
    }

    public static MapInfoCommand OpenDBMSTable
    {
      get
      {
        return TableCommands.OpenDBMSTableCommand;
      }
    }

    public static MapInfoCommand CloseDBMSTable
    {
      get
      {
        return TableCommands.CloseDBMSTableCommand;
      }
    }

    public static MapInfoCommand CloseDBMSConnection
    {
      get
      {
        return TableCommands.CloseDBMSConnectionCommand;
      }
    }

    public static MapInfoCommand CalcColStats
    {
      get
      {
        return TableCommands.CalcColStatsCommand;
      }
    }
  }
}
