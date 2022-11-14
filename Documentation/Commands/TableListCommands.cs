// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.TableListCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class TableListCommands
  {
    public static MapInfoCommand TlvSelectAllFromTable { get; private set; }

    public static MapInfoCommand TlvBrowseTable { get; private set; }

    public static MapInfoCommand TlvOpenNewMap { get; private set; }

    public static MapInfoCommand TlvExportTable { get; private set; }

    public static MapInfoCommand TlvRefreshTable { get; private set; }

    public static MapInfoCommand TlvTableStructure { get; private set; }

    public static MapInfoCommand TlvCreatePoints { get; private set; }

    public static MapInfoCommand TlvUpdateColumn { get; private set; }

    public static MapInfoCommand TlvCloseTable { get; private set; }

    public static MapInfoCommand TlvViewMetaData { get; private set; }

    public static MapInfoCommand TlvAddToLibrary { get; private set; }

    public static MapInfoCommand TlvCompareStructure { get; private set; }

    public static MapInfoCommand TlvRenameTable { get; private set; }

    static TableListCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(2601, nameof (TlvSelectAllFromTable), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_TlvSelectAllFromTable_Label;
      basicRunMenuCommand1.SmallIcon = (string) null;
      basicRunMenuCommand1.LargeIcon = (string) null;
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_TlvSelectAllFromTable_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_TlvSelectAllFromTable_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_TableListCommands;
      basicRunMenuCommand1.MenuItemText = Resources.Command_TlvSelectAllFromTable_MenuItemText;
      TableListCommands.TlvSelectAllFromTable = (MapInfoCommand) basicRunMenuCommand1;
      TableListCommands.TlvSelectAllFromTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(2602, nameof (TlvBrowseTable), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_TlvBrowseTable_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_TlvBrowseTable_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_TlvBrowseTable_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvBrowseTable = (MapInfoCommand) basicRunMenuCommand2;
      TableListCommands.TlvBrowseTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(2603, nameof (TlvOpenNewMap), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_TlvOpenNewMap_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newMap_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newMap_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_TlvOpenNewMap_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_TlvOpenNewMap_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvOpenNewMap = (MapInfoCommand) basicRunMenuCommand3;
      TableListCommands.TlvOpenNewMap.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(2604, nameof (TlvExportTable), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_TlvExportTable_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/exportTable_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/exportTable_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_TlvExportTable_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_TlvExportTable_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvExportTable = (MapInfoCommand) basicRunMenuCommand4;
      TableListCommands.TlvExportTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(2605, nameof (TlvRefreshTable), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_TlvRefreshTable_Label;
      basicRunMenuCommand5.SmallIcon = (string) null;
      basicRunMenuCommand5.LargeIcon = (string) null;
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_TlvRefreshTable_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_TlvRefreshTable_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvRefreshTable = (MapInfoCommand) basicRunMenuCommand5;
      TableListCommands.TlvRefreshTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(2606, nameof (TlvTableStructure), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_TlvTableStructure_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/modifyStructure_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/modifyStructure_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_TlvTableStructure_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_TlvTableStructure_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvTableStructure = (MapInfoCommand) basicRunMenuCommand6;
      TableListCommands.TlvTableStructure.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(2607, nameof (TlvCreatePoints), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_TlvCreatePoints_Label;
      basicRunMenuCommand7.SmallIcon = (string) null;
      basicRunMenuCommand7.LargeIcon = (string) null;
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_TlvCreatePoints_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_TlvCreatePoints_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvCreatePoints = (MapInfoCommand) basicRunMenuCommand7;
      TableListCommands.TlvCreatePoints.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(2608, nameof (TlvUpdateColumn), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_TlvUpdateColumn_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/updateColumn_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/updateColumn_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_TlvUpdateColumn_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_TlvUpdateColumn_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvUpdateColumn = (MapInfoCommand) basicRunMenuCommand8;
      TableListCommands.TlvUpdateColumn.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(2610, nameof (TlvViewMetaData), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_TlvViewMetaData_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/viewEditMetadata_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/viewEditMetadata_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_TlvViewMetaData_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_TlvViewMetaData_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvViewMetaData = (MapInfoCommand) basicRunMenuCommand9;
      TableListCommands.TlvViewMetaData.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(2609, nameof (TlvCloseTable), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_TlvCloseTable_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_TlvCloseTable_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_TlvCloseTable_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvCloseTable = (MapInfoCommand) basicRunMenuCommand10;
      TableListCommands.TlvCloseTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(2613, nameof (TlvRenameTable), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_TlvRenameTable_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/renameTable_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/renameTable_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_TlvRenameTable_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_TlvRenameTable_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvRenameTable = (MapInfoCommand) basicRunMenuCommand11;
      TableListCommands.TlvRenameTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(2611, nameof (TlvAddToLibrary), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_TlvAddToLibrary_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToLibrary_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToLibrary_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_TlvAddToLibrary_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_TlvAddToLibrary_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvAddToLibrary = (MapInfoCommand) basicRunMenuCommand12;
      TableListCommands.TlvAddToLibrary.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(2612, nameof (TlvCompareStructure), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_TlvCompareStructure_Label;
      basicRunMenuCommand13.SmallIcon = (string) null;
      basicRunMenuCommand13.LargeIcon = (string) null;
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_TlvCompareStructure_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_TlvCompareStructure_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_TableListCommands;
      TableListCommands.TlvCompareStructure = (MapInfoCommand) basicRunMenuCommand13;
      TableListCommands.TlvCompareStructure.CreateScreenTip();
    }
  }
}
