// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.QueryCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class QueryCommands
  {
    private static readonly MapBasicRunMenuCommand QueryUnselectCommand;
    private static readonly MapBasicRunMenuCommand QueryInvertSelectCommand;
    private static readonly MapBasicRunMenuCommand QuerySelectCommand;
    private static readonly MapBasicRunMenuCommand QuerySqlQueryCommand;
    private static readonly MapBasicRunMenuCommand FindFrontSelectionCommand;
    private static readonly MapBasicRunMenuCommand FindSelectionCommand;
    private static readonly MapBasicRunMenuCommand FindAddressCommand;
    private static readonly MapBasicRunMenuCommand FindCommand;

    static QueryCommands()
    {
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand1 = new SelectiveRequeryRunMenuCommand(301, "SimpleSelect", MapInfoCommand.GetGesture(Resources.Command_SimpleSelect_KeyGesture));
      requeryRunMenuCommand1.Text = Resources.Command_SelectQuery_Label;
      requeryRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/sqlSelectSimple_16x16.png";
      requeryRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/sqlSelectSimple_32x32.png";
      requeryRunMenuCommand1.ToolTipDescription = Resources.Command_SelectQuery_ToolTip_Description;
      requeryRunMenuCommand1.ToolTipText = Resources.Command_SelectQuery_ToolTip_Text;
      requeryRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenBrowsable_Table;
      requeryRunMenuCommand1.EnableCommand = false;
      requeryRunMenuCommand1.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.QuerySelectCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand1;
      QueryCommands.QuerySelectCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand2 = new SelectiveRequeryRunMenuCommand(304, nameof (UnSelect), MapInfoCommand.GetGesture(Resources.Command_UnSelect_KeyGesture));
      requeryRunMenuCommand2.Text = Resources.Command_UnSelect_Label;
      requeryRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clear_16x16.png";
      requeryRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/clear_32x32.png";
      requeryRunMenuCommand2.ToolTipDescription = Resources.Command_UnSelect_ToolTip_Description;
      requeryRunMenuCommand2.ToolTipText = Resources.Command_UnSelect_ToolTip_Text;
      requeryRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      requeryRunMenuCommand2.EnableCommand = false;
      requeryRunMenuCommand2.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.QueryUnselectCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand2;
      QueryCommands.QueryUnselectCommand.CreateScreenTip();
      SelectiveRequeryRunMenuCommand requeryRunMenuCommand3 = new SelectiveRequeryRunMenuCommand(311, "InvertSelection", (InputGestureCollection) null);
      requeryRunMenuCommand3.Text = Resources.Command_InvertSelection_Label;
      requeryRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/invert_16x16.png";
      requeryRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/invert_32x32.png";
      requeryRunMenuCommand3.ToolTipDescription = Resources.Command_InvertSelection_ToolTip_Description;
      requeryRunMenuCommand3.ToolTipText = Resources.Command_InvertSelection_ToolTip_Text;
      requeryRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      requeryRunMenuCommand3.EnableCommand = false;
      requeryRunMenuCommand3.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.QueryInvertSelectCommand = (MapBasicRunMenuCommand) requeryRunMenuCommand3;
      QueryCommands.QueryInvertSelectCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(312, nameof (FindFrontSelection), MapInfoCommand.GetGesture(Resources.Command_FindFrontSelection_KeyGesture));
      basicRunMenuCommand1.Text = Resources.Command_FindFrontSelection_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_FindFrontSelection_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_FindFrontSelection_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.FindFrontSelectionCommand = basicRunMenuCommand1;
      QueryCommands.FindFrontSelectionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(302, nameof (SqlQuery), MapInfoCommand.GetGesture(Resources.Command_SqlQuery_KeyGesture));
      basicRunMenuCommand2.Text = Resources.Command_SqlQuery_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/sqlSelect_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/sqlSelect_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_SqlQuery_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_SqlQuery_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenBrowsable_Table;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.QuerySqlQueryCommand = basicRunMenuCommand2;
      QueryCommands.QuerySqlQueryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(306, nameof (FindSelection), MapInfoCommand.GetGesture(Resources.Command_FindSelection_KeyGesture));
      basicRunMenuCommand3.Text = Resources.Command_FindSelection_Label;
      basicRunMenuCommand3.MenuItemText = Resources.Command_FindSelection_MenuItemText;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/findMapSelection_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_FindSelection_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_FindSelection_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      basicRunMenuCommand3.EnableCommand = false;
      basicRunMenuCommand3.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.FindSelectionCommand = basicRunMenuCommand3;
      QueryCommands.FindSelectionCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(313, nameof (FindAddress), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_FindAddress_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/findAddress_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/findAddress_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_FindAddress_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_FindAddress_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.FindAddressCommand = basicRunMenuCommand4;
      QueryCommands.FindAddressCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(305, nameof (Find), MapInfoCommand.GetGesture(Resources.Command_Find_KeyGesture));
      basicRunMenuCommand5.Text = Resources.Command_Find_Label;
      basicRunMenuCommand5.MenuItemText = Resources.Command_Find_MenuItemText;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/findAndMark_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/findAndMark_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_Find_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_Find_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_QueryCommands;
      QueryCommands.FindCommand = basicRunMenuCommand5;
      QueryCommands.FindCommand.CreateScreenTip();
    }

    public static MapInfoCommand UnSelect
    {
      get
      {
        return (MapInfoCommand) QueryCommands.QueryUnselectCommand;
      }
    }

    public static MapInfoCommand InvertSelect
    {
      get
      {
        return (MapInfoCommand) QueryCommands.QueryInvertSelectCommand;
      }
    }

    public static MapInfoCommand SelectQuery
    {
      get
      {
        return (MapInfoCommand) QueryCommands.QuerySelectCommand;
      }
    }

    public static MapInfoCommand FindFrontSelection
    {
      get
      {
        return (MapInfoCommand) QueryCommands.FindFrontSelectionCommand;
      }
    }

    public static MapInfoCommand SqlQuery
    {
      get
      {
        return (MapInfoCommand) QueryCommands.QuerySqlQueryCommand;
      }
    }

    public static MapInfoCommand Find
    {
      get
      {
        return (MapInfoCommand) QueryCommands.FindCommand;
      }
    }

    public static MapInfoCommand FindAddress
    {
      get
      {
        return (MapInfoCommand) QueryCommands.FindAddressCommand;
      }
    }

    public static MapInfoCommand FindSelection
    {
      get
      {
        return (MapInfoCommand) QueryCommands.FindSelectionCommand;
      }
    }
  }
}
