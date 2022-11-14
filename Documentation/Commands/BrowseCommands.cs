// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.BrowseCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class BrowseCommands
  {
    private static readonly MapBasicRunMenuCommand NewRowCommand;
    private static readonly MapBasicRunMenuCommand PickFieldsCommand;
    private static readonly MapBasicRunMenuCommand BrowserFontCommand;
    private static readonly MapBasicRunMenuCommand MultiSortCommand;
    private static readonly MapBasicRunMenuCommand SortCommand;
    private static readonly MapBasicRunMenuCommand SortAscendingCommand;
    private static readonly MapBasicRunMenuCommand SortDescendingCommand;
    private static readonly MapBasicRunMenuCommand ClearSortCommand;
    private static readonly MapBasicRunMenuCommand ClearAllCommand;
    private static readonly MapBasicRunMenuCommand ClearFilterCommand;
    private static readonly MapBasicRunMenuCommand ClearFiltersCommand;
    private static readonly MapBasicRunMenuCommand ReapplySortCommand;
    private static readonly MapBasicRunMenuCommand ToggleSortCommand;
    private static readonly MapBasicRunMenuCommand CreateQueryCommand;
    private static readonly MapBasicRunMenuCommand SelectAllCommand;
    private static readonly MapBasicRunMenuCommand UnselectAllCommand;
    private static readonly MapBasicRunMenuCommand FilterCommand;
    private static readonly MapInfoCommand ShowGridLinesCommand;

    static BrowseCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(704, nameof (PickFields), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_PickFields_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/pickFields_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/pickFields_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_PickFields_Tooltip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_PickFields_Tooltip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.PickFieldsCommand = basicRunMenuCommand1;
      BrowseCommands.PickFieldsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(713, nameof (BrowserFont), MapInfoCommand.GetGesture(Resources.Command_BrowserFont_KeyGesture));
      basicRunMenuCommand2.Text = Resources.Command_BrowserFont_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/browserFont_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/browserFont_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_BrowserFont_Tooltip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_BrowserFont_Tooltip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.BrowserFontCommand = basicRunMenuCommand2;
      BrowseCommands.BrowserFontCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(710, nameof (MultiSort), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_MultiSort_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortMulticolumn_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortMulticolumn_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_MultiSort_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_MultiSort_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.MultiSortCommand = basicRunMenuCommand3;
      BrowseCommands.MultiSortCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(2709, nameof (ReapplySort), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_ReapplySort_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/resort_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/resort_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_ReapplySort_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_ReapplySort_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ReapplySortCommand = basicRunMenuCommand4;
      BrowseCommands.ReapplySortCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(2701, nameof (ClearSort), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_ClearSort_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortClearSort_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortClearSort_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_ClearSort_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_ClearSort_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ClearSortCommand = basicRunMenuCommand5;
      BrowseCommands.ClearSortCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(2710, nameof (ClearAll), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_ClearAll_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearSortFilter_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearSortFilter_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_ClearAll_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_ClearAll_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ClearAllCommand = basicRunMenuCommand6;
      BrowseCommands.ClearAllCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(2706, nameof (ToggleSort), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_ToggleSort_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sort_onOff_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sort_onOff_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_ToggleSort_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_ToggleSort_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ToggleSortCommand = basicRunMenuCommand7;
      BrowseCommands.ToggleSortCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(2707, nameof (ClearFilters), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_ClearFilters_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearFilter_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearFilter_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_ClearFilters_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_ClearFilters_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ClearFiltersCommand = basicRunMenuCommand8;
      BrowseCommands.ClearFiltersCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(2705, nameof (ClearFilter), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_ClearFilter_Label;
      basicRunMenuCommand9.MenuItemText = Resources.Command_ClearFilter_MenuText;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearFilter_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/clearFilter_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_ClearFilter_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_ClearFilter_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ClearFilterCommand = basicRunMenuCommand9;
      BrowseCommands.ClearFilterCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(710, nameof (Sort), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_Sort_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sort_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sort_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_Sort_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_Sort_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.SortCommand = basicRunMenuCommand10;
      BrowseCommands.SortCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(2704, nameof (Filter), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_Filter_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/filter_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/filter_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_Filter_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_Filter_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.FilterCommand = basicRunMenuCommand11;
      BrowseCommands.FilterCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(2711, nameof (CreateQuery), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_CreateQuery_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToMap_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addToMap_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_CreateQuery_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_CreateQuery_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_OpenTable_SortFilter;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.CreateQueryCommand = basicRunMenuCommand12;
      BrowseCommands.CreateQueryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(2708, nameof (SelectAll), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_SelectAll_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_SelectAll_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_SelectAll_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.SelectAllCommand = basicRunMenuCommand13;
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(304, nameof (UnselectAll), MapInfoCommand.GetGesture(Resources.Command_UnselectAll_KeyGesture));
      basicRunMenuCommand14.Text = Resources.Command_UnselectAll_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_UnselectAll_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_UnselectAll_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.UnselectAllCommand = basicRunMenuCommand14;
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(702, nameof (NewRow), MapInfoCommand.GetGesture(Resources.Command_NewRow_KeyGesture));
      basicRunMenuCommand15.Text = Resources.Command_NewRow_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addNewRow_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/addNewRow_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_NewRow_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_NewRow_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveAndEditableBrowser;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.NewRowCommand = basicRunMenuCommand15;
      BrowseCommands.NewRowCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(712, nameof (ShowGridLines), (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_ShowGridLines_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/showGridlines_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/showGridlines_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_ShowGridLines_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_ShowGridLines_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveBrowserWindow;
      basicRunMenuCommand16.EnableCommand = false;
      basicRunMenuCommand16.CustomHelpId = new int?(3635);
      basicRunMenuCommand16.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.ShowGridLinesCommand = (MapInfoCommand) basicRunMenuCommand16;
      BrowseCommands.ShowGridLinesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(2702, nameof (SortAscending), (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_SortAscending_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortAscending_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortAscending_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_SortAscending_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_SortAscending_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveBrowserWindow;
      basicRunMenuCommand17.EnableCommand = false;
      basicRunMenuCommand17.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.SortAscendingCommand = basicRunMenuCommand17;
      BrowseCommands.SortAscendingCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(2703, nameof (SortDescending), (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_SortDescending_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortDescending_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/sortDescending_32x32.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_SortDescending_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_SortDescending_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveBrowserWindow;
      basicRunMenuCommand18.EnableCommand = false;
      basicRunMenuCommand18.Category = Resources.Command_Category_BrowserCommands;
      BrowseCommands.SortDescendingCommand = basicRunMenuCommand18;
      BrowseCommands.SortDescendingCommand.CreateScreenTip();
    }

    public static MapInfoCommand NewRow
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.NewRowCommand;
      }
    }

    public static MapInfoCommand ShowGridLines
    {
      get
      {
        return BrowseCommands.ShowGridLinesCommand;
      }
    }

    public static MapInfoCommand PickFields
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.PickFieldsCommand;
      }
    }

    public static MapInfoCommand BrowserFont
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.BrowserFontCommand;
      }
    }

    public static MapInfoCommand Sort
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.SortCommand;
      }
    }

    public static MapInfoCommand Filter
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.FilterCommand;
      }
    }

    public static MapInfoCommand SortAscending
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.SortAscendingCommand;
      }
    }

    public static MapInfoCommand SortDescending
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.SortDescendingCommand;
      }
    }

    public static MapInfoCommand ClearSort
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ClearSortCommand;
      }
    }

    public static MapInfoCommand ClearAll
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ClearAllCommand;
      }
    }

    public static MapInfoCommand ToggleSort
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ToggleSortCommand;
      }
    }

    public static MapInfoCommand ReapplySort
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ReapplySortCommand;
      }
    }

    public static MapInfoCommand MultiSort
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.MultiSortCommand;
      }
    }

    public static MapInfoCommand SelectAll
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.SelectAllCommand;
      }
    }

    public static MapInfoCommand UnselectAll
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.UnselectAllCommand;
      }
    }

    public static MapInfoCommand CreateQuery
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.CreateQueryCommand;
      }
    }

    public static MapInfoCommand ClearFilters
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ClearFiltersCommand;
      }
    }

    public static MapInfoCommand ClearFilter
    {
      get
      {
        return (MapInfoCommand) BrowseCommands.ClearFilterCommand;
      }
    }
  }
}
