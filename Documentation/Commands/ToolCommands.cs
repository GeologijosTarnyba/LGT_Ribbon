// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.ToolCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class ToolCommands
  {
    private static readonly MapInfoCommand SelectCommand;
    private static readonly MapInfoCommand ZoomInCommand;
    private static readonly MapInfoCommand ZoomOutCommand;
    private static readonly MapInfoCommand RecenterCommand;
    private static readonly MapInfoCommand SearchRadiusCommand;
    private static readonly MapInfoCommand SearchRectCommand;
    private static readonly MapInfoCommand SearchBoundaryCommand;
    private static readonly MapInfoCommand SearchPolygonCommand;
    private static readonly MapInfoCommand LabelToolCommand;
    private static readonly MapInfoCommand RulerCommand;
    private static readonly MapInfoCommand PointQueryCommand;
    private static readonly MapInfoCommand HotLinkCommand;
    private static readonly MapInfoCommand AddNodeCommand;
    private static readonly MapInfoCommand SelectRasterRegPointCommand;

    static ToolCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(1723, nameof (AddNode), MapInfoCommand.GetGesture(Resources.Command_AddNode_KeyGesture));
      basicRunMenuCommand1.Text = Resources.Command_AddNode_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/addNodes_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Spatial/addNodes_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_AddNode_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_AddNode_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_Disabled_AddNode;
      basicRunMenuCommand1.EnableCommand = false;
      basicRunMenuCommand1.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.AddNodeCommand = (MapInfoCommand) basicRunMenuCommand1;
      ToolCommands.AddNodeCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(1736, nameof (HotLink), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_HotLink_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/hotLink_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/hotLink_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_HotLink_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_HotLink_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_Disabled_HotLinkCommand;
      basicRunMenuCommand2.EnableCommand = false;
      basicRunMenuCommand2.CustomHelpId = new int?(MapInfoConstants.HotlinkHelpId);
      basicRunMenuCommand2.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.HotLinkCommand = (MapInfoCommand) basicRunMenuCommand2;
      ToolCommands.HotLinkCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(1701, nameof (Select), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_Select_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/select_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/select_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_Select_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_Select_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = true;
      basicRunMenuCommand3.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SelectCommand = (MapInfoCommand) basicRunMenuCommand3;
      ToolCommands.SelectCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(1703, nameof (SearchRadius), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_SearchRadius_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/areaSelect_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/areaSelect_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_SearchRadius_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_SearchRadius_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableOrLayoutWindow;
      basicRunMenuCommand4.EnableCommand = false;
      basicRunMenuCommand4.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SearchRadiusCommand = (MapInfoCommand) basicRunMenuCommand4;
      ToolCommands.SearchRadiusCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(1722, nameof (SearchRect), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_SearchRect_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/marqueeSelect_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/marqueeSelect_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_SearchRect_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_SearchRect_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableOrLayoutWindow;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SearchRectCommand = (MapInfoCommand) basicRunMenuCommand5;
      ToolCommands.SearchRectCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(1704, nameof (SearchBoundary), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_SearchBoundary_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/boundarySelect_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/boundarySelect_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_SearchBoundary_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_SearchBoundary_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableOrLayoutWindow;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SearchBoundaryCommand = (MapInfoCommand) basicRunMenuCommand6;
      ToolCommands.SearchBoundaryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(1733, nameof (SearchPolygon), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_SearchPolygon_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/polygonSelect_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/polygonSelect_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_SearchPolygon_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_SearchPolygon_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableOrLayoutWindow;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SearchPolygonCommand = (MapInfoCommand) basicRunMenuCommand7;
      ToolCommands.SearchPolygonCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(1705, nameof (ZoomIn), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_ZoomIn_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomIn_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomIn_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_ZoomIn_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_ZoomIn_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.ZoomInCommand = (MapInfoCommand) basicRunMenuCommand8;
      ToolCommands.ZoomInCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(1706, nameof (ZoomOut), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_ZoomOut_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomOut_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/zoomOut_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_ZoomOut_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_ZoomOut_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.ZoomOutCommand = (MapInfoCommand) basicRunMenuCommand9;
      ToolCommands.ZoomOutCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(1702, "Pan", (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_Pan_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/pan_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/pan_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_Pan_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_Pan_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.RecenterCommand = (MapInfoCommand) basicRunMenuCommand10;
      ToolCommands.RecenterCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(1708, nameof (LabelTool), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_LabelTool_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/labelTool_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/labelTool_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_LabelTool_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_LabelTool_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_Disabled_NeedActiveMap;
      basicRunMenuCommand11.EnableCommand = false;
      basicRunMenuCommand11.CustomHelpId = new int?(MapInfoConstants.LabelToolHelpId);
      basicRunMenuCommand11.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.LabelToolCommand = (MapInfoCommand) basicRunMenuCommand11;
      ToolCommands.LabelToolCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(1707, nameof (PointQuery), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_PointQuery_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/infoTool_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/infoTool_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_PointQuery_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_PointQuery_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand12.EnableCommand = false;
      basicRunMenuCommand12.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.PointQueryCommand = (MapInfoCommand) basicRunMenuCommand12;
      ToolCommands.PointQueryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(1710, nameof (Ruler), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_Ruler_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/measure_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/measure_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_Ruler_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_Ruler_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.RulerCommand = (MapInfoCommand) basicRunMenuCommand13;
      ToolCommands.RulerCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(1730, nameof (SelectRasterRegPoint), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_SelectRasterRegPoint_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterControlPoint_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/rasterControlPoint_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_SelectRasterRegPoint_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_SelectRasterRegPoint_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_SelectControlPointsFromMap;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_ToolCommands;
      ToolCommands.SelectRasterRegPointCommand = (MapInfoCommand) basicRunMenuCommand14;
      ToolCommands.SelectRasterRegPointCommand.CreateScreenTip();
    }

    public static MapInfoCommand SelectRasterRegPoint
    {
      get
      {
        return ToolCommands.SelectRasterRegPointCommand;
      }
    }

    public static MapInfoCommand AddNode
    {
      get
      {
        return ToolCommands.AddNodeCommand;
      }
    }

    public static MapInfoCommand HotLink
    {
      get
      {
        return ToolCommands.HotLinkCommand;
      }
    }

    public static MapInfoCommand Select
    {
      get
      {
        return ToolCommands.SelectCommand;
      }
    }

    public static MapInfoCommand ZoomIn
    {
      get
      {
        return ToolCommands.ZoomInCommand;
      }
    }

    public static MapInfoCommand ZoomOut
    {
      get
      {
        return ToolCommands.ZoomOutCommand;
      }
    }

    public static MapInfoCommand Recenter
    {
      get
      {
        return ToolCommands.RecenterCommand;
      }
    }

    public static MapInfoCommand SearchRadius
    {
      get
      {
        return ToolCommands.SearchRadiusCommand;
      }
    }

    public static MapInfoCommand SearchRect
    {
      get
      {
        return ToolCommands.SearchRectCommand;
      }
    }

    public static MapInfoCommand SearchBoundary
    {
      get
      {
        return ToolCommands.SearchBoundaryCommand;
      }
    }

    public static MapInfoCommand SearchPolygon
    {
      get
      {
        return ToolCommands.SearchPolygonCommand;
      }
    }

    public static MapInfoCommand LabelTool
    {
      get
      {
        return ToolCommands.LabelToolCommand;
      }
    }

    public static MapInfoCommand PointQuery
    {
      get
      {
        return ToolCommands.PointQueryCommand;
      }
    }

    public static MapInfoCommand Ruler
    {
      get
      {
        return ToolCommands.RulerCommand;
      }
    }
  }
}
