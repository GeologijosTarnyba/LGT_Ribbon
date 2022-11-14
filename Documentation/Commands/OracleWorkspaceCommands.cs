// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.OracleWorkspaceCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class OracleWorkspaceCommands
  {
    private static readonly MapInfoCommand CreateWorkspaceCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1804, "CreateOracleWorkspace", (InputGestureCollection) null, Resources.Command_CreateOracleWorkspace_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/createOracleWorkspace_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/createOracleWorkspace_32x32.png", Resources.Command_CreateOracleWorkspace_ToolTip_Description, Resources.Command_CreateOracleWorkspace_ToolTip_Text, Resources.Command_Disabled_NeedOpenOracleTables, false, Resources.Command_Category_OracleWorkspaceCommands);
    private static readonly MapInfoCommand DeleteWorkspaceCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1805, "DeleteOracleWorkspace", (InputGestureCollection) null, Resources.Command_DeleteOracleWorkspace_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/deleteOracleWorkspace_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/deleteOracleWorkspace_32x32.png", Resources.Command_DeleteOracleWorkspace_ToolTip_Description, Resources.Command_DeleteOracleWorkspace_ToolTip_Text, Resources.Command_Disabled_NeedOpenOracleTables, false, Resources.Command_Category_OracleWorkspaceCommands);
    private static readonly MapInfoCommand DisableOracleVersioningCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1807, nameof (DisableOracleVersioning), (InputGestureCollection) null, Resources.Command_DisableOracleVersioning_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/disableOracleVersioning_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/disableOracleVersioning_32x32.png", Resources.Command_DisableOracleVersioning_ToolTip_Description, Resources.Command_DisableOracleVersioning_ToolTip_Text, Resources.Command_Disabled_NeedVersionedOracleTables, false, Resources.Command_Category_OracleWorkspaceCommands);
    private static readonly MapInfoCommand EnableOracleVersioningCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1806, nameof (EnableOracleVersioning), (InputGestureCollection) null, Resources.Command_EnableOracleVersioning_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/enableOracleVersioning_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/enableOracleVersioning_32x32.png", Resources.Command_EnableOracleVersioning_ToolTip_Description, Resources.Command_EnableOracleVersioning_ToolTip_Text, Resources.Command_Disabled_NeedOpenOracleTablesWithPK, false, Resources.Command_Category_OracleWorkspaceCommands);
    private static readonly MapInfoCommand MergeOracleTableCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1808, nameof (MergeTable), (InputGestureCollection) null, Resources.Command_MergeTable_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/mergeOracleTable_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/mergeOracleTable_32x32.png", Resources.Command_MergeTable_ToolTip_Description, Resources.Command_MergeTable_ToolTip_Text, Resources.Command_Disabled_NeedOpenOracleWorkspaces, false, Resources.Command_Category_OracleWorkspaceCommands);
    private static readonly MapInfoCommand RefreshOracleTableCommand = (MapInfoCommand) new MapBasicRunMenuCommand(1809, nameof (RefreshOracleTable), (InputGestureCollection) null, Resources.Command_RefreshOracleTable_Label, "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/refreshOracleTable_16x16.png", "pack://application:,,,/MapInfo.StyleResources;component/Images/Oracle/refreshOracleTable_32x32.png", Resources.Command_RefreshOracleTable_ToolTip_Description, Resources.Command_RefreshOracleTable_ToolTip_Text, Resources.Command_Disabled_NeedOpenOracleWorkspaces, false, Resources.Command_Category_OracleWorkspaceCommands);

    public static MapInfoCommand CreateWorkspace
    {
      get
      {
        return OracleWorkspaceCommands.CreateWorkspaceCommand;
      }
    }

    public static MapInfoCommand DeleteWorkspace
    {
      get
      {
        return OracleWorkspaceCommands.DeleteWorkspaceCommand;
      }
    }

    public static MapInfoCommand DisableOracleVersioning
    {
      get
      {
        return OracleWorkspaceCommands.DisableOracleVersioningCommand;
      }
    }

    public static MapInfoCommand EnableOracleVersioning
    {
      get
      {
        return OracleWorkspaceCommands.EnableOracleVersioningCommand;
      }
    }

    public static MapInfoCommand MergeTable
    {
      get
      {
        return OracleWorkspaceCommands.MergeOracleTableCommand;
      }
    }

    public static MapInfoCommand RefreshOracleTable
    {
      get
      {
        return OracleWorkspaceCommands.RefreshOracleTableCommand;
      }
    }
  }
}
