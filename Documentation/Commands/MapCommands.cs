// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.MapCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class MapCommands
  {
    private static readonly MapInfoCommand AddBasemapAerialCommand;
    private static readonly MapInfoCommand AddBasemapHybridCommand;
    private static readonly MapInfoCommand AddBasemapRoadsCommand;
    private static readonly MapInfoCommand ClearCustomLabelsCommand;
    private static readonly MapInfoCommand WorkspaceExplorerCommand;
    private static readonly MapInfoCommand DragMapCommand;
    private static readonly MapInfoCommand SetClipRegionCommand;
    private static readonly MapInfoCommand ClipRegionOnOffCommand;
    private static readonly MapInfoCommand RedrawOnOffCommand;
    private static readonly MapInfoCommand ViewEntireLayerCommand;
    private static readonly MapInfoCommand ViewEntireMapCommand;
    private static readonly MapInfoCommand ViewEntireSelectedObjectsCommand;
    private static readonly MapInfoCommand ViewEntireSelectionLayerCommand;
    private static readonly MapInfoCommand ViewNearestTileServerLevelCommand;
    private static readonly MapInfoCommand SelectAllFromSelectionCommand;
    private static readonly MapInfoCommand MakeSelectionEditableCommand;
    private static readonly MapInfoCommand MoveMapToCommand;
    private static readonly MapInfoCommand PreviousViewCommand;
    private static readonly MapInfoCommand CloneMapperCommand;
    private static readonly MapInfoCommand ChangeViewCommand;
    private static readonly MapInfoCommand MapOptionsCommand;
    private static readonly MapInfoCommand CreateScalebarCommand;
    private static readonly MapInfoCommand AddThematicCommand;
    private static readonly MapInfoCommand CreateLegendDesignerCommand;
    private static readonly MapInfoCommand LockScaleCommand;
    private static readonly MapInfoCommand SelectableLabelsCommand;
    private static readonly MapInfoCommand SnapToNodeCommand;
    private static readonly MapInfoCommand HotlinkOptionsCommand;
    private static readonly MapInfoCommand RefreshGridTexture_3DMapCommand;
    private static readonly MapInfoCommand CloneView_3DMapCommand;
    private static readonly MapInfoCommand PreviousView_3DMapCommand;
    private static readonly MapInfoCommand ViewEntireGrid_3DMapCommand;
    private static readonly MapInfoCommand ViewpointControl_3DMapCommand;
    private static readonly MapInfoCommand Wireframe_3DMapCommand;
    private static readonly MapInfoCommand Properties_3DMapCommand;
    private static readonly MapInfoCommand AdornmentPropertiesCommand;
    private static readonly MapInfoCommand RemoveAdornmentCommand;

    public static MapInfoCommand ClearCosmetic { get; private set; }

    public static MapInfoCommand SaveCosmetic { get; private set; }

    static MapCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(128, nameof (AddBasemapAerial), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_AddBasemapAerial_Label;
      basicRunMenuCommand1.MenuItemText = Resources.Command_AddBasemapAerial_MenuItemText;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapAerial_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapAerial_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_AddBasemapAerial_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_Addbasemap_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_NeedTileServerFiles;
      basicRunMenuCommand1.Category = Resources.Command_Category_MapCommands;
      MapCommands.AddBasemapAerialCommand = (MapInfoCommand) basicRunMenuCommand1;
      MapCommands.AddBasemapAerialCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(129, nameof (AddBasemapHybrid), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_AddBasemapHybrid_Label;
      basicRunMenuCommand2.MenuItemText = Resources.Command_AddBasemapHybrid_MenuItemText;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapHybrid_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapHybrid_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_AddBasemapHybrid_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_Addbasemap_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_NeedTileServerFiles;
      basicRunMenuCommand2.Category = Resources.Command_Category_MapCommands;
      MapCommands.AddBasemapHybridCommand = (MapInfoCommand) basicRunMenuCommand2;
      MapCommands.AddBasemapHybridCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(130, nameof (AddBasemapRoads), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_AddBasemapRoads_Label;
      basicRunMenuCommand3.MenuItemText = Resources.Command_AddBasemapRoads_MenuItemText;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapRoads_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/basemapRoads_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_AddBasemapRoads_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_Addbasemap_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedValidBingPremiumLicense;
      basicRunMenuCommand3.Category = Resources.Command_Category_MapCommands;
      MapCommands.AddBasemapRoadsCommand = (MapInfoCommand) basicRunMenuCommand3;
      MapCommands.AddBasemapRoadsCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand1 = new SelectiveRequeryRunMenuCommand(814, nameof (ClearCustomLabels), (InputGestureCollection) null);
      requeryRunMenuCommand1.Text = Resources.Command_ClearCustomLabels_Label;
      requeryRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCustomLabels_16x16.png";
      requeryRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCustomLabels_32x32.png";
      requeryRunMenuCommand1.ToolTipDescription = Resources.Command_ClearCustomLabels_ToolTip_Description;
      requeryRunMenuCommand1.ToolTipText = Resources.Command_ClearCustomLabels_ToolTip_Text;
      requeryRunMenuCommand1.ToolTipDisabledText = Resources.Command_ClearCustomLabelDisabledText;
      requeryRunMenuCommand1.EnableCommand = false;
      requeryRunMenuCommand1.Category = Resources.Command_Category_MapCommands;
      MapCommands.ClearCustomLabelsCommand = (MapInfoCommand) requeryRunMenuCommand1;
      MapCommands.ClearCustomLabelsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(810, nameof (ClearCosmetic), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_ClearCosmetic_Label;
      basicRunMenuCommand4.MenuItemText = Resources.Command_ClearCosmetic_MenuItemText;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCosmeticLayer_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCosmeticLayer_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_ClearCosmetic_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_ClearCosmetic_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedCosmeticObject;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_MapCommands;
      MapCommands.ClearCosmetic = (MapInfoCommand) basicRunMenuCommand4;
      MapCommands.ClearCosmetic.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(809, nameof (SaveCosmetic), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_SaveCosmetic_Label;
      basicRunMenuCommand5.MenuItemText = Resources.Command_SaveCosmetic_MenuItemText;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/saveCosmeticLayer_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/saveCosmeticLayer_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_SaveCosmetic_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_SaveCosmetic_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedCosmeticObject;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_MapCommands;
      MapCommands.SaveCosmetic = (MapInfoCommand) basicRunMenuCommand5;
      MapCommands.SaveCosmetic.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(829, nameof (WorkspaceExplorer), MapInfoCommand.GetGesture(Resources.Command_WorkspaceExplorer_KeyGesture));
      basicRunMenuCommand6.Text = Resources.Command_WorkspaceExplorer_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/workspaceExplorerWindow_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/workspaceExplorerWindow_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_WorkspaceExplorer_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_WorkspaceExplorer_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand6.EnableCommand = true;
      basicRunMenuCommand6.Category = Resources.Command_Category_MapCommands;
      MapCommands.WorkspaceExplorerCommand = (MapInfoCommand) basicRunMenuCommand6;
      MapCommands.WorkspaceExplorerCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(807, nameof (ViewEntireLayer), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_ViewEntireLayer_Label;
      basicRunMenuCommand7.MenuItemText = Resources.Command_ViewEntireLayer_MenuItemText;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireLayer_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireLayer_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_ViewEntireLayer_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_ViewEntireLayer_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewEntireLayerCommand = (MapInfoCommand) basicRunMenuCommand7;
      MapCommands.ViewEntireLayerCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(840, nameof (ViewEntireMap), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_ViewEntireMap_Label;
      basicRunMenuCommand8.MenuItemText = Resources.Command_ViewEntireMap_MenuItemText;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireMap_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireMap_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_ViewEntireMap_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_ViewEntireMap_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewEntireMapCommand = (MapInfoCommand) basicRunMenuCommand8;
      MapCommands.ViewEntireMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(828, nameof (ViewNearestTileServerLevel), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_ViewNearestTileServerLevel_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToNearestTileServerLevel_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToNearestTileServerLevel_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_ViewNearestTileServerLevel_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_ViewNearestTileServerLevel_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedBaseMap;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewNearestTileServerLevelCommand = (MapInfoCommand) basicRunMenuCommand9;
      MapCommands.ViewNearestTileServerLevelCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(819, nameof (ViewEntireSelectionLayer), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_ViewEntireSelectionLayer_Label;
      basicRunMenuCommand10.MenuItemText = Resources.Command_ViewEntireSelectionLayer_MenuItemText;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireSelectionLayer_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireSelectionLayer_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_ViewEntireSelectionLayer_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_ViewEntireSelectionLayer_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewEntireSelectionLayerCommand = (MapInfoCommand) basicRunMenuCommand10;
      MapCommands.ViewEntireSelectionLayerCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(841, "ViewSelectedObjects", (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_ViewSelectedObjects_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToExtentsSelectedObject_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToExtentsSelectedObject_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_ViewSelectedObjects_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_ViewSelectedObjects_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewEntireSelectedObjectsCommand = (MapInfoCommand) basicRunMenuCommand11;
      MapCommands.ViewEntireSelectedObjectsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(820, nameof (SelectAllFromSelection), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_SelectAllFromSelection_Label;
      basicRunMenuCommand12.MenuItemText = Resources.Command_SelectAllFromSelection_MenuItemText;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectAllFromSelection_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectAllFromSelection_32x32.png";
      basicRunMenuCommand12.ToolTipText = Resources.Command_SelectAllFromSelection_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_SelectAllFromSelection_ToolTip_Description;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand12.EnableCommand = true;
      basicRunMenuCommand12.Category = Resources.Command_Category_MapCommands;
      MapCommands.SelectAllFromSelectionCommand = (MapInfoCommand) basicRunMenuCommand12;
      MapCommands.SelectAllFromSelectionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(821, nameof (MakeSelectionEditable), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_MakeSelectionEditable_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectionEditable_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectionEditable_32x32.png";
      basicRunMenuCommand13.ToolTipText = Resources.Command_MakeSelectionEditable_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_MakeSelectionEditable_ToolTip_Description;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedEditableLayer;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_MapCommands;
      MapCommands.MakeSelectionEditableCommand = (MapInfoCommand) basicRunMenuCommand13;
      MapCommands.MakeSelectionEditableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(825, nameof (MoveMapTo), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_MoveMapTo_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/moveTo_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/moveTo_32x32.png";
      basicRunMenuCommand14.ToolTipText = Resources.Command_MoveMapTo_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_MoveMapTo_ToolTip_Description;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_MoveMapTo;
      basicRunMenuCommand14.EnableCommand = true;
      basicRunMenuCommand14.Category = Resources.Command_Category_MapCommands;
      MapCommands.MoveMapToCommand = (MapInfoCommand) basicRunMenuCommand14;
      MapCommands.MoveMapToCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand2 = new SelectiveRequeryRunMenuCommand(806, nameof (PreviousView), MapInfoCommand.GetGesture(Resources.Command_PreviousView_KeyGesture));
      requeryRunMenuCommand2.Text = Resources.Command_PreviousView_Label;
      requeryRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/prevView_16x16.png";
      requeryRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/prevView_32x32.png";
      requeryRunMenuCommand2.ToolTipText = Resources.Command_PreviousView_ToolTip_Text;
      requeryRunMenuCommand2.ToolTipDescription = Resources.Command_PreviousView_ToolTip_Description;
      requeryRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedViewChange;
      requeryRunMenuCommand2.EnableCommand = false;
      requeryRunMenuCommand2.Category = Resources.Command_Category_MapCommands;
      MapCommands.PreviousViewCommand = (MapInfoCommand) requeryRunMenuCommand2;
      MapCommands.PreviousViewCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(811, nameof (CloneMapper), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_CloneMapper_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/cloneMap_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/cloneMap_32x32.png";
      basicRunMenuCommand15.ToolTipText = Resources.Command_CloneMapper_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_CloneMapper_ToolTip_Description;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_MapCommands;
      MapCommands.CloneMapperCommand = (MapInfoCommand) basicRunMenuCommand15;
      MapCommands.CloneMapperCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(1734, nameof (DragMap), MapInfoCommand.GetGesture(Resources.Command_DragMap_KeyGesture));
      basicRunMenuCommand16.Text = Resources.Command_DragMap_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/dragMap_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/dragMap_32x32.png";
      basicRunMenuCommand16.ToolTipText = Resources.Command_DragMap_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_DragMap_ToolTip_Description;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.Category = Resources.Command_Category_MapCommands;
      MapCommands.DragMapCommand = (MapInfoCommand) basicRunMenuCommand16;
      MapCommands.DragMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(812, nameof (SetClipRegion), (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_SetClipRegion_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clipRegionSet_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clipRegionSet_32x32.png";
      basicRunMenuCommand17.ToolTipText = Resources.Command_SetClipRegion_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_SetClipRegion_ToolTip_Description;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMapEditableSelection;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_MapCommands;
      MapCommands.SetClipRegionCommand = (MapInfoCommand) basicRunMenuCommand17;
      MapCommands.SetClipRegionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(813, "ClipRegionToggle", (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_ClipRegionToggle_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clipRegionToggle_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/clipRegionToggle_32x32.png";
      basicRunMenuCommand18.ToolTipText = Resources.Command_ClipRegionToggle_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_ClipRegionToggle_ToolTip_Description;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_Disabled_NeedClipRegion;
      basicRunMenuCommand18.EnableCommand = false;
      basicRunMenuCommand18.Category = Resources.Command_Category_MapCommands;
      MapCommands.ClipRegionOnOffCommand = (MapInfoCommand) basicRunMenuCommand18;
      MapCommands.ClipRegionOnOffCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand3 = new SelectiveRequeryRunMenuCommand(805, nameof (ChangeView), MapInfoCommand.GetGesture(Resources.Command_ChangeView_KeyGesture));
      requeryRunMenuCommand3.Text = Resources.Command_ChangeView_Label;
      requeryRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/changeView_16x16.png";
      requeryRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/changeView_32x32.png";
      requeryRunMenuCommand3.ToolTipText = Resources.Command_ChangeView_ToolTip_Text;
      requeryRunMenuCommand3.ToolTipDescription = Resources.Command_ChangeView_ToolTip_Description;
      requeryRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      requeryRunMenuCommand3.EnableCommand = false;
      requeryRunMenuCommand3.Category = Resources.Command_Category_MapCommands;
      MapCommands.ChangeViewCommand = (MapInfoCommand) requeryRunMenuCommand3;
      MapCommands.ChangeViewCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(802, nameof (MapOptions), MapInfoCommand.GetGesture(Resources.Command_MapOptions_KeyGesture));
      basicRunMenuCommand19.Text = Resources.Command_MapOptions_Label;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/MapOptions_16x16.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/MapOptions_32x32.png";
      basicRunMenuCommand19.ToolTipText = Resources.Command_MapOptions_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_MapOptions_ToolTip_Description;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand19.EnableCommand = false;
      basicRunMenuCommand19.Category = Resources.Command_Category_MapCommands;
      MapCommands.MapOptionsCommand = (MapInfoCommand) basicRunMenuCommand19;
      MapCommands.MapOptionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand20 = new MapBasicRunMenuCommand(824, nameof (CreateScalebar), MapInfoCommand.GetGesture(Resources.Command_CreateScalebar_KeyGesture));
      basicRunMenuCommand20.Text = Resources.Command_CreateScalebar_Label;
      basicRunMenuCommand20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/Scalebar_16x16.png";
      basicRunMenuCommand20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/Scalebar_32x32.png";
      basicRunMenuCommand20.ToolTipText = Resources.Command_CreateScalebar_ToolTip_Text;
      basicRunMenuCommand20.ToolTipDescription = Resources.Command_CreateScalebar_ToolTip_Description;
      basicRunMenuCommand20.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand20.EnableCommand = false;
      basicRunMenuCommand20.Category = Resources.Command_Category_MapCommands;
      MapCommands.CreateScalebarCommand = (MapInfoCommand) basicRunMenuCommand20;
      MapCommands.CreateScalebarCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand21 = new MapBasicRunMenuCommand(838, nameof (LockScale), MapInfoCommand.GetGesture(Resources.Command_CreateScalebar_KeyGesture));
      basicRunMenuCommand21.Text = Resources.Command_LockScale_Label;
      basicRunMenuCommand21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/lockscale_16x16.png";
      basicRunMenuCommand21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/lockscale_32x32.png";
      basicRunMenuCommand21.ToolTipText = Resources.Command_LockScale_ToolTip_Text;
      basicRunMenuCommand21.ToolTipDescription = Resources.Command_LockScale_ToolTip_Description;
      basicRunMenuCommand21.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand21.EnableCommand = false;
      basicRunMenuCommand21.Category = Resources.Command_Category_MapCommands;
      MapCommands.LockScaleCommand = (MapInfoCommand) basicRunMenuCommand21;
      MapCommands.LockScaleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand22 = new MapBasicRunMenuCommand(307, nameof (AddThematic), MapInfoCommand.GetGesture(Resources.Command_AddThematic_KeyGesture));
      basicRunMenuCommand22.Text = Resources.Command_AddThematic_Label;
      basicRunMenuCommand22.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/addTheme_16x16.png";
      basicRunMenuCommand22.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/addTheme_32x32.png";
      basicRunMenuCommand22.ToolTipText = Resources.Command_AddThematic_ToolTip_Text;
      basicRunMenuCommand22.ToolTipDescription = Resources.Command_AddThematic_ToolTip_Description;
      basicRunMenuCommand22.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand22.EnableCommand = false;
      basicRunMenuCommand22.Category = Resources.Command_Category_MapCommands;
      MapCommands.AddThematicCommand = (MapInfoCommand) basicRunMenuCommand22;
      MapCommands.AddThematicCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand23 = new MapBasicRunMenuCommand(827, nameof (CreateLegendDesigner), MapInfoCommand.GetGesture(Resources.Command_CreateLegendDesigner_KeyGesture));
      basicRunMenuCommand23.Text = Resources.Command_CreateLegendDesigner_Label;
      basicRunMenuCommand23.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/insertLegend_16x16.png";
      basicRunMenuCommand23.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/insertLegend_32x32.png";
      basicRunMenuCommand23.ToolTipText = Resources.Command_CreateLegendDesigner_ToolTip_Text;
      basicRunMenuCommand23.ToolTipDescription = Resources.Command_CreateLegendDesigner_ToolTip_Description;
      basicRunMenuCommand23.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand23.EnableCommand = false;
      basicRunMenuCommand23.Category = Resources.Command_Category_MapCommands;
      MapCommands.CreateLegendDesignerCommand = (MapInfoCommand) basicRunMenuCommand23;
      MapCommands.CreateLegendDesignerCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand24 = new MapBasicRunMenuCommand(839, nameof (SelectableLabels), (InputGestureCollection) null);
      basicRunMenuCommand24.Text = Resources.Command_SelectableLabels_Label;
      basicRunMenuCommand24.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectableLabels_16x16.png";
      basicRunMenuCommand24.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/selectableLabels_32x32.png";
      basicRunMenuCommand24.ToolTipText = Resources.Command_SelectableLabels_ToolTip_Text;
      basicRunMenuCommand24.ToolTipDescription = Resources.Command_SelectableLabels_ToolTip_Description;
      basicRunMenuCommand24.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand24.Category = Resources.Command_Category_MapCommands;
      basicRunMenuCommand24.CustomHelpId = new int?(MapInfoConstants.SelectTableLabelsHelpId);
      basicRunMenuCommand24.EnableCommand = true;
      MapCommands.SelectableLabelsCommand = (MapInfoCommand) basicRunMenuCommand24;
      MapCommands.SelectableLabelsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand25 = new MapBasicRunMenuCommand(842, nameof (SnapToNode), (InputGestureCollection) null);
      basicRunMenuCommand25.Text = Resources.Command_SnapToNode_Label;
      basicRunMenuCommand25.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/snapToNodes_16x16.png";
      basicRunMenuCommand25.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/snapToNodes_32x32.png";
      basicRunMenuCommand25.ToolTipDescription = Resources.Command_SnapToNode_ToolTip_Description;
      basicRunMenuCommand25.ToolTipText = Resources.Command_SnapToNode_ToolTip_Text;
      basicRunMenuCommand25.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenMappable_Table;
      basicRunMenuCommand25.EnableCommand = false;
      basicRunMenuCommand25.Category = Resources.Command_Category_MapCommands;
      MapCommands.SnapToNodeCommand = (MapInfoCommand) basicRunMenuCommand25;
      MapCommands.SnapToNodeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand26 = new MapBasicRunMenuCommand(843, "MapRedrawOnOff", MapInfoCommand.GetGesture(Resources.Command_RedrawOnOff_KeyGesture));
      basicRunMenuCommand26.Text = Resources.Command_MapRedrawOnOff_Label;
      basicRunMenuCommand26.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/suspendRedraw_16x16.png";
      basicRunMenuCommand26.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/suspendRedraw_32x32.png";
      basicRunMenuCommand26.ToolTipText = Resources.Command_MapRedrawOnOff_ToolTip_Text;
      basicRunMenuCommand26.ToolTipDescription = Resources.Command_MapRedrawOnOff_ToolTip_Description;
      basicRunMenuCommand26.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand26.EnableCommand = false;
      basicRunMenuCommand26.Category = Resources.Command_Category_MapCommands;
      MapCommands.RedrawOnOffCommand = (MapInfoCommand) basicRunMenuCommand26;
      MapCommands.RedrawOnOffCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand27 = new MapBasicRunMenuCommand(2525, nameof (HotlinkOptions), (InputGestureCollection) null);
      basicRunMenuCommand27.Text = Resources.Command_HotlinkOptions_Label;
      basicRunMenuCommand27.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/hotLinkOptions_16x16.png";
      basicRunMenuCommand27.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/hotLinkOptions_32x32.png";
      basicRunMenuCommand27.ToolTipDescription = Resources.Command_HotLinkOptions_ToolTip_Description;
      basicRunMenuCommand27.ToolTipText = Resources.Command_HotLinkOptions_ToolTip_Text;
      basicRunMenuCommand27.ToolTipDisabledText = Resources.Command_Disabled_NeedOneSelectedLayer;
      basicRunMenuCommand27.EnableCommand = false;
      basicRunMenuCommand27.Category = Resources.Command_Category_MapCommands;
      basicRunMenuCommand27.CustomHelpId = new int?(MapInfoConstants.HotlinkOptionsHelpId);
      MapCommands.HotlinkOptionsCommand = (MapInfoCommand) basicRunMenuCommand27;
      MapCommands.HotlinkOptionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand28 = new MapBasicRunMenuCommand(2103, nameof (RefreshGridTexture_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand28.Text = Resources.Command_RefreshGridTexture_3DMap_Label;
      basicRunMenuCommand28.MenuItemText = Resources.Command_RefreshGridTexture_3DMap_MenuText;
      basicRunMenuCommand28.ToolTipDescription = Resources.Command_RefreshGridTexture_3DMap_ToolTip_Description;
      basicRunMenuCommand28.ToolTipText = Resources.Command_RefreshGridTexture_3DMap_ToolTip_Text;
      basicRunMenuCommand28.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand28.EnableCommand = false;
      basicRunMenuCommand28.Category = Resources.Command_Category_MapCommands;
      MapCommands.RefreshGridTexture_3DMapCommand = (MapInfoCommand) basicRunMenuCommand28;
      MapCommands.RefreshGridTexture_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand29 = new MapBasicRunMenuCommand(2105, nameof (CloneView_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand29.Text = Resources.Command_CloneView_3DMap_Label;
      basicRunMenuCommand29.MenuItemText = Resources.Command_CloneView_3DMap_MenuText;
      basicRunMenuCommand29.ToolTipDescription = Resources.Command_CloneView_3DMap_ToolTip_Description;
      basicRunMenuCommand29.ToolTipText = Resources.Command_CloneView_3DMap_ToolTip_Text;
      basicRunMenuCommand29.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand29.EnableCommand = false;
      basicRunMenuCommand29.Category = Resources.Command_Category_MapCommands;
      MapCommands.CloneView_3DMapCommand = (MapInfoCommand) basicRunMenuCommand29;
      MapCommands.CloneView_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand30 = new MapBasicRunMenuCommand(2106, nameof (PreviousView_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand30.Text = Resources.Command_PreviousView_3DMap_Label;
      basicRunMenuCommand30.MenuItemText = Resources.Command_PreviousView_3DMap_MenuText;
      basicRunMenuCommand30.ToolTipDescription = Resources.Command_PreviousView_3DMap_ToolTip_Description;
      basicRunMenuCommand30.ToolTipText = Resources.Command_PreviousView_3DMap_ToolTip_Text;
      basicRunMenuCommand30.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand30.EnableCommand = false;
      basicRunMenuCommand30.Category = Resources.Command_Category_MapCommands;
      MapCommands.PreviousView_3DMapCommand = (MapInfoCommand) basicRunMenuCommand30;
      MapCommands.PreviousView_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand31 = new MapBasicRunMenuCommand(2101, nameof (ViewEntireGrid_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand31.Text = Resources.Command_ViewEntireGrid_3DMap_Label;
      basicRunMenuCommand31.MenuItemText = Resources.Command_ViewEntireGrid_3DMap_MenuText;
      basicRunMenuCommand31.ToolTipDescription = Resources.Command_ViewEntireGrid_3DMap_ToolTip_Description;
      basicRunMenuCommand31.ToolTipText = Resources.Command_ViewEntireGrid_3DMap_ToolTip_Text;
      basicRunMenuCommand31.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand31.EnableCommand = false;
      basicRunMenuCommand31.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewEntireGrid_3DMapCommand = (MapInfoCommand) basicRunMenuCommand31;
      MapCommands.ViewEntireGrid_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand32 = new MapBasicRunMenuCommand(2107, nameof (ViewpointControl_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand32.Text = Resources.Command_ViewpointControl_3DMap_Label;
      basicRunMenuCommand32.MenuItemText = Resources.Command_ViewpointControl_3DMap_MenuText;
      basicRunMenuCommand32.ToolTipDescription = Resources.Command_ViewpointControl_3DMap_ToolTip_Description;
      basicRunMenuCommand32.ToolTipText = Resources.Command_ViewpointControl_3DMap_ToolTip_Text;
      basicRunMenuCommand32.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand32.EnableCommand = false;
      basicRunMenuCommand32.Category = Resources.Command_Category_MapCommands;
      MapCommands.ViewpointControl_3DMapCommand = (MapInfoCommand) basicRunMenuCommand32;
      MapCommands.ViewpointControl_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand33 = new MapBasicRunMenuCommand(2104, nameof (Wireframe_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand33.Text = Resources.Command_Wireframe_3DMap_Label;
      basicRunMenuCommand33.MenuItemText = Resources.Command_Wireframe_3DMap_MenuText;
      basicRunMenuCommand33.ToolTipDescription = Resources.Command_Wireframe_3DMap_ToolTip_Description;
      basicRunMenuCommand33.ToolTipText = Resources.Command_Wireframe_3DMap_ToolTip_Text;
      basicRunMenuCommand33.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand33.EnableCommand = false;
      basicRunMenuCommand33.Category = Resources.Command_Category_MapCommands;
      MapCommands.Wireframe_3DMapCommand = (MapInfoCommand) basicRunMenuCommand33;
      MapCommands.Wireframe_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand34 = new MapBasicRunMenuCommand(2102, nameof (Properties_3DMap), (InputGestureCollection) null);
      basicRunMenuCommand34.Text = Resources.Command_Properties_3DMap_Label;
      basicRunMenuCommand34.MenuItemText = Resources.Command_Properties_3DMap_MenuText;
      basicRunMenuCommand34.ToolTipDescription = Resources.Command_Properties_3DMap_ToolTip_Description;
      basicRunMenuCommand34.ToolTipText = Resources.Command_Properties_3DMap_ToolTip_Text;
      basicRunMenuCommand34.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand34.EnableCommand = false;
      basicRunMenuCommand34.Category = Resources.Command_Category_MapCommands;
      MapCommands.Properties_3DMapCommand = (MapInfoCommand) basicRunMenuCommand34;
      MapCommands.Properties_3DMapCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand35 = new MapBasicRunMenuCommand(2401, nameof (AdornmentProperties), (InputGestureCollection) null);
      basicRunMenuCommand35.Text = Resources.Command_AdornmentProperties_Label;
      basicRunMenuCommand35.MenuItemText = Resources.Command_AdornmentProperties_MenuText;
      basicRunMenuCommand35.ToolTipDescription = Resources.Command_AdornmentProperties_ToolTip_Description;
      basicRunMenuCommand35.ToolTipText = Resources.Command_AdornmentProperties_ToolTip_Text;
      basicRunMenuCommand35.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand35.EnableCommand = false;
      basicRunMenuCommand35.Category = Resources.Command_Category_MapCommands;
      MapCommands.AdornmentPropertiesCommand = (MapInfoCommand) basicRunMenuCommand35;
      MapCommands.AdornmentPropertiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand36 = new MapBasicRunMenuCommand(2402, nameof (RemoveAdornment), (InputGestureCollection) null);
      basicRunMenuCommand36.Text = Resources.Command_RemoveAdornment_Label;
      basicRunMenuCommand36.MenuItemText = Resources.Command_RemoveAdornment_MenuText;
      basicRunMenuCommand36.ToolTipDescription = Resources.Command_RemoveAdornment_ToolTip_Description;
      basicRunMenuCommand36.ToolTipText = Resources.Command_RemoveAdornment_ToolTip_Text;
      basicRunMenuCommand36.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand36.EnableCommand = false;
      basicRunMenuCommand36.Category = Resources.Command_Category_MapCommands;
      MapCommands.RemoveAdornmentCommand = (MapInfoCommand) basicRunMenuCommand36;
      MapCommands.RemoveAdornmentCommand.CreateScreenTip();
    }

    public static MapInfoCommand SnapToNode
    {
      get
      {
        return MapCommands.SnapToNodeCommand;
      }
    }

    public static MapInfoCommand AddBasemapAerial
    {
      get
      {
        return MapCommands.AddBasemapAerialCommand;
      }
    }

    public static MapInfoCommand AddBasemapHybrid
    {
      get
      {
        return MapCommands.AddBasemapHybridCommand;
      }
    }

    public static MapInfoCommand AddBasemapRoads
    {
      get
      {
        return MapCommands.AddBasemapRoadsCommand;
      }
    }

    public static MapInfoCommand ClearCustomLabels
    {
      get
      {
        return MapCommands.ClearCustomLabelsCommand;
      }
    }

    public static MapInfoCommand WorkspaceExplorer
    {
      get
      {
        return MapCommands.WorkspaceExplorerCommand;
      }
    }

    public static MapInfoCommand ViewEntireLayer
    {
      get
      {
        return MapCommands.ViewEntireLayerCommand;
      }
    }

    public static MapInfoCommand ViewEntireMap
    {
      get
      {
        return MapCommands.ViewEntireMapCommand;
      }
    }

    public static MapInfoCommand ViewEntireSelectionLayer
    {
      get
      {
        return MapCommands.ViewEntireSelectionLayerCommand;
      }
    }

    public static MapInfoCommand ViewEntireSelectedObjects
    {
      get
      {
        return MapCommands.ViewEntireSelectedObjectsCommand;
      }
    }

    public static MapInfoCommand ViewNearestTileServerLevel
    {
      get
      {
        return MapCommands.ViewNearestTileServerLevelCommand;
      }
    }

    public static MapInfoCommand SelectAllFromSelection
    {
      get
      {
        return MapCommands.SelectAllFromSelectionCommand;
      }
    }

    public static MapInfoCommand MakeSelectionEditable
    {
      get
      {
        return MapCommands.MakeSelectionEditableCommand;
      }
    }

    public static MapInfoCommand MoveMapTo
    {
      get
      {
        return MapCommands.MoveMapToCommand;
      }
    }

    public static MapInfoCommand PreviousView
    {
      get
      {
        return MapCommands.PreviousViewCommand;
      }
    }

    public static MapInfoCommand CloneMapper
    {
      get
      {
        return MapCommands.CloneMapperCommand;
      }
    }

    public static MapInfoCommand DragMap
    {
      get
      {
        return MapCommands.DragMapCommand;
      }
    }

    public static MapInfoCommand ClipRegionOnOff
    {
      get
      {
        return MapCommands.ClipRegionOnOffCommand;
      }
    }

    public static MapInfoCommand SetClipRegion
    {
      get
      {
        return MapCommands.SetClipRegionCommand;
      }
    }

    public static MapInfoCommand ChangeView
    {
      get
      {
        return MapCommands.ChangeViewCommand;
      }
    }

    public static MapInfoCommand MapOptions
    {
      get
      {
        return MapCommands.MapOptionsCommand;
      }
    }

    public static MapInfoCommand CreateScalebar
    {
      get
      {
        return MapCommands.CreateScalebarCommand;
      }
    }

    public static MapInfoCommand LockScale
    {
      get
      {
        return MapCommands.LockScaleCommand;
      }
    }

    public static MapInfoCommand AddThematic
    {
      get
      {
        return MapCommands.AddThematicCommand;
      }
    }

    public static MapInfoCommand CreateLegendDesigner
    {
      get
      {
        return MapCommands.CreateLegendDesignerCommand;
      }
    }

    public static MapInfoCommand SelectableLabels
    {
      get
      {
        return MapCommands.SelectableLabelsCommand;
      }
    }

    public static MapInfoCommand RedrawOnOff
    {
      get
      {
        return MapCommands.RedrawOnOffCommand;
      }
    }

    public static MapInfoCommand HotlinkOptions
    {
      get
      {
        return MapCommands.HotlinkOptionsCommand;
      }
    }

    public static MapInfoCommand RefreshGridTexture_3DMap
    {
      get
      {
        return MapCommands.RefreshGridTexture_3DMapCommand;
      }
    }

    public static MapInfoCommand CloneView_3DMap
    {
      get
      {
        return MapCommands.CloneView_3DMapCommand;
      }
    }

    public static MapInfoCommand PreviousView_3DMap
    {
      get
      {
        return MapCommands.PreviousView_3DMapCommand;
      }
    }

    public static MapInfoCommand ViewEntireGrid_3DMap
    {
      get
      {
        return MapCommands.ViewEntireGrid_3DMapCommand;
      }
    }

    public static MapInfoCommand ViewpointControl_3DMap
    {
      get
      {
        return MapCommands.ViewpointControl_3DMapCommand;
      }
    }

    public static MapInfoCommand Wireframe_3DMap
    {
      get
      {
        return MapCommands.Wireframe_3DMapCommand;
      }
    }

    public static MapInfoCommand Properties_3DMap
    {
      get
      {
        return MapCommands.Properties_3DMapCommand;
      }
    }

    public static MapInfoCommand AdornmentProperties
    {
      get
      {
        return MapCommands.AdornmentPropertiesCommand;
      }
    }

    public static MapInfoCommand RemoveAdornment
    {
      get
      {
        return MapCommands.RemoveAdornmentCommand;
      }
    }
  }
}
