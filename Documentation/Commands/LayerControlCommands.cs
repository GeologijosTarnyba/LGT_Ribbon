// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LayerControlCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class LayerControlCommands
  {
    private static readonly MapInfoCommand AddLayersCommand;
    private static readonly MapInfoCommand LabelPrioritiesCommand;
    private static readonly MapInfoCommand LayerControlOptionsCommand;
    private static readonly MapInfoCommand RegionStyleCommand;
    private static readonly MapInfoCommand RegionStyleStackedCommand;
    private static readonly MapInfoCommand LineStyleCommand;
    private static readonly MapInfoCommand LineStyleStackedCommand;
    private static readonly MapInfoCommand SymbolStyleCommand;
    private static readonly MapInfoCommand TextStyleCommand;
    private static readonly MapInfoCommand SymbolStyleStackedCommand;
    private static readonly MapInfoCommand ShowNodesCommand;
    private static readonly MapInfoCommand ShowCentroidsCommand;
    private static readonly MapInfoCommand ShowLineDirectionCommand;
    private static readonly MapInfoCommand ToggleStyleOverrideCommand;
    private static readonly MapInfoCommand ToggleStackedStyleCommand;
    private static readonly MapInfoCommand ToggleImageGrayScaleCommand;
    private static readonly MapInfoCommand LabelDisplayPropsCommand;
    private static readonly MapInfoCommand LabelRulesPropsCommand;
    private static readonly MapInfoCommand LabelLineStyleCommand;
    public static MapInfoCommand LcDisplayOverridePropertiesCommand;
    public static MapInfoCommand LcLabelOverridePropertiesCommand;
    public static MapInfoCommand LcSplitOverrideCommand;
    public static MapInfoCommand LcRemoveOverrideCommand;

    public static MapInfoCommand LcViewEntireLayer { get; private set; }

    public static MapInfoCommand LcLayerProperties { get; private set; }

    public static MapInfoCommand LcLabelFont { get; private set; }

    public static MapInfoCommand LcOtherNoSelect { get; private set; }

    public static MapInfoCommand LcRenameMap { get; private set; }

    public static MapInfoCommand LcMapOptions { get; private set; }

    public static MapInfoCommand LcAddGroup { get; private set; }

    public static MapInfoCommand LcRenameGroup { get; private set; }

    public static MapInfoCommand LcUnGroup { get; private set; }

    public static MapInfoCommand LcAddDisplayOverride { get; private set; }

    public static MapInfoCommand LcAddLabelOverride { get; private set; }

    public static MapInfoCommand LcBrowseTable { get; private set; }

    public static MapInfoCommand LcZoomToTileServer { get; private set; }

    public static MapInfoCommand LcClearCustomLabels { get; private set; }

    public static MapInfoCommand LcSelectAll { get; private set; }

    public static MapInfoCommand LcRenameToFriendlyName { get; private set; }

    static LayerControlCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(2510, nameof (AddLayers), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_AddLayers_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/addLayer_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/addLayer_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_AddLayers_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_AddLayers_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.AddLayersCommand = (MapInfoCommand) basicRunMenuCommand1;
      LayerControlCommands.AddLayersCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(2511, nameof (LcAddDisplayOverride), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_LcAddDisplayOverride_Label;
      basicRunMenuCommand2.MenuItemText = Resources.Command_LcAddDisplayOverride_MenuItemText;
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_LcAddDisplayOverride_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_LcAddDisplayOverride_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand2.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcAddDisplayOverride = (MapInfoCommand) basicRunMenuCommand2;
      LayerControlCommands.LcAddDisplayOverride.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(2512, nameof (LcAddLabelOverride), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_LcAddLabelOverride_Label;
      basicRunMenuCommand3.MenuItemText = Resources.Command_LcAddLabelOverride_MenuItemText;
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_LcAddLabelOverride_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_LcAddLabelOverride_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand3.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcAddLabelOverride = (MapInfoCommand) basicRunMenuCommand3;
      LayerControlCommands.LcAddLabelOverride.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(2513, nameof (LcDisplayOverrideProperties), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_LcDisplayOverrideProperties_Label;
      basicRunMenuCommand4.MenuItemText = Resources.Command_LcDisplayOverrideProperties_MenuText;
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_LcDisplayOverrideProperties_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_LcDisplayOverrideProperties_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand4.EnableCommand = true;
      basicRunMenuCommand4.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcDisplayOverridePropertiesCommand = (MapInfoCommand) basicRunMenuCommand4;
      LayerControlCommands.LcDisplayOverridePropertiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(2514, nameof (LcLabelOverrideProperties), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_LcLabelOverrideProperties_Label;
      basicRunMenuCommand5.MenuItemText = Resources.Command_LcLabelOverrideProperties_MenuText;
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_LcLabelOverrideProperties_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_LcLabelOverrideProperties_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand5.EnableCommand = true;
      basicRunMenuCommand5.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcLabelOverridePropertiesCommand = (MapInfoCommand) basicRunMenuCommand5;
      LayerControlCommands.LcLabelOverridePropertiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(2515, nameof (LcSplitOverride), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_LcSplitOverride_Label;
      basicRunMenuCommand6.MenuItemText = Resources.Command_LcSplitOverride_MenuText;
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_LcSplitOverride_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_LcSplitOverride_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand6.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcSplitOverrideCommand = (MapInfoCommand) basicRunMenuCommand6;
      LayerControlCommands.LcSplitOverrideCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(2516, nameof (LcRemoveOverride), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_LcRemoveOverride_Label;
      basicRunMenuCommand7.MenuItemText = Resources.Command_LcRemoveOverride_MenuText;
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_LcRemoveOverride_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_LcRemoveOverride_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand7.EnableCommand = true;
      basicRunMenuCommand7.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcRemoveOverrideCommand = (MapInfoCommand) basicRunMenuCommand7;
      LayerControlCommands.LcRemoveOverrideCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(2522, nameof (LabelPriority), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_LabelPriority_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/labelPriority_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/labelPriority_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_LabelPriority_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_LabelPriority_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedTwoOrMoreLabellableLayers;
      basicRunMenuCommand8.EnableCommand = true;
      basicRunMenuCommand8.CustomHelpId = MapInfoConstants.LabelPriorityHelpId;
      basicRunMenuCommand8.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LabelPrioritiesCommand = (MapInfoCommand) basicRunMenuCommand8;
      LayerControlCommands.LabelPrioritiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(2524, nameof (LayerControlOptions), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_LayerControlOptions_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/layerControlOptions_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/layerControlOptions_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_LayerControlOptions_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_LayerControlOptions_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand9.EnableCommand = true;
      basicRunMenuCommand9.CustomHelpId = new int?(MapInfoConstants.LayerControlHelpId);
      basicRunMenuCommand9.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LayerControlOptionsCommand = (MapInfoCommand) basicRunMenuCommand9;
      LayerControlCommands.LayerControlOptionsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(2526, "LayerRegionStyle", (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_LayerRegionStyle_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/regionStyle_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_LayerRegionStyle_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_LayerRegionStyle_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand10.EnableCommand = true;
      basicRunMenuCommand10.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.RegionStyleCommand = (MapInfoCommand) basicRunMenuCommand10;
      LayerControlCommands.RegionStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(2527, "StackedRegionStyle", (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_StackedRegionStyle_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesRegions_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesRegions_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_StackedRegionStyle_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_StackedRegionStyle_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand11.EnableCommand = true;
      basicRunMenuCommand11.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.RegionStyleStackedCommand = (MapInfoCommand) basicRunMenuCommand11;
      LayerControlCommands.RegionStyleStackedCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(2529, "LayerLineStyle", (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_LayerLineStyle_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_LayerLineStyle_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_LayerLineStyle_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand12.EnableCommand = true;
      basicRunMenuCommand12.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LineStyleCommand = (MapInfoCommand) basicRunMenuCommand12;
      LayerControlCommands.LineStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(2531, "LayerLineStyleStacked", (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_LayerLineStyleStacked_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesLines_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesLines_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_LayerLineStyleStacked_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_LayerLineStyleStacked_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand13.EnableCommand = true;
      basicRunMenuCommand13.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LineStyleStackedCommand = (MapInfoCommand) basicRunMenuCommand13;
      LayerControlCommands.LineStyleStackedCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(2530, "LayerSymbolStyle", (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_LayerSymbolStyle_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyle_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_LayerSymbolStyle_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_LayerSymbolStyle_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand14.EnableCommand = true;
      basicRunMenuCommand14.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.SymbolStyleCommand = (MapInfoCommand) basicRunMenuCommand14;
      LayerControlCommands.SymbolStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(2532, "LayerSymbolStyleStacked", (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_LayerSymbolStyleStacked_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyleStacked_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/symbolStyleStacked_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_LayerSymbolStyleStacked_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_LayerSymbolStyleStacked_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand15.EnableCommand = true;
      basicRunMenuCommand15.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.SymbolStyleStackedCommand = (MapInfoCommand) basicRunMenuCommand15;
      LayerControlCommands.SymbolStyleStackedCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(2536, "LayerTextStyle", (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_LayerTextStyle_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/textStyle_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_LayerTextStyle_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_LayerTextStyle_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand16.EnableCommand = true;
      basicRunMenuCommand16.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.TextStyleCommand = (MapInfoCommand) basicRunMenuCommand16;
      LayerControlCommands.TextStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(2533, "LayerShowNodes", (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_LayerShowNodes_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showNodes_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showNodes_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_LayerShowNodes_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_LayerShowNodes_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedStyleOverride;
      basicRunMenuCommand17.EnableCommand = true;
      basicRunMenuCommand17.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ShowNodesCommand = (MapInfoCommand) basicRunMenuCommand17;
      LayerControlCommands.ShowNodesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(2534, "LayerShowCentroids", (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_LayerShowCentroids_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showCentroids_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showCentroids_32x32.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_LayerShowCentroids_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_LayerShowCentroids_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand18.EnableCommand = true;
      basicRunMenuCommand18.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ShowCentroidsCommand = (MapInfoCommand) basicRunMenuCommand18;
      LayerControlCommands.ShowCentroidsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(2535, "LayerShowLineDirection", (InputGestureCollection) null);
      basicRunMenuCommand19.Text = Resources.Command_LayerShowLineDirection_Label;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showLineDirection_16x16.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/showLineDirection_32x32.png";
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_LayerShowLineDirection_ToolTip_Description;
      basicRunMenuCommand19.ToolTipText = Resources.Command_LayerShowLineDirection_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand19.EnableCommand = true;
      basicRunMenuCommand19.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ShowLineDirectionCommand = (MapInfoCommand) basicRunMenuCommand19;
      LayerControlCommands.ShowLineDirectionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand20 = new MapBasicRunMenuCommand(2528, nameof (ToggleStyleOverride), (InputGestureCollection) null);
      basicRunMenuCommand20.Text = Resources.Command_ToggleStyleOverride_Label;
      basicRunMenuCommand20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/applyStyles_16x16.png";
      basicRunMenuCommand20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/applyStyles_32x32.png";
      basicRunMenuCommand20.ToolTipDescription = Resources.Command_ToggleStyleOverride_ToolTip_Description;
      basicRunMenuCommand20.ToolTipText = Resources.Command_ToggleStyleOverride_ToolTip_Text;
      basicRunMenuCommand20.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand20.EnableCommand = true;
      basicRunMenuCommand20.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ToggleStyleOverrideCommand = (MapInfoCommand) basicRunMenuCommand20;
      LayerControlCommands.ToggleStyleOverrideCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand21 = new MapBasicRunMenuCommand(2537, nameof (ToggleStackedStyle), (InputGestureCollection) null);
      basicRunMenuCommand21.Text = Resources.Command_ToggleStackedStyle_Label;
      basicRunMenuCommand21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesRegions_16x16.png";
      basicRunMenuCommand21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Labelling/stackedStylesRegions_32x32.png";
      basicRunMenuCommand21.ToolTipDescription = Resources.Command_ToggleStackedStyle_ToolTip_Description;
      basicRunMenuCommand21.ToolTipText = Resources.Command_ToggleStackedStyle_ToolTip_Text;
      basicRunMenuCommand21.ToolTipDisabledText = Resources.Command_Disabled_StackedStyles;
      basicRunMenuCommand21.EnableCommand = true;
      basicRunMenuCommand21.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ToggleStackedStyleCommand = (MapInfoCommand) basicRunMenuCommand21;
      LayerControlCommands.ToggleStackedStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand22 = new MapBasicRunMenuCommand(2538, "ToggleGrayScale", (InputGestureCollection) null);
      basicRunMenuCommand22.Text = Resources.Command_ToggleGrayScale_Label;
      basicRunMenuCommand22.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/toggleGrayScale_16x16.png";
      basicRunMenuCommand22.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/toggleGrayScale_32x32.png";
      basicRunMenuCommand22.ToolTipDescription = Resources.Command_ToggleGrayScale_ToolTip_Description;
      basicRunMenuCommand22.ToolTipText = Resources.Command_ToggleGrayScale_ToolTip_Text;
      basicRunMenuCommand22.ToolTipDisabledText = Resources.Command_Disabled_StackedStyles;
      basicRunMenuCommand22.EnableCommand = true;
      basicRunMenuCommand22.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.ToggleImageGrayScaleCommand = (MapInfoCommand) basicRunMenuCommand22;
      LayerControlCommands.ToggleImageGrayScaleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand23 = new MapBasicRunMenuCommand(2539, nameof (LabelDisplayProps), (InputGestureCollection) null);
      basicRunMenuCommand23.Text = Resources.Command_LabelDisplayProps_Label;
      basicRunMenuCommand23.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelDisplayDialog_16x16.png";
      basicRunMenuCommand23.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelDisplayDialog_32x32.png";
      basicRunMenuCommand23.ToolTipDescription = Resources.Command_LabelDisplayProps_ToolTip_Description;
      basicRunMenuCommand23.ToolTipText = Resources.Command_LabelDisplayProps_ToolTip_Text;
      basicRunMenuCommand23.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand23.EnableCommand = true;
      basicRunMenuCommand23.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LabelDisplayPropsCommand = (MapInfoCommand) basicRunMenuCommand23;
      LayerControlCommands.LabelDisplayPropsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand24 = new MapBasicRunMenuCommand(2540, nameof (LabelRulesProps), (InputGestureCollection) null);
      basicRunMenuCommand24.Text = Resources.Command_LabelRulesProps_Label;
      basicRunMenuCommand24.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelRulesDialog_16x16.png";
      basicRunMenuCommand24.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/labelRulesDialog_32x32.png";
      basicRunMenuCommand24.ToolTipDescription = Resources.Command_LabelRulesProps_ToolTip_Decription;
      basicRunMenuCommand24.ToolTipText = Resources.Command_LabelRulesProps_ToolTip_Text;
      basicRunMenuCommand24.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand24.EnableCommand = true;
      basicRunMenuCommand24.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LabelRulesPropsCommand = (MapInfoCommand) basicRunMenuCommand24;
      LayerControlCommands.LabelRulesPropsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand25 = new MapBasicRunMenuCommand(2541, nameof (LabelLineStyle), (InputGestureCollection) null);
      basicRunMenuCommand25.Text = Resources.Command_LabelLineStyle_Label;
      basicRunMenuCommand25.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_16x16.png";
      basicRunMenuCommand25.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/lineStyle_32x32.png";
      basicRunMenuCommand25.ToolTipDescription = Resources.Command_LabelLineStyle_ToolTip_Decription;
      basicRunMenuCommand25.ToolTipText = Resources.Command_LabelLineStyle_ToolTip_Text;
      basicRunMenuCommand25.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedLayer;
      basicRunMenuCommand25.EnableCommand = true;
      basicRunMenuCommand25.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LabelLineStyleCommand = (MapInfoCommand) basicRunMenuCommand25;
      LayerControlCommands.LabelLineStyleCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand26 = new MapBasicRunMenuCommand(2501, nameof (LcViewEntireLayer), (InputGestureCollection) null);
      basicRunMenuCommand26.Text = Resources.Command_LcViewEntireLayer_Label;
      basicRunMenuCommand26.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireLayer_16x16.png";
      basicRunMenuCommand26.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToEntireLayer_32x32.png";
      basicRunMenuCommand26.ToolTipDescription = Resources.Command_LcViewEntireLayer_ToolTip_Description;
      basicRunMenuCommand26.ToolTipText = Resources.Command_LcViewEntireLayer_ToolTip_Text;
      basicRunMenuCommand26.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand26.EnableCommand = false;
      basicRunMenuCommand26.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcViewEntireLayer = (MapInfoCommand) basicRunMenuCommand26;
      LayerControlCommands.LcViewEntireLayer.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand27 = new MapBasicRunMenuCommand(2502, nameof (LcLayerProperties), (InputGestureCollection) null);
      basicRunMenuCommand27.Text = Resources.Command_LcLayerProperties_Label;
      basicRunMenuCommand27.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/layerProperties_16x16.png";
      basicRunMenuCommand27.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layer/layerProperties_32x32.png";
      basicRunMenuCommand27.ToolTipDescription = Resources.Command_LcLayerProperties_ToolTip_Description;
      basicRunMenuCommand27.ToolTipText = Resources.Command_LcLayerProperties_ToolTip_Text;
      basicRunMenuCommand27.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand27.EnableCommand = false;
      basicRunMenuCommand27.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcLayerProperties = (MapInfoCommand) basicRunMenuCommand27;
      LayerControlCommands.LcLayerProperties.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand28 = new MapBasicRunMenuCommand(2542, nameof (LcRenameToFriendlyName), (InputGestureCollection) null);
      basicRunMenuCommand28.Text = Resources.Command_LcRenameToFriendlyName_Label;
      basicRunMenuCommand28.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_16x16.png";
      basicRunMenuCommand28.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_32x32.png";
      basicRunMenuCommand28.ToolTipDescription = Resources.Command_LcRenameToFriendlyName_ToolTip_Description;
      basicRunMenuCommand28.ToolTipText = Resources.Command_LcRenameToFriendlyName_ToolTip_Text;
      basicRunMenuCommand28.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand28.EnableCommand = true;
      basicRunMenuCommand28.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcRenameToFriendlyName = (MapInfoCommand) basicRunMenuCommand28;
      LayerControlCommands.LcRenameToFriendlyName.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand29 = new MapBasicRunMenuCommand(2503, nameof (LcLabelFont), (InputGestureCollection) null);
      basicRunMenuCommand29.Text = Resources.Command_LcLabelFont_Label;
      basicRunMenuCommand29.SmallIcon = (string) null;
      basicRunMenuCommand29.LargeIcon = (string) null;
      basicRunMenuCommand29.ToolTipDescription = Resources.Command_LcLabelFont_ToolTip_Description;
      basicRunMenuCommand29.ToolTipText = Resources.Command_LcLabelFont_ToolTip_Text;
      basicRunMenuCommand29.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand29.EnableCommand = false;
      basicRunMenuCommand29.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcLabelFont = (MapInfoCommand) basicRunMenuCommand29;
      LayerControlCommands.LcLabelFont.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand30 = new MapBasicRunMenuCommand(2504, nameof (LcOtherNoSelect), (InputGestureCollection) null);
      basicRunMenuCommand30.Text = Resources.Command_LcOtherNoSelect_Label;
      basicRunMenuCommand30.SmallIcon = (string) null;
      basicRunMenuCommand30.LargeIcon = (string) null;
      basicRunMenuCommand30.ToolTipDescription = Resources.Command_LcOtherNoSelect_ToolTip_Description;
      basicRunMenuCommand30.ToolTipText = Resources.Command_LcOtherNoSelect_ToolTip_Text;
      basicRunMenuCommand30.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand30.EnableCommand = false;
      basicRunMenuCommand30.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcOtherNoSelect = (MapInfoCommand) basicRunMenuCommand30;
      LayerControlCommands.LcOtherNoSelect.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand31 = new MapBasicRunMenuCommand(2505, nameof (LcRenameMap), (InputGestureCollection) null);
      basicRunMenuCommand31.Text = Resources.Command_LcRenameMap_Label;
      basicRunMenuCommand31.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_16x16.png";
      basicRunMenuCommand31.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_32x32.png";
      basicRunMenuCommand31.ToolTipDescription = Resources.Command_LcRenameMap_ToolTip_Description;
      basicRunMenuCommand31.ToolTipText = Resources.Command_LcRenameMap_ToolTip_Text;
      basicRunMenuCommand31.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand31.EnableCommand = false;
      basicRunMenuCommand31.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcRenameMap = (MapInfoCommand) basicRunMenuCommand31;
      LayerControlCommands.LcRenameMap.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand32 = new MapBasicRunMenuCommand(2506, nameof (LcMapOptions), (InputGestureCollection) null);
      basicRunMenuCommand32.Text = Resources.Command_LcMapOptions_Label;
      basicRunMenuCommand32.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/MapOptions_16x16.png";
      basicRunMenuCommand32.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/MapOptions_32x32.png";
      basicRunMenuCommand32.ToolTipDescription = Resources.Command_LcMapOptions_ToolTip_Description;
      basicRunMenuCommand32.ToolTipText = Resources.Command_LcMapOptions_ToolTip_Text;
      basicRunMenuCommand32.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand32.EnableCommand = false;
      basicRunMenuCommand32.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcMapOptions = (MapInfoCommand) basicRunMenuCommand32;
      LayerControlCommands.LcMapOptions.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand33 = new MapBasicRunMenuCommand(2507, nameof (LcAddGroup), (InputGestureCollection) null);
      basicRunMenuCommand33.Text = Resources.Command_LcAddGroup_Label;
      basicRunMenuCommand33.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/group_16x16.png";
      basicRunMenuCommand33.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/group_32x32.png";
      basicRunMenuCommand33.ToolTipDescription = Resources.Command_LcAddGroup_ToolTip_Description;
      basicRunMenuCommand33.ToolTipText = Resources.Command_LcAddGroup_ToolTip_Text;
      basicRunMenuCommand33.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand33.EnableCommand = false;
      basicRunMenuCommand33.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcAddGroup = (MapInfoCommand) basicRunMenuCommand33;
      LayerControlCommands.LcAddGroup.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand34 = new MapBasicRunMenuCommand(2508, nameof (LcRenameGroup), (InputGestureCollection) null);
      basicRunMenuCommand34.Text = Resources.Command_LcRenameGroup_Label;
      basicRunMenuCommand34.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_16x16.png";
      basicRunMenuCommand34.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/rename_32x32.png";
      basicRunMenuCommand34.ToolTipDescription = Resources.Command_LcRenameGroup_ToolTip_Description;
      basicRunMenuCommand34.ToolTipText = Resources.Command_LcRenameGroup_ToolTip_Text;
      basicRunMenuCommand34.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand34.EnableCommand = false;
      basicRunMenuCommand34.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcRenameGroup = (MapInfoCommand) basicRunMenuCommand34;
      LayerControlCommands.LcRenameGroup.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand35 = new MapBasicRunMenuCommand(2509, nameof (LcUnGroup), (InputGestureCollection) null);
      basicRunMenuCommand35.Text = Resources.Command_LcUnGroup_Label;
      basicRunMenuCommand35.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/ungroup_16x16.png";
      basicRunMenuCommand35.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/ungroup_32x32.png";
      basicRunMenuCommand35.ToolTipDescription = Resources.Command_LcUnGroup_ToolTip_Description;
      basicRunMenuCommand35.ToolTipText = Resources.Command_LcUnGroup_ToolTip_Text;
      basicRunMenuCommand35.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand35.EnableCommand = false;
      basicRunMenuCommand35.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcUnGroup = (MapInfoCommand) basicRunMenuCommand35;
      LayerControlCommands.LcUnGroup.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand36 = new MapBasicRunMenuCommand(2517, nameof (LcBrowseTable), (InputGestureCollection) null);
      basicRunMenuCommand36.Text = Resources.Command_LcBrowseTable_Label;
      basicRunMenuCommand36.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_16x16.png";
      basicRunMenuCommand36.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_32x32.png";
      basicRunMenuCommand36.ToolTipDescription = Resources.Command_LcBrowseTable_ToolTip_Description;
      basicRunMenuCommand36.ToolTipText = Resources.Command_LcBrowseTable_ToolTip_Text;
      basicRunMenuCommand36.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand36.EnableCommand = false;
      basicRunMenuCommand36.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcBrowseTable = (MapInfoCommand) basicRunMenuCommand36;
      LayerControlCommands.LcBrowseTable.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand37 = new MapBasicRunMenuCommand(2520, nameof (LcZoomToTileServer), (InputGestureCollection) null);
      basicRunMenuCommand37.Text = Resources.Command_LcZoomToTileServer_Label;
      basicRunMenuCommand37.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToNearestTileServerLevel_16x16.png";
      basicRunMenuCommand37.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomToNearestTileServerLevel_32x32.png";
      basicRunMenuCommand37.ToolTipDescription = Resources.Command_LcZoomToTileServer_ToolTip_Description;
      basicRunMenuCommand37.ToolTipText = Resources.Command_LcZoomToTileServer_ToolTip_Text;
      basicRunMenuCommand37.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand37.EnableCommand = false;
      basicRunMenuCommand37.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcZoomToTileServer = (MapInfoCommand) basicRunMenuCommand37;
      LayerControlCommands.LcZoomToTileServer.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand38 = new MapBasicRunMenuCommand(2521, nameof (LcClearCustomLabels), (InputGestureCollection) null);
      basicRunMenuCommand38.Text = Resources.Command_LcClearCustomLabels_Label;
      basicRunMenuCommand38.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCustomLabels_16x16.png";
      basicRunMenuCommand38.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clearCustomLabels_32x32.png";
      basicRunMenuCommand38.ToolTipDescription = Resources.Command_LcClearCustomLabels_ToolTip_Description;
      basicRunMenuCommand38.ToolTipText = Resources.Command_LcClearCustomLabels_ToolTip_Text;
      basicRunMenuCommand38.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand38.EnableCommand = false;
      basicRunMenuCommand38.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcClearCustomLabels = (MapInfoCommand) basicRunMenuCommand38;
      LayerControlCommands.LcClearCustomLabels.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand39 = new MapBasicRunMenuCommand(2523, nameof (LcSelectAll), (InputGestureCollection) null);
      basicRunMenuCommand39.Text = Resources.Command_LcSelectAll_Label;
      basicRunMenuCommand39.SmallIcon = (string) null;
      basicRunMenuCommand39.LargeIcon = (string) null;
      basicRunMenuCommand39.ToolTipDescription = Resources.Command_LcSelectAll_ToolTip_Description;
      basicRunMenuCommand39.ToolTipText = Resources.Command_LcSelectAll_ToolTip_Text;
      basicRunMenuCommand39.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand39.EnableCommand = false;
      basicRunMenuCommand39.Category = Resources.Command_Category_LayerCommands;
      LayerControlCommands.LcSelectAll = (MapInfoCommand) basicRunMenuCommand39;
      LayerControlCommands.LcSelectAll.CreateScreenTip();
    }

    public static MapInfoCommand LabelDisplayProps
    {
      get
      {
        return LayerControlCommands.LabelDisplayPropsCommand;
      }
    }

    public static MapInfoCommand LabelRulesProps
    {
      get
      {
        return LayerControlCommands.LabelRulesPropsCommand;
      }
    }

    public static MapInfoCommand LabelLineStyle
    {
      get
      {
        return LayerControlCommands.LabelLineStyleCommand;
      }
    }

    public static MapInfoCommand AddLayers
    {
      get
      {
        return LayerControlCommands.AddLayersCommand;
      }
    }

    public static MapInfoCommand LabelPriority
    {
      get
      {
        return LayerControlCommands.LabelPrioritiesCommand;
      }
    }

    public static MapInfoCommand LayerControlOptions
    {
      get
      {
        return LayerControlCommands.LayerControlOptionsCommand;
      }
    }

    public static MapInfoCommand RegionStyle
    {
      get
      {
        return LayerControlCommands.RegionStyleCommand;
      }
    }

    public static MapInfoCommand RegionStyleStacked
    {
      get
      {
        return LayerControlCommands.RegionStyleStackedCommand;
      }
    }

    public static MapInfoCommand LineStyle
    {
      get
      {
        return LayerControlCommands.LineStyleCommand;
      }
    }

    public static MapInfoCommand LineStyleStacked
    {
      get
      {
        return LayerControlCommands.LineStyleStackedCommand;
      }
    }

    public static MapInfoCommand SymbolStyle
    {
      get
      {
        return LayerControlCommands.SymbolStyleCommand;
      }
    }

    public static MapInfoCommand SymbolStyleStacked
    {
      get
      {
        return LayerControlCommands.SymbolStyleStackedCommand;
      }
    }

    public static MapInfoCommand TextStyle
    {
      get
      {
        return LayerControlCommands.TextStyleCommand;
      }
    }

    public static MapInfoCommand ShowNodes
    {
      get
      {
        return LayerControlCommands.ShowNodesCommand;
      }
    }

    public static MapInfoCommand ShowCentroids
    {
      get
      {
        return LayerControlCommands.ShowCentroidsCommand;
      }
    }

    public static MapInfoCommand ShowLineDirection
    {
      get
      {
        return LayerControlCommands.ShowLineDirectionCommand;
      }
    }

    public static MapInfoCommand ToggleStyleOverride
    {
      get
      {
        return LayerControlCommands.ToggleStyleOverrideCommand;
      }
    }

    public static MapInfoCommand ToggleStackedStyle
    {
      get
      {
        return LayerControlCommands.ToggleStackedStyleCommand;
      }
    }

    public static MapInfoCommand ToggleImageGrayScale
    {
      get
      {
        return LayerControlCommands.ToggleImageGrayScaleCommand;
      }
    }

    public static MapInfoCommand LcDisplayOverrideProperties
    {
      get
      {
        return LayerControlCommands.LcDisplayOverridePropertiesCommand;
      }
    }

    public static MapInfoCommand LcLabelOverrideProperties
    {
      get
      {
        return LayerControlCommands.LcLabelOverridePropertiesCommand;
      }
    }

    public static MapInfoCommand LcSplitOverride
    {
      get
      {
        return LayerControlCommands.LcSplitOverrideCommand;
      }
    }

    public static MapInfoCommand LcRemoveOverride
    {
      get
      {
        return LayerControlCommands.LcRemoveOverrideCommand;
      }
    }
  }
}
