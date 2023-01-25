using LGT_Ribbon.Core;
using MapInfo.Commands;
using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LGT_Ribbon.Seed
{
  public static class Seed1
  {
    static Seed1()
    {
      temp = new Button(LayoutCommandID.AddMapFrame, LayoutCommands.AddMapFrame, ControlType.DropDownButton) {
        Caption = "Map",
        Children = new Button[]
        {
          new Button(LayoutCommandID.AddMapFrame, LayoutCommands.AddMapFrame)
        }
      };
      Tabs = new Tab[]
        {
          #region Scrapes
          //new Tab("Scrapes", "SCRAPES"){
          //  Visible = PC.Is(UserLevel.Admin),
          //},
	        #endregion
          #region HOME
          new Tab("Home", "HOME"){
            Index = 0,
            Ignore = false,
            IsSelected = true,
            Groups = new TabGroup[]{
              new TabGroup("HOME_File", "File"){
                Controls = new Button[]
                {
                  myOpenButtons,
                  new Button(ApplicationCommandID.OpenTable, ApplicationCommands.OpenTable){IsLarge = true},
                  new Button(ApplicationCommandID.SaveWorkspace, ApplicationCommands.SaveWorkspace, ControlType.Button){
                    IsLarge = true
                  },
                  new Button(ApplicationCommandID.SaveCopyAs, ApplicationCommands.SaveCopyAs, ControlType.DropDownButton)
                  {
                    Caption = "Save",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.SaveTable, ApplicationCommands.SaveTable),
                      new Button(ApplicationCommandID.SaveCopyAs, ApplicationCommands.SaveCopyAs)
                    }
                  },
                  new Button(ApplicationCommandID.CloseAll, ApplicationCommands.CloseAll, ControlType.DropDownButton)
                  {
                    Caption = "Close",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.CloseDBMS, ApplicationCommands.CloseDBMS),
                      new Button(ApplicationCommandID.CloseTable, ApplicationCommands.CloseTable),
                      new Button(ApplicationCommandID.CloseAll, ApplicationCommands.CloseAll)
                    }
                  }
                }
              },
              //myClipboardGroup,
              new TabGroup("HOME_Windows", "Windows"){
                Controls = new Button[] {
                  new Button(WindowCommandID.CloneWindow, WindowCommands.CloneWindow, ControlType.DropDownButton){ // incorect icon
                    Caption = "New Document",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(WindowCommandID.NewMapWindow, WindowCommands.NewMapWindow),
                      new Button(WindowCommandID.NewBrowserWindow, WindowCommands.NewBrowserWindow),
                      new Button(LayoutCommandID.AddLegends, LayoutCommands.AddLegends),
                      new Button(WindowCommandID.NewLayoutWindow, WindowCommands.NewLayoutWindow),
                      new Button(WindowCommandID.ThreeDWindow, WindowCommands.ThreeDWindow),
                      new Button(WindowCommandID.PrismWindow, WindowCommands.PrismWindow),
                      new Button(WindowCommandID.RedistrictWindow, WindowCommands.RedistrictWindow),
                      new Button(MapCommandID.CloneMapper, MapCommands.CloneMapper),
                      new Button(WindowCommandID.RedrawWindow, WindowCommands.RedrawWindow),
                      new Button(WindowCommandID.StatusBarWindow, WindowCommands.StatusBarWindow)
                    }
                  },
                  new Button(WindowCommandID.InfoWindow, WindowCommands.InfoWindow, ControlType.DropDownButton)
                  {
                    Caption = "Tool Windows",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(WindowCommandID.InfoWindow, WindowCommands.InfoWindow),
                      new Button(WindowCommandID.WorkspaceExplorer, WindowCommands.WorkspaceExplorer),
                      //new Button(WindowCommandID.MapBasicWindow, WindowCommands.MapBasicWindow), // Doesnt work properly - commented
                      new Button(WindowCommandID.RulerWindow, WindowCommands.RulerWindow),
                      new Button(WindowCommandID.MessageWindow, WindowCommands.MessageWindow),
                      new Button(WindowCommandID.TaskManager, WindowCommands.TaskManager),
                      new Button(WindowCommandID.StatisticsWindow, WindowCommands.StatisticsWindow),
                      new Button(MapCommandID.MoveMapTo, MapCommands.MoveMapTo),
                      new Button(WindowCommandID.LegendWindow, WindowCommands.LegendWindow), // Themes
                      new Button(WindowCommandID.ToolManager, WindowCommands.ToolManager), // Tool Extensions

                      new Button(WindowCommandID.WindowList, WindowCommands.WindowList),
                      new Button(WindowCommandID.ConnectionList, WindowCommands.ConnectionList),
                      new Button(WindowCommandID.TableList, WindowCommands.TableList)
                    }

                  },
                }

              },
              new TabGroup("HOME_4", ""){
                Controls = new Button[]
                {
                  new Button(WindowCommandID.RecoverWindows, WindowCommands.RecoverWindows) {
                    Caption = "Recover Windows",
                    IsLarge = true
                  }
                }
              },
              new TabGroup("HOME_Output", "Output"){
                Controls = new Button[]
                {
                  // new Button(ApplicationCommandID.PrintToPDF, ApplicationCommands.PrintToPDF){ IsLarge = true }, // Veikia tik PRO versijoje
                  new Button(ApplicationCommandID.Print, ApplicationCommands.Print){ IsLarge = true },
                  new Button(ApplicationCommandID.SaveWindowAs, ApplicationCommands.SaveWindowAs){ IsLarge = true },
                  new Button(ApplicationCommandID.PageSetup, ApplicationCommands.PageSetup){ IsLarge = true }
                }
              },
              new TabGroup("HOME_Tools", "Tools"){
                Controls = new Button[]
                {
                  new Button(WindowCommandID.ToolManager, WindowCommands.ToolManager) { IsLarge = true }
                }
              },
            }
          }, 
        	#endregion
          #region TABLE
		      new Tab("Table", "TABLE"){
            Index = 1,
            Ignore = false,
            Groups = new TabGroup[]{
              new TabGroup("TABLE_Content", "Content"){
                  Controls = new Button[]
                  {
                    new Button(WindowCommandID.NewBrowserWindow, WindowCommands.NewBrowserWindow){ IsLarge = true},
                    myOpenButtons,
                    new Button(ApplicationCommandID.SaveTable, ApplicationCommands.SaveTable, ControlType.DropDownButton){
                      Caption = "Save",
                      Children = new Button[]
                      {
                        new Button(ApplicationCommandID.SaveTable, ApplicationCommands.SaveTable),
                        new Button(ApplicationCommandID.SaveQuery, ApplicationCommands.SaveQuery),
                        new Button(ApplicationCommandID.SaveCopyAs, ApplicationCommands.SaveCopyAs),
                      }
                    },
                    new Button(TableCommandID.RevertTable, TableCommands.RevertTable),
                    new Button(ApplicationCommandID.CloseTable, ApplicationCommands.CloseTable),
                    new Button(ApplicationCommandID.NewTable, ApplicationCommands.NewTable),
                    new Button(TableCommandID.Export, TableCommands.Export),
                  }
                },
              new TabGroup("TABLE_Selection", "Selection"){
                  Controls = new Button[]
                  {
                    new Button(ToolCommandID.Select, ToolCommands.Select){ IsLarge = true },
                    mySQLSelect,
                    new Button(QueryCommandID.InvertSelect, QueryCommands.InvertSelect),
                    new Button(QueryCommandID.UnSelect, QueryCommands.UnSelect),
                    myFind
                  }
                },
              new TabGroup("TABLE_Maintenance", "Maintenance"){
                  Controls = new Button[]
                  {
                    new Button("Table", ControlType.DropDownButton){
                      IsLarge = true,
                      Children = new Button[]{
                        new Button(TableCommandID.ModifyStructure, TableCommands.ModifyStructure){ IsLarge = true },
                        new Button(TableCommandID.Pack, TableCommands.Pack){ IsLarge = true },
                        new Button(TableCommandID.Delete, TableCommands.Delete){ IsLarge = true },
                        new Button(TableCommandID.Rename, TableCommands.Rename){ IsLarge = true },

                      },
                    },
                    new Button("Database", ControlType.DropDownButton){
                      IsLarge = true,
                      Children = new Button[]
                      {
                        new Button(TableCommandID.MakeMappable, TableCommands.MakeMappable),
                        new Button(TableCommandID.ChangeSymbol, TableCommands.ChangeSymbol),
                        new Button(TableCommandID.Unlink, TableCommands.Unlink),
                        new Button(TableCommandID.RefreshDBMS, TableCommands.RefreshDBMS),
                        new Button(ControlType.ContextMenuSeparator),
                        new Button(OracleWorkspaceCommandID.CreateWorkspace, OracleWorkspaceCommands.CreateWorkspace),
                        new Button(OracleWorkspaceCommandID.DeleteWorkspace, OracleWorkspaceCommands.DeleteWorkspace),
                        new Button(OracleWorkspaceCommandID.MergeTable, OracleWorkspaceCommands.MergeTable),
                        new Button(OracleWorkspaceCommandID.RefreshOracleTable, OracleWorkspaceCommands.RefreshOracleTable),
                        new Button(ControlType.ContextMenuSeparator),
                        new Button(OracleWorkspaceCommandID.EnableOracleVersioning, OracleWorkspaceCommands.EnableOracleVersioning),
                        new Button(OracleWorkspaceCommandID.DisableOracleVersioning, OracleWorkspaceCommands.DisableOracleVersioning),
                      }

                    },
                    new Button(TableCommandID.ViewEditMetadata, TableCommands.ViewEditMetadata, ControlType.DropDownButton){
                      Caption = "Library",
                      Children = new Button[]
                      {
                        new Button(TableCommandID.AddToLibrary, TableCommands.AddToLibrary) { IsLarge = true },
                        new Button(TableCommandID.ViewEditMetadata, TableCommands.ViewEditMetadata) { IsLarge = true },
                      }
                    },

                    new Button("Raster", ControlType.DropDownButton){
                      AccessableTo = UserLevel.Admin,
                      Children = new Button[]
                      {

                      }
                    },
                    new Button("Web Services", ControlType.DropDownButton){
                      Children = new Button[]
                      {
                        new Button(WebServicesCommandID.WfsProps, WebServicesCommands.WfsProps){ IsLarge = true },
                        new Button(WebServicesCommandID.WfsRefresh, WebServicesCommands.WfsRefresh){ IsLarge = true },
                        new Button(WebServicesCommandID.WmsProps, WebServicesCommands.WmsProps) { IsLarge = true },
                        new Button(WebServicesCommandID.WmtsProps, WebServicesCommands.WmtsProps) {IsLarge = true },
                      }
                    },
                  }
                },
              new TabGroup("TABLE_Calculate", "Calculate"){
                  Controls = new Button[]
                  {
                    new Button(TableCommandID.CalcColStats, TableCommands.CalcColStats)
                  }
                },
            }
          },
          #endregion
          #region MAP
          new Tab("Map", "MAP"){
            Index = 2,
            Groups = new TabGroup[]
            {
              new TabGroup("MAP_Content", "Content"){
                Controls = new Button[]
                {
                  new Button(WindowCommandID.NewMapWindow, WindowCommands.NewMapWindow){ IsLarge = true},
                  myOpenButtons,
                  new Button(MapCommandID.AddThematic, MapCommands.AddThematic) { IsLarge = true },
                  new Button(BrowseCommandsID.CreateQuery, BrowseCommands.CreateQuery, ControlType.DropDownButton)
                  {
                    IsLarge = true,
                    Children = new Button[]
                    {
                      //new Button(LayoutCommandID.AddLegends, LayoutCommands.AddLegends), // neveikė, turbūt kad MapCommandID.CreateLegendDesigner, MapCommands.CreateLegendDesigner turi būti
                      new Button(MapCommandID.CreateLegendDesigner, MapCommands.CreateLegendDesigner),
                      new Button(LayoutCommandID.ToggleGridLines, LayoutCommands.ToggleGridLines),
                      new Button(MapCommandID.CreateScalebar, MapCommands.CreateScalebar)
                    }
                  },
                  new Button(MapCommandID.SaveCosmetic, MapCommands.SaveCosmetic, ControlType.DropDownButton)
                  {
                    Caption = "Cosmetic",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(MapCommandID.ClearCosmetic, MapCommands.ClearCosmetic),
                      new Button(MapCommandID.SaveCosmetic, MapCommands.SaveCosmetic)
                    }
                  }
                }
              },
              new TabGroup("MAP_Selection", "Selection"){
                Controls = new Button[]
                {
                  new Button(ToolCommandID.Select, ToolCommands.Select, ControlType.SplitButton)
                  {
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(ToolCommandID.Select, ToolCommands.Select, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.SearchRadius, ToolCommands.SearchRadius, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.SearchRect, ToolCommands.SearchRect, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.SearchPolygon, ToolCommands.SearchPolygon, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.SearchBoundary, ToolCommands.SearchBoundary, ControlType.ToolButton){ IsLarge = true },
                    }
                  },
                  mySQLSelect,
                  new Button(QueryCommandID.InvertSelect, QueryCommands.InvertSelect),
                  new Button(QueryCommandID.UnSelect, QueryCommands.UnSelect),
                  myFind

                }
              },
              new TabGroup("MAP_Navigate", "Navigate"){
                Controls = new Button[]
                {
                  new Button(ToolCommandID.Recenter, ToolCommands.Recenter, ControlType.ToolButton){ IsLarge = true },
                  new Button(ToolCommandID.ZoomIn, ToolCommands.ZoomIn, ControlType.ToolButton){ IsLarge = true },
                  new Button(ToolCommandID.ZoomOut, ToolCommands.ZoomOut, ControlType.ToolButton){ IsLarge = true },
                  new Button("Zoom To", ControlType.DropDownButton) // tbd
                  {
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(MapCommandID.ViewEntireSelectionLayer, MapCommands.ViewEntireSelectionLayer){ IsLarge = true },
                      new Button(MapCommandID.ViewEntireSelectedObjects, MapCommands.ViewEntireSelectedObjects) { IsLarge = true },
                      new Button(MapCommandID.ViewEntireLayer, MapCommands.ViewEntireLayer) { IsLarge = true },
                      new Button(MapCommandID.ViewEntireMap, MapCommands.ViewEntireMap) { IsLarge = true },
                      new Button(MapCommandID.ViewNearestTileServerLevel, MapCommands.ViewNearestTileServerLevel) { IsLarge = true },
                    }
                  },
                  new Button(MapCommandID.PreviousView, MapCommands.PreviousView),
                  new Button(MapCommandID.MoveMapTo, MapCommands.MoveMapTo),
                  new Button(MapCommandID.ChangeView, MapCommands.ChangeView),
                }
              },
              new TabGroup("MAP_Options", "Options")
              {
                Controls = new Button[]
                {
                  new Button(WindowCommandID.InfoWindow, WindowCommands.InfoWindow, ControlType.DropDownButton)
                  {
                    Caption = "Map Tools",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      //tbd 2 columns of large icons
                      new Button(ToolCommandID.Ruler, ToolCommands.Ruler),
                      new Button(EditCommandID.GetInfo, EditCommands.GetInfo, ControlType.ToolButton), //?
                      new Button(WindowCommandID.StatisticsWindow, WindowCommands.StatisticsWindow),
                      new Button(ToolCommandID.HotLink, ToolCommands.HotLink),
                      new Button(WindowCommandID.WorkspaceExplorer, WindowCommands.WorkspaceExplorer),
                      new Button(WindowCommandID.RedrawWindow, WindowCommands.RedrawWindow),
                    }
                  },
                  // 2020-02-06
                  // Sukurtas TabGroup "MAP_Spatio", kuriame turėtų būti visi čia esantys mygtukai. 
                  //new Button(WindowCommandID.InfoWindow, WindowCommands.InfoWindow, ControlType.DropDownButton)
                  //{
                  //  Caption = "Spatial Tools",
                  //  IsLarge = true,
                  //  Children = new Button[]
                  //  {
                  //    //tbd 2 columns of large icons
                  //    new Button(SpatialCommandID.InsertLine, SpatialCommands.InsertLine),
                  //    new Button(SpatialCommandID.InsertPolyline, SpatialCommands.InsertPolyline),
                  //    new Button(SpatialCommandID.InsertPolygon, SpatialCommands.InsertPolygon),
                  //    new Button(SpatialCommandID.InsertEllipse, SpatialCommands.InsertEllipse),
                  //    new Button(SpatialCommandID.InsertArc, SpatialCommands.InsertArc),
                  //    new Button(SpatialCommandID.InsertRectangle, SpatialCommands.InsertRectangle),
                  //    new Button(SpatialCommandID.InsertRoundedRectangle, SpatialCommands.InsertRoundedRectangle),
                  //    new Button(SpatialCommandID.InsertText, SpatialCommands.InsertText),
                  //    new Button(SpatialCommandID.RotateObject, SpatialCommands.RotateObject),
                  //    new Button(SpatialCommandID.OffsetObject, SpatialCommands.OffsetObject),
                  //    new Button(SpatialCommandID.Snap, SpatialCommands.Snap),
                  //    new Button(SpatialCommandID.Smooth, SpatialCommands.Smooth),
                  //    new Button(SpatialCommandID.Unsmooth, SpatialCommands.Unsmooth),
                  //    new Button(SpatialCommandID.Reshape, SpatialCommands.Reshape),
                  //    new Button(SpatialCommandID.DigitizerSetup, SpatialCommands.DigitizerSetup),
                  //  }
                  //},
                  new Button("Redistricter", ControlType.DropDownButton){
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(WindowCommandID.RedistrictWindow, WindowCommands.RedistrictWindow),
                      new Button(RedistrictCommandID.Target, RedistrictCommands.Target),
                      new Button(RedistrictCommandID.Assign, RedistrictCommands.Assign),
                      new Button(RedistrictCommandID.Add, RedistrictCommands.Add),
                      new Button(ControlType.ContextMenuSeparator),
                      new Button(RedistrictCommandID.Delete, RedistrictCommands.Delete),
                      new Button(RedistrictCommandID.Options, RedistrictCommands.Options),
                    }
                  },
                  new Button(MapCommandID.MapOptions, MapCommands.MapOptions){ IsLarge = true },
                  new Button(MapCommandID.HotlinkOptions, MapCommands.HotlinkOptions),
                  new Button(ToolCommandID.Recenter, ToolCommands.Recenter, ControlType.ToolButton),
                  new Button(MapCommandID.LockScale, MapCommands.LockScale),

                }
              },
              new TabGroup("MAP_Spatial", "Spatial"){
                Controls = new Button[]
                {
                  new Button("Styles", ControlType.DropDownButton) {
                    Children = new Button[] {
                      new Button(SpatialCommandID.LineStyle, SpatialCommands.LineStyle), // All Controls
                      new Button(SpatialCommandID.RegionStyle, SpatialCommands.RegionStyle), // All Controls
                      new Button(SpatialCommandID.SymbolStyle, SpatialCommands.SymbolStyle), // All Controls
                      new Button(SpatialCommandID.TextStyle, SpatialCommands.TextStyle), // All Controls
                    }
                  },
                  new Button("Objects", ControlType.DropDownButton) {
                    Children = new Button[] {
                      new Button(SpatialCommandID.InsertText, SpatialCommands.InsertText), // All Controls
                      new Button(SpatialCommandID.InsertSymbol, SpatialCommands.InsertSymbol), // All Controls
                      new Button(SpatialCommandID.InsertLine, SpatialCommands.InsertLine), // All Controls
                      new Button(SpatialCommandID.InsertPolyline, SpatialCommands.InsertPolyline), // All Controls
                      new Button(SpatialCommandID.InsertPolygon, SpatialCommands.InsertPolygon), // All Controls
                      new Button(SpatialCommandID.InsertEllipse, SpatialCommands.InsertEllipse), // All Controls
                      new Button(SpatialCommandID.InsertArc, SpatialCommands.InsertArc), // All Controls
                      new Button(SpatialCommandID.InsertRectangle, SpatialCommands.InsertRectangle), // All Controls
                      new Button(SpatialCommandID.InsertRoundedRectangle, SpatialCommands.InsertRoundedRectangle), // All Controls
                    }
                  },
                  new Button("Other", ControlType.DropDownButton){
                    Children = new Button[] {
                      new Button(SpatialCommandID.VoronoiTable, SpatialCommands.VoronoiTable), // All Controls
                      new Button(SpatialCommandID.DriveRegionsTable, SpatialCommands.DriveRegionsTable), // All Controls
                      new Button(SpatialCommandID.DigitizerSetup, SpatialCommands.DigitizerSetup), // All Controls
                      new Button(SpatialCommandID.Reshape, SpatialCommands.Reshape), // All Controls
                      new Button(SpatialCommandID.Smooth, SpatialCommands.Smooth), // All Controls
                      new Button(SpatialCommandID.Unsmooth, SpatialCommands.Unsmooth), // All Controls
                      new Button(SpatialCommandID.ConvertToPolyline, SpatialCommands.ConvertToPolyline), // All Controls
                      new Button(SpatialCommandID.CombineObjects, SpatialCommands.CombineObjects), // All Controls
                      new Button(SpatialCommandID.Buffer, SpatialCommands.Buffer), // All Controls
                      new Button(SpatialCommandID.ConvertToRegion, SpatialCommands.ConvertToRegion), // All Controls
                      new Button(SpatialCommandID.SetTarget, SpatialCommands.SetTarget), // All Controls
                      new Button(SpatialCommandID.ClearTarget, SpatialCommands.ClearTarget), // All Controls
                      new Button(SpatialCommandID.SplitTarget, SpatialCommands.SplitTarget), // All Controls
                      new Button(SpatialCommandID.EraseTarget, SpatialCommands.EraseTarget), // All Controls
                      new Button(SpatialCommandID.EraseOutsideTarget, SpatialCommands.EraseOutsideTarget), // All Controls
                      new Button(SpatialCommandID.OverlayNode, SpatialCommands.OverlayNode), // All Controls
                      new Button(SpatialCommandID.ConvexHull, SpatialCommands.ConvexHull), // All Controls
                      new Button(SpatialCommandID.Enclose, SpatialCommands.Enclose), // All Controls
                      new Button(SpatialCommandID.CheckRegions, SpatialCommands.CheckRegions), // All Controls
                      new Button(SpatialCommandID.Clean, SpatialCommands.Clean), // All Controls
                      new Button(SpatialCommandID.Snap, SpatialCommands.Snap), // All Controls
                      new Button(SpatialCommandID.Disaggregate, SpatialCommands.Disaggregate), // All Controls
                      new Button(SpatialCommandID.Voronoi, SpatialCommands.Voronoi), // All Controls
                      new Button(SpatialCommandID.PolylineSplit, SpatialCommands.PolylineSplit), // All Controls
                      new Button(SpatialCommandID.OffsetObject, SpatialCommands.OffsetObject), // All Controls
                      new Button(SpatialCommandID.RotateObject, SpatialCommands.RotateObject), // All Controls
                      new Button(SpatialCommandID.PolylineSplitAtNode, SpatialCommands.PolylineSplitAtNode), // All Controls
                      new Button(SpatialCommandID.CreateDriveRegions, SpatialCommands.CreateDriveRegions), // All Controls
                    }
                  }
                }
              }
            }
          },
          #endregion
          #region LAYOUT
          new Tab("Layout", "LAYOUT"){
            Index = 3,
            Groups = new TabGroup[]
            {
              new TabGroup("LAYOUT_Page", "Page"){
                Controls = new Button[]
                {
                  new Button(WindowCommandID.NewLayoutWindow, WindowCommands.NewLayoutWindow){ IsLarge = true, Caption = "New Layout" },
                  new Button(LayoutCommandID.LayoutPageSetup, LayoutCommands.LayoutPageSetup) { IsLarge = true },
                  new Button("Output", ControlType.DropDownButton)
                  {
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.Print, ApplicationCommands.Print) { IsLarge = true },
                      new Button(ApplicationCommandID.PrintToPDF, ApplicationCommands.PrintToPDF) { IsLarge = true },
                      new Button(TableCommandID.Export, TableCommands.Export) { IsLarge = true },
                    }
                  }

                }
              },
              new TabGroup("LAYOUT_Clipboard", "Clipboard"){
                Controls = new Button[]
                {
                  new Button(EditCommandID.Copy, EditCommands.Copy),
                  new Button(EditCommandID.Paste, EditCommands.Paste),
                  new Button(EditCommandID.Cut, EditCommands.Cut),
                  new Button(LayoutCommandID.StackUndo, LayoutCommands.StackUndo),
                  new Button(LayoutCommandID.StackRedo, LayoutCommands.StackRedo),
                }
              },
              new TabGroup("LAYOUT_Insert", "Insert"){
                Controls = new Button[]
                {
                  new Button(1719, LayoutCommands.AddBrowserFrame),
                  temp,
                  new Button(LayoutCommandID.AddBrowserFrame, LayoutCommands.AddBrowserFrame, ControlType.SplitButton)
                  {
                    Children = new Button[]
                    {
                      new Button(LayoutCommandID.AddBrowserFrame, LayoutCommands.AddBrowserFrame)
                    }
                  },
                  new Button(LayoutCommandID.InsertText, LayoutCommands.InsertText),
                  new Button(LayoutCommandID.InsertImage, LayoutCommands.InsertImage),
                  new Button(MapCommandID.CreateScalebar, MapCommands.CreateScalebar),
                  new Button("Insert", ControlType.DropDownButton)
                  {
                    Children = new Button[]
                    {
                      // tbd remake as myopen
                      new Button(SpatialCommandID.InsertSymbol, SpatialCommands.InsertSymbol),
                      new Button(SpatialCommandID.InsertLine, SpatialCommands.InsertLine),
                      new Button(SpatialCommandID.InsertPolyline, SpatialCommands.InsertPolyline),
                      new Button(SpatialCommandID.InsertEllipse, SpatialCommands.InsertEllipse),
                      new Button(SpatialCommandID.InsertRectangle, SpatialCommands.InsertRectangle),
                      new Button(SpatialCommandID.InsertRoundedRectangle, SpatialCommands.InsertRoundedRectangle),
                      new Button(SpatialCommandID.InsertPolygon, SpatialCommands.InsertPolygon),
                    }
                  },
                  new Button("Frames", ControlType.DropDownButton)
                  {
                    Children = new Button[]
                    {

                      new Button(LayoutCommandID.NewEmptyFrame, LayoutCommands.NewEmptyFrame),
                      new Button(LayoutCommandID.RemoveSelectedFramesContent, LayoutCommands.RemoveSelectedFramesContent),
                      new Button(LegendCommandID.RemoveFrames, LegendCommands.RemoveFrames)
                    }
                  }
                }
              },
              new TabGroup("LAYOUT_Style", "Style"){
                Controls = new Button[]
                {
                  new Button(SpatialCommandID.TextStyle, SpatialCommands.TextStyle){ IsLarge = true },
                  new Button(SpatialCommandID.LineStyle, SpatialCommands.LineStyle),
                  new Button(SpatialCommandID.RegionStyle, SpatialCommands.RegionStyle),
                  new Button(SpatialCommandID.SymbolStyle, SpatialCommands.SymbolStyle),
                }
              },
              new TabGroup("LAYOUT_5", ""){
                Controls = new Button[]
                {
                  new Button(LayoutCommandID.BringToFront, LayoutCommands.BringToFront, ControlType.DropDownButton)
                  {
                    IsLarge = true,
                    Caption = "Reorder",
                    Children = new Button[]
                    {
                      new Button(LayoutCommandID.BringToFront, LayoutCommands.BringToFront) { IsLarge = true },
                      new Button(LayoutCommandID.SendToBack, LayoutCommands.SendToBack) { IsLarge = true }
                    }
                  },
                  new Button(LayoutCommandID.TextJustifyLeft, LayoutCommands.TextJustifyLeft, ControlType.DropDownButton)
                  {
                    IsLarge = true,
                    Caption = "Alignment",
                    Children = new Button[]
                    {
                      new Button("Guides:", ControlType.RibbonMenuGroup)
                      {
                        Children = new Button[]
                        {
                          new Button(LayoutCommandID.AddVerticalGuideline, LayoutCommands.AddVerticalGuideline),
                          new Button(LayoutCommandID.AddHorizontalGuideline, LayoutCommands.AddHorizontalGuideline),
                          new Button(LayoutCommandID.DisableGuidelines, LayoutCommands.DisableGuidelines),
                          new Button(LayoutCommandID.RemoveGuidelines, LayoutCommands.RemoveGuidelines),
                          new Button(LayoutCommandID.ToggleSmartGuides, LayoutCommands.ToggleSmartGuides),
                        }
                      },
                      new Button("Grid:", ControlType.RibbonMenuGroup){
                        Children = new Button[]
                        {
                          new Button(LayoutCommandID.ToggleGridLines, LayoutCommands.ToggleGridLines),
                          new Button(LayoutCommandID.SnapToGrid, LayoutCommands.SnapToGrid),
                          new Button(GridlineCommandId.GridlinePropertiesDialog, GridlineCommands.GridlinePropertiesDialog),

                        }
                      },
                      new Button("Align Objets:", ControlType.RibbonMenuGroup)
                      {
                        Children = new Button[]
                        {
                          new Button(LayoutCommandID.TextJustifyLeft, LayoutCommands.TextJustifyLeft),
                          new Button(LayoutCommandID.TextJustifyCenter, LayoutCommands.TextJustifyCenter),
                          new Button(LayoutCommandID.TextJustifyRight, LayoutCommands.TextJustifyRight),
                        }
                      }
                    }
                  },
                  new Button(ToolCommandID.Select, ToolCommands.Select, ControlType.ToolButton){ IsLarge = true },
                  new Button(ToolCommandID.Recenter, ToolCommands.Recenter, ControlType.DropDownButton)
                  {
                    Caption = "Tools",
                    IsLarge = true,
                    Children = new Button[]
                    {
                      new Button(ToolCommandID.Recenter, ToolCommands.Recenter, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.ZoomIn, ToolCommands.ZoomIn, ControlType.ToolButton){ IsLarge = true },
                      new Button(ToolCommandID.ZoomOut, ToolCommands.ZoomOut, ControlType.ToolButton) { IsLarge = true }
                    }
                  }
                }
              }
            }
          },
          #endregion
          #region RASTER
          new Tab("Raster", "RASTER"){
            Index = 4,
            Ignore = true,
            Groups = new TabGroup[]
            {
              new TabGroup("RASTER_File", "File"){
                Controls = new Button[]
                {
                  new Button(ApplicationCommandID.OpenTable, ApplicationCommands.OpenTable, ControlType.DropDownButton){
                    Caption = "Open",
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.OpenTable, ApplicationCommands.OpenTable){ IsLarge = true },
                      new Button(ApplicationCommandID.OpenWorkspace, ApplicationCommands.OpenWorkspace){ IsLarge =  true },
                      new Button(ApplicationCommandID.AddWorkspace, ApplicationCommands.AddWorkspace){ IsLarge = true },

                    }
                  }
                }
              },
              new TabGroup("RASTER_Properties", "Properties"){
                Controls = new Button[]
                {

                }
              },
              new TabGroup("RASTER_Interpolate", "Interpolate"){
                Controls = new Button[]
                {

                }
              },
              new TabGroup("RASTER_4", ""){
                Controls = new Button[]
                {

                }
              },
              new TabGroup("RASTER_Operations", "Operations"){
                Controls = new Button[]
                {

                }
              },
            }
          }
	        #endregion
          ,
          new Tab("Old", "Patogūs"){
            Index = 5,
            Ignore = false,
            Groups = new TabGroup[]
            {
              new TabGroup("OLD_Main", "Main")
              {
                Controls = new Button[]
                {
                  new Button(ToolCommandID.Select, ToolCommands.Select){ Caption = "" },
                  new Button(ToolCommandID.SearchRect, ToolCommands.SearchRect){ Caption = "" },
                  new Button(ToolCommandID.SearchRadius, ToolCommands.SearchRadius){ Caption = "" },
                  new Button(ToolCommandID.SearchPolygon, ToolCommands.SearchPolygon){ Caption = "" },
                  new Button(ToolCommandID.SearchBoundary, ToolCommands.SearchBoundary){ Caption = "" },
                  new Button(BrowseCommandsID.UnselectAll, BrowseCommands.UnselectAll){ Caption = "" },
                  new Button(QueryCommandID.InvertSelect, QueryCommands.InvertSelect){ Caption = "" },
                  // new Button(QueryCommandID.InvertSelect, QueryCommands.InvertSelect), // graphselect
                  new Button(ToolCommandID.Recenter, ToolCommands.Recenter, ControlType.ToolButton){ Caption = "" },
                  new Button(ToolCommandID.ZoomIn, ToolCommands.ZoomIn, ControlType.ToolButton){ Caption = "" },
                  new Button(ToolCommandID.ZoomOut, ToolCommands.ZoomOut, ControlType.ToolButton){ Caption = "" },
                  new Button(MapCommandID.ChangeView, MapCommands.ChangeView){ Caption = "" },
                  // new Button(, ),// grab
                  new Button(ToolCommandID.PointQuery, ToolCommands.PointQuery){ Caption = "" }, // All Controls
                  new Button(ToolCommandID.HotLink, ToolCommands.HotLink){ Caption = "" },
                  new Button(ToolCommandID.LabelTool, ToolCommands.LabelTool){ Caption = "" },
                  new Button(MapCommandID.DragMap, MapCommands.DragMap){ Caption = "" },
                  //new Button(WindowCommandID.LayerControl, WindowCommands.LayerControl){ Caption = "" }, // "Layer Control"
                  new Button(WindowCommandID.WorkspaceExplorer, WindowCommands.WorkspaceExplorer){ Caption = "" },
                  new Button(WindowCommandID.RulerWindow, WindowCommands.RulerWindow){ Caption = "" }, // "Ruler"
                  new Button(WindowCommandID.LegendWindow, WindowCommands.LegendWindow){ Caption = "" }, // "Show/Hide Legend"
                  new Button(WindowCommandID.StatisticsWindow, WindowCommands.StatisticsWindow){ Caption = "" }, // "Show/Hide Statistics"
                  new Button(RedistrictCommandID.Target, RedistrictCommands.Target){ Caption = "" }, // "Set Target District"
                  new Button(RedistrictCommandID.Assign, RedistrictCommands.Assign){ Caption = "" }, // "Assign Selected Objects"
                  new Button(MapCommandID.ClipRegionOnOff, MapCommands.ClipRegionOnOff){ Caption = "" }, // "Clip Region On/Off"
                  new Button(MapCommandID.SetClipRegion, MapCommands.SetClipRegion){ Caption = "" } // "Set Clip Region"
                }
              },
              new TabGroup("OLD_Drawing", "Drawing")
              {
                Controls = new Button[]
                {
                  //new Button(){ Caption = "" }, // "Symbol"
                  new Button(SpatialCommandID.InsertLine, SpatialCommands.InsertLine) { Caption = "" }, // "Line"
                  new Button(SpatialCommandID.InsertPolyline, SpatialCommands.InsertPolyline){ Caption = "" }, // "Polyline"
                  new Button(SpatialCommandID.InsertArc, SpatialCommands.InsertArc){ Caption = "" }, // "Arc"
                  new Button(SpatialCommandID.InsertPolygon, SpatialCommands.InsertPolygon){ Caption = "" }, // "Polygon"
                  new Button(SpatialCommandID.InsertEllipse, SpatialCommands.InsertEllipse){ Caption = "" }, // "Ellipse"
                  new Button(SpatialCommandID.InsertRectangle, SpatialCommands.InsertRectangle){ Caption = "" }, // "Rectangle"
                  new Button(SpatialCommandID.InsertRoundedRectangle, SpatialCommands.InsertRoundedRectangle){ Caption = "" }, // "Rounded Rectangle"
                  new Button(SpatialCommandID.InsertText, SpatialCommands.InsertText){ Caption = "" }, // All Controls
                  //new Button(){ Caption = "" }, // "Frame"
                  new Button(SpatialCommandID.Reshape, SpatialCommands.Reshape){ Caption = "" }, // "Reshape"
                  new Button(ToolCommandID.AddNode, ToolCommands.AddNode){ Caption = "" }, // "Add Node"
                  new Button(SpatialCommandID.LineStyle, SpatialCommands.LineStyle){ Caption = "" }, // All Controls
                  new Button(SpatialCommandID.RegionStyle, SpatialCommands.RegionStyle){ Caption = "" }, // All Controls
                  new Button(SpatialCommandID.InsertSymbol, SpatialCommands.InsertSymbol){ Caption = "" }, // All Controls
                  new Button(SpatialCommandID.SymbolStyle, SpatialCommands.SymbolStyle){ Caption = "" }, // All Controls
                  new Button(SpatialCommandID.TextStyle, SpatialCommands.TextStyle){ Caption = "" }, // All Controls
                }
              },
              new TabGroup("OLD_OTHER", "Other")
              {
                Controls = new Button[]
                {
                  new Button(EditCommandID.Undo, EditCommands.Undo){ Caption = "Undo" },
                  new Button(QueryCommandID.UnSelect, QueryCommands.UnSelect)
                }
              }
            }
          }
        };
      Backstage = new Button[]
      {
        new Button("Nustatymai", ControlType.BackStageTabItem)
          {
            Index = 0,
            Children = new Button[]
            {
              new Button("Options", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("Preferences", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(PreferenceCommandID.Preferences, PreferenceCommands.Preferences),
                      //new Button(PreferenceCommandID.SystemPreferences, PreferenceCommands.SystemPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.StartUpPreferences, PreferenceCommands.StartUpPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.MapPreferences, PreferenceCommands.MapPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.CountryPreferences, PreferenceCommands.CountryPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.PathPreferences, PreferenceCommands.PathPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.LegendPreferences, PreferenceCommands.LegendPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.OutputPreferences, PreferenceCommands.OutputPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.PrinterPreferences, PreferenceCommands.PrinterPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.StylesPreferences, PreferenceCommands.StylesPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.ProcImagePreferences, PreferenceCommands.ProcImagePreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.WebservicesPreferences, PreferenceCommands.WebservicesPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.LayoutPreferences, PreferenceCommands.LayoutPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.BrowserPreferences, PreferenceCommands.BrowserPreferences), // Yra Preferences skilyje
                      new Button(PreferenceCommandID.NotificationsPreferences, PreferenceCommands.NotificationsPreferences),
                      //new Button(PreferenceCommandID.PerformancePreferences, PreferenceCommands.PerformancePreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.WorkspacePreferences, PreferenceCommands.WorkspacePreferences), // Yra Preferences skilyje
                      // new Button(PreferenceCommandID.MapBasicWindowPreferences, PreferenceCommands.MapBasicWindowPreferences),  // Yra Preferences skilyje // Nereikalingas runtime versijai
                      //new Button(PreferenceCommandID.ExplorerPreferences, PreferenceCommands.ExplorerPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.WindowStatePreferences, PreferenceCommands.WindowStatePreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.TaskManagerPreferences, PreferenceCommands.TaskManagerPreferences), // Yra Preferences skilyje
                      //new Button(PreferenceCommandID.WindowListPreferences, PreferenceCommands.WindowListPreferences),  // Yra Preferences skilyje
                    }
                  }
                }
              },
              new Button("Licencijavimas", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("Preferences", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(HelpCommandID.About, HelpCommands.About), // 
                      new Button(HelpCommandID.TransferLicense, HelpCommands.TransferLicense), //
                      new Button(HelpCommandID.ActivateFlexeraLicenseForSubscriptionLicensedUser, HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUser), //
                    }
                  }
                }
              }
            }
          },
          new Button("WindowList, Window, TableList, Table", ControlType.BackStageTabItem)
          {
            Index = 3,
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]{
              new Button("WindowListCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(WindowListCommandID.SelectAllOfType, WindowListCommands.SelectAllOfType), // All Controls
                      new Button(WindowListCommandID.HideSelectedWindow, WindowListCommands.HideSelectedWindow), // All Controls
                      new Button(WindowListCommandID.ActivateSelectedWindow, WindowListCommands.ActivateSelectedWindow), // All Controls
                      new Button(WindowListCommandID.CloseSelectedWindow, WindowListCommands.CloseSelectedWindow), // All Controls
                      new Button(WindowListCommandID.RenameSelectedWindow, WindowListCommands.RenameSelectedWindow), // All Controls
                      new Button(WindowListCommandID.CloneSelectedWindow, WindowListCommands.CloneSelectedWindow), // All Controls
                    }
                  }
                }
              },
              new Button("WindowCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(WindowCommandID.NewBrowserWindow, WindowCommands.NewBrowserWindow), // All Controls
                      new Button(WindowCommandID.NewMapWindow, WindowCommands.NewMapWindow), // All Controls
                      new Button(WindowCommandID.GraphWindow, noWarnings: true), // All Controls // No Command
                      new Button(WindowCommandID.MapBasicWindow, WindowCommands.MapBasicWindow), // All Controls
                      new Button(WindowCommandID.RedrawWindow, WindowCommands.RedrawWindow), // All Controls
                      new Button(WindowCommandID.RedistrictWindow, WindowCommands.RedistrictWindow), // All Controls
                      new Button(WindowCommandID.StatusBarWindow, WindowCommands.StatusBarWindow), // All Controls
                      new Button(WindowCommandID.CustomColors, WindowCommands.CustomColors), // All Controls
                      new Button(WindowCommandID.RecoverWindows, WindowCommands.RecoverWindows), // All Controls
                      new Button(WindowCommandID.NewLayoutWindow, WindowCommands.NewLayoutWindow), // All Controls
                      new Button(WindowCommandID.ClearMsgWin, WindowCommands.ClearMsgWin), // All Controls
                      new Button(WindowCommandID.CloneWindow, WindowCommands.CloneWindow), // All Controls
                      new Button(WindowCommandID.ThreeDWindow, WindowCommands.ThreeDWindow), // All Controls
                      new Button(WindowCommandID.PrismWindow, WindowCommands.PrismWindow), // All Controls
                      new Button(WindowCommandID.LayerControl, WindowCommands.LayerControl), // All Controls
                      new Button(WindowCommandID.WorkspaceExplorer, WindowCommands.WorkspaceExplorer), // All Controls
                      new Button(WindowCommandID.WindowList, WindowCommands.WindowList), // All Controls
                      new Button(WindowCommandID.ToolManager, WindowCommands.ToolManager), // All Controls
                      new Button(WindowCommandID.TaskManager, WindowCommands.TaskManager), // All Controls
                      new Button(WindowCommandID.ConnectionList, WindowCommands.ConnectionList), // All Controls
                      new Button(WindowCommandID.InfoWindow, WindowCommands.InfoWindow), // All Controls
                      new Button(WindowCommandID.MessageWindow, WindowCommands.MessageWindow), // All Controls
                      new Button(WindowCommandID.StatisticsWindow, WindowCommands.StatisticsWindow), // All Controls
                      new Button(WindowCommandID.RulerWindow, WindowCommands.RulerWindow), // All Controls
                      new Button(WindowCommandID.LegendWindow, WindowCommands.LegendWindow), // All Controls
                      new Button(WindowCommandID.TableList, WindowCommands.TableList), // All Controls
                      new Button(WindowCommandID.StatisticsWindowCopy, WindowCommands.StatisticsWindowCopy), // All Controls
                    }
                  }
                }
              },
              new Button("TableListCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(TableListCommandID.TlvSelectAllFromTable, TableListCommands.TlvSelectAllFromTable), // All Controls
                      new Button(TableListCommandID.TlvBrowseTable, TableListCommands.TlvBrowseTable), // All Controls
                      new Button(TableListCommandID.TlvOpenNewMap, TableListCommands.TlvOpenNewMap), // All Controls
                      new Button(TableListCommandID.TlvExportTable, TableListCommands.TlvExportTable), // All Controls
                      new Button(TableListCommandID.TlvRefreshTable, TableListCommands.TlvRefreshTable), // All Controls
                      new Button(TableListCommandID.TlvTableStructure, TableListCommands.TlvTableStructure), // All Controls
                      new Button(TableListCommandID.TlvCreatePoints, TableListCommands.TlvCreatePoints), // All Controls
                      new Button(TableListCommandID.TlvUpdateColumn, TableListCommands.TlvUpdateColumn), // All Controls
                      new Button(TableListCommandID.TlvCloseTable, TableListCommands.TlvCloseTable), // All Controls
                      new Button(TableListCommandID.TlvViewMetaData, TableListCommands.TlvViewMetaData), // All Controls
                      new Button(TableListCommandID.TlvAddToLibrary, TableListCommands.TlvAddToLibrary), // All Controls
                      new Button(TableListCommandID.TlvCompareStructure, TableListCommands.TlvCompareStructure), // All Controls
                      new Button(TableListCommandID.TlvRenameTable, TableListCommands.TlvRenameTable), // All Controls
                    }
                  }
                }
              },
              new Button("TableCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(TableCommandID.RevertTable, TableCommands.RevertTable), // All Controls
                      new Button(TableCommandID.CalcColStats, TableCommands.CalcColStats), // All Controls
                      new Button(TableCommandID.Import), // All Controls // No Command
                      new Button(TableCommandID.Export, TableCommands.Export), // All Controls
                      new Button(TableCommandID.Pack, TableCommands.Pack), // All Controls
                      new Button(TableCommandID.ModifyStructure, TableCommands.ModifyStructure), // All Controls
                      new Button(TableCommandID.UpdateColumn, TableCommands.UpdateColumn), // All Controls
                      new Button(TableCommandID.MergeUsingColumn, TableCommands.MergeUsingColumn), // All Controls
                      new Button(TableCommandID.GeoCode, TableCommands.GeoCode), // All Controls
                      new Button(TableCommandID.CreatePoints, TableCommands.CreatePoints), // All Controls
                      new Button(TableCommandID.Delete, TableCommands.Delete), // All Controls
                      new Button(TableCommandID.Rename, TableCommands.Rename), // All Controls
                      new Button(TableCommandID.Append, TableCommands.Append), // All Controls
                      new Button(TableCommandID.RasterReg, TableCommands.RasterReg), // All Controls
                      new Button(TableCommandID.RasterStyle, TableCommands.RasterStyle), // All Controls
                      new Button(TableCommandID.MakeMappable, TableCommands.MakeMappable), // All Controls
                      new Button(TableCommandID.Unlink, TableCommands.Unlink), // All Controls
                      new Button(TableCommandID.RefreshDBMS, TableCommands.RefreshDBMS), // All Controls
                      new Button(TableCommandID.ChangeSymbol, TableCommands.ChangeSymbol), // All Controls
                      new Button(TableCommandID.Buffer, TableCommands.Buffer), // All Controls
                      new Button(TableCommandID.WebGeoCode, TableCommands.WebGeoCode), // All Controls
                      new Button(TableCommandID.UniversalDataRefresh, TableCommands.UniversalDataRefresh), // All Controls
                      new Button(TableCommandID.HotlinkOptions, TableCommands.HotlinkOptions), // All Controls
                      new Button(TableCommandID.AddToLibrary, TableCommands.AddToLibrary), // All Controls
                      new Button(TableCommandID.ViewEditMetadata, TableCommands.ViewEditMetadata), // All Controls
                      new Button(TableCommandID.OpenDBMSTable, TableCommands.OpenDBMSTable), // All Controls
                      new Button(TableCommandID.CloseDBMSTable, TableCommands.CloseDBMSTable), // All Controls
                      new Button(TableCommandID.CloseDBMSConnection, TableCommands.CloseDBMSConnection), // All Controls
                    }
                  }
                }
              },
            }
          },
          new Button("Preferences, Help, Oracle, WebService", ControlType.BackStageTabItem)
          {
            Index = 3,
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]
            {
              new Button("PreferenceCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(PreferenceCommandID.Preferences, PreferenceCommands.Preferences), // All Controls
                      new Button(PreferenceCommandID.SystemPreferences, PreferenceCommands.SystemPreferences), // All Controls
                      new Button(PreferenceCommandID.StartUpPreferences, PreferenceCommands.StartUpPreferences), // All Controls
                      new Button(PreferenceCommandID.MapPreferences, PreferenceCommands.MapPreferences), // All Controls
                      new Button(PreferenceCommandID.CountryPreferences, PreferenceCommands.CountryPreferences), // All Controls
                      new Button(PreferenceCommandID.PathPreferences, PreferenceCommands.PathPreferences), // All Controls
                      new Button(PreferenceCommandID.LegendPreferences, PreferenceCommands.LegendPreferences), // All Controls
                      new Button(PreferenceCommandID.OutputPreferences, PreferenceCommands.OutputPreferences), // All Controls
                      new Button(PreferenceCommandID.PrinterPreferences, PreferenceCommands.PrinterPreferences), // All Controls
                      new Button(PreferenceCommandID.StylesPreferences, PreferenceCommands.StylesPreferences), // All Controls
                      new Button(PreferenceCommandID.ProcImagePreferences, PreferenceCommands.ProcImagePreferences), // All Controls
                      new Button(PreferenceCommandID.WebservicesPreferences, PreferenceCommands.WebservicesPreferences), // All Controls
                      new Button(PreferenceCommandID.LayoutPreferences, PreferenceCommands.LayoutPreferences), // All Controls
                      new Button(PreferenceCommandID.BrowserPreferences, PreferenceCommands.BrowserPreferences), // All Controls
                      new Button(PreferenceCommandID.NotificationsPreferences, PreferenceCommands.NotificationsPreferences), // All Controls
                      new Button(PreferenceCommandID.PerformancePreferences, PreferenceCommands.PerformancePreferences), // All Controls
                      new Button(PreferenceCommandID.WorkspacePreferences, PreferenceCommands.WorkspacePreferences), // All Controls
                      new Button(PreferenceCommandID.MapBasicWindowPreferences, PreferenceCommands.MapBasicWindowPreferences), // All Controls
                      new Button(PreferenceCommandID.ExplorerPreferences, PreferenceCommands.ExplorerPreferences), // All Controls
                      new Button(PreferenceCommandID.WindowStatePreferences, PreferenceCommands.WindowStatePreferences), // All Controls
                      new Button(PreferenceCommandID.TaskManagerPreferences, PreferenceCommands.TaskManagerPreferences), // All Controls
                      new Button(PreferenceCommandID.WindowListPreferences, PreferenceCommands.WindowListPreferences), // All Controls
                    }
                  }
                }
              },
              new Button("HelpCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(HelpCommandID.HelpContents, HelpCommands.HelpContents), // All Controls
                      new Button(HelpCommandID.HelpSearch, HelpCommands.HelpSearch), // All Controls
                      new Button(HelpCommandID.About, HelpCommands.About), // All Controls
                      new Button(HelpCommandID.DoHelpMode, noWarnings: true), // All Controls // No Command
                      new Button(HelpCommandID.DoContextHelpMode, noWarnings: true), // All Controls // No Command
                      new Button(HelpCommandID.TechSupport, HelpCommands.TechSupport), // All Controls
                      new Button(HelpCommandID.MapInfoWwwStoreEuro, HelpCommands.MapInfoWwwStoreEuro), // All Controls
                      new Button(HelpCommandID.MapInfoWww, HelpCommands.MapInfoWww), // All Controls
                      new Button(HelpCommandID.MapInfoWwwStore, HelpCommands.MapInfoWwwStore), // All Controls
                      new Button(HelpCommandID.SmartUpdate, HelpCommands.SmartUpdate), // All Controls
                      new Button(HelpCommandID.WwwTutorial, HelpCommands.WwwTutorial), // All Controls
                      new Button(HelpCommandID.TransferLicense, HelpCommands.TransferLicense), // All Controls
                      new Button(HelpCommandID.BorrowLicense, HelpCommands.BorrowLicense), // All Controls
                      new Button(HelpCommandID.ReturnBorrowedLicense, HelpCommands.ReturnBorrowedLicense), // All Controls
                      new Button(HelpCommandID.ProductFeedback, HelpCommands.ProductFeedback), // All Controls
                      new Button(HelpCommandID.BingTermsOfUse, HelpCommands.BingTermsOfUse), // All Controls
                      new Button(HelpCommandID.MapInfoNewsfeed, HelpCommands.MapInfoNewsfeed), // All Controls
                      new Button(HelpCommandID.UserBingKey, HelpCommands.UserBingKey), // All Controls
                      new Button(HelpCommandID.StartAdvancedEvaluation, HelpCommands.StartAdvancedEvaluation), // All Controls
                      new Button(HelpCommandID.ActivateAdvancedLicense, HelpCommands.ActivateAdvancedLicense), // All Controls
                      new Button(HelpCommandID.ActivateFlexeraLicenseForSubscriptionLicensedUser, HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUser), // All Controls
                    }
                  }
                }
              },
              new Button("OracleWorkspaceCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(OracleWorkspaceCommandID.CreateWorkspace, OracleWorkspaceCommands.CreateWorkspace), // All Controls
                      new Button(OracleWorkspaceCommandID.DeleteWorkspace, OracleWorkspaceCommands.DeleteWorkspace), // All Controls
                      new Button(OracleWorkspaceCommandID.EnableOracleVersioning, OracleWorkspaceCommands.EnableOracleVersioning), // All Controls
                      new Button(OracleWorkspaceCommandID.DisableOracleVersioning, OracleWorkspaceCommands.DisableOracleVersioning), // All Controls
                      new Button(OracleWorkspaceCommandID.MergeTable, OracleWorkspaceCommands.MergeTable), // All Controls
                      new Button(OracleWorkspaceCommandID.RefreshOracleTable, OracleWorkspaceCommands.RefreshOracleTable), // All Controls
                    }
                  }
                }
              },
              new Button("WebServicesCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(WebServicesCommandID.OpenWms, WebServicesCommands.OpenWms), // All Controls
                      new Button(WebServicesCommandID.OpenWfs, WebServicesCommands.OpenWfs), // All Controls
                      new Button(WebServicesCommandID.OpenWmts, WebServicesCommands.OpenWmts), // All Controls
                      new Button(WebServicesCommandID.ServerList, noWarnings: true), // All Controls // No Command
                      new Button(WebServicesCommandID.WmsProps, WebServicesCommands.WmsProps), // All Controls
                      new Button(WebServicesCommandID.WfsRefresh, WebServicesCommands.WfsRefresh), // All Controls
                      new Button(WebServicesCommandID.WfsProps, WebServicesCommands.WfsProps), // All Controls
                      new Button(WebServicesCommandID.WmtsProps, WebServicesCommands.WmtsProps), // All Controls
                    }
                  }
                }
              },
            }
          },
          new Button("Layout, Legend, Layer", ControlType.BackStageTabItem)
          {
            Index = 3,
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]
            {
              new Button("LayoutCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LayoutCommandID.RegionStyle, LayoutCommands.RegionStyle), // All Controls
                      new Button(LayoutCommandID.LayoutPageSetup, LayoutCommands.LayoutPageSetup), // All Controls
                      new Button(LayoutCommandID.FitInWindow, LayoutCommands.FitInWindow), // All Controls
                      new Button(LayoutCommandID.ActivateLayoutFrame, LayoutCommands.ActivateLayoutFrame), // All Controls
                      new Button(LayoutCommandID.BringToFront, LayoutCommands.BringToFront), // All Controls
                      new Button(LayoutCommandID.SendToBack, LayoutCommands.SendToBack), // All Controls
                      new Button(LayoutCommandID.FrameProperties, LayoutCommands.FrameProperties), // All Controls
                      new Button(LayoutCommandID.LayoutTextStyle, LayoutCommands.LayoutTextStyle), // All Controls
                      new Button(LayoutCommandID.AddLegends, LayoutCommands.AddLegends), // All Controls
                      new Button(LayoutCommandID.RefreshLegends, LayoutCommands.RefreshLegends), // All Controls
                      new Button(LayoutCommandID.ModifyThematic, LayoutCommands.ModifyThematic), // All Controls // No Command
                      new Button(LayoutCommandID.RemoveSelectedFramesContent, LayoutCommands.RemoveSelectedFramesContent), // All Controls
                      new Button(LayoutCommandID.NewEmptyFrame, LayoutCommands.NewEmptyFrame), // All Controls
                      new Button(LayoutCommandID.RemoveSelectedItems, LayoutCommands.RemoveSelectedItems), // All Controls
                      new Button(LayoutCommandID.StackUndo, LayoutCommands.StackUndo), // All Controls
                      new Button(LayoutCommandID.StackRedo, LayoutCommands.StackRedo), // All Controls
                      new Button(LayoutCommandID.AddBrowserFrame, LayoutCommands.AddBrowserFrame), // All Controls
                      new Button(LayoutCommandID.AddHorizontalGuideline, LayoutCommands.AddHorizontalGuideline), // All Controls
                      new Button(LayoutCommandID.AddMapFrame, LayoutCommands.AddMapFrame), // All Controls
                      new Button(LayoutCommandID.AddSymbol, LayoutCommands.AddSymbol), // All Controls
                      new Button(LayoutCommandID.AddLine, LayoutCommands.AddLine), // All Controls
                      new Button(LayoutCommandID.AddEllipse, LayoutCommands.AddEllipse), // All Controls
                      new Button(LayoutCommandID.AddRectangle, LayoutCommands.AddRectangle), // All Controls
                      new Button(LayoutCommandID.AddRoundedRectangle, LayoutCommands.AddRoundedRectangle), // All Controls
                      new Button(LayoutCommandID.AddVerticalGuideline, LayoutCommands.AddVerticalGuideline), // All Controls
                      new Button(LayoutCommandID.ChangeFrameStyle, LayoutCommands.ChangeFrameStyle), // All Controls
                      new Button(LayoutCommandID.DisableGuidelines, LayoutCommands.DisableGuidelines), // All Controls
                      new Button(LayoutCommandID.ZoomToHundredPercent, LayoutCommands.ZoomToHundredPercent), // All Controls
                      new Button(LayoutCommandID.ToggleSmartGuides, LayoutCommands.ToggleSmartGuides), // All Controls
                      new Button(LayoutCommandID.InsertImage, LayoutCommands.InsertImage), // All Controls
                      new Button(LayoutCommandID.InsertText, LayoutCommands.InsertText), // All Controls
                      new Button(LayoutCommandID.LineSpacingDouble, LayoutCommands.LineSpacingDouble), // All Controls
                      new Button(LayoutCommandID.LineSpacingOnePointFive, LayoutCommands.LineSpacingOnePointFive), // All Controls
                      new Button(LayoutCommandID.LineSpacingSingle, LayoutCommands.LineSpacingSingle), // All Controls
                      new Button(LayoutCommandID.LineStyle, LayoutCommands.LineStyle), // All Controls
                      new Button(LayoutCommandID.SymbolStyle, LayoutCommands.SymbolStyle), // All Controls
                      new Button(LayoutCommandID.Pan, LayoutCommands.Pan), // All Controls
                      new Button(LayoutCommandID.RemoveGuidelines, LayoutCommands.RemoveGuidelines), // All Controls
                      new Button(LayoutCommandID.Select, LayoutCommands.Select), // All Controls
                      new Button(LayoutCommandID.SnapToBottom, LayoutCommands.SnapToBottom), // All Controls
                      new Button(LayoutCommandID.SnapToGrid, LayoutCommands.SnapToGrid), // All Controls
                      new Button(LayoutCommandID.SnapToLeft, LayoutCommands.SnapToLeft), // All Controls
                      new Button(LayoutCommandID.SnapToRight, LayoutCommands.SnapToRight), // All Controls
                      new Button(LayoutCommandID.SnapToTop, LayoutCommands.SnapToTop), // All Controls
                      new Button(LayoutCommandID.TextJustifyCenter, LayoutCommands.TextJustifyCenter), // All Controls
                      new Button(LayoutCommandID.TextJustifyLeft, LayoutCommands.TextJustifyLeft), // All Controls
                      new Button(LayoutCommandID.TextJustifyRight, LayoutCommands.TextJustifyRight), // All Controls
                      new Button(LayoutCommandID.ToggleGridLines, LayoutCommands.ToggleGridLines), // All Controls
                      new Button(LayoutCommandID.ZoomIn, LayoutCommands.ZoomIn), // All Controls
                      new Button(LayoutCommandID.ZoomOut, LayoutCommands.ZoomOut), // All Controls
                      new Button(LayoutCommandID.AlignHorizontalCenter, LayoutCommands.AlignHorizontalCenter), // All Controls
                      new Button(LayoutCommandID.AlignVerticalCenter, LayoutCommands.AlignVerticalCenter), // All Controls
                      new Button(LayoutCommandID.RotateFrameByZeroDegree, LayoutCommands.RotateFrameByZeroDegree), // All Controls
                      new Button(LayoutCommandID.RotateFrameByNinetyDegree, LayoutCommands.RotateFrameByNinetyDegree), // All Controls
                      new Button(LayoutCommandID.RotateFrameByTwoSeventyDegree, LayoutCommands.RotateFrameByTwoSeventyDegree), // All Controls
                      new Button(LayoutCommandID.AddPolygon, LayoutCommands.AddPolygon), // All Controls
                      new Button(LayoutCommandID.AddPolyline, LayoutCommands.AddPolyline), // All Controls
                    }
                  }
                }
              },
              new Button("LegendCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LegendCommandID.DisableGuidelines, LegendCommands.DisableGuidelines), // All Controls
                      new Button(LegendCommandID.RemoveGuidelines, LegendCommands.RemoveGuidelines), // All Controls
                      new Button(LegendCommandID.RemoveFrames, LegendCommands.RemoveFrames), // All Controls
                      new Button(LegendCommandID.FrameProperties, LegendCommands.FrameProperties), // All Controls
                      new Button(LegendCommandID.RefreshAll, LegendCommands.RefreshAll), // All Controls
                      new Button(LegendCommandID.AddFrames, LegendCommands.AddFrames), // All Controls
                      new Button(LegendCommandID.AddTextFrame, LegendCommands.AddTextFrame), // All Controls
                      new Button(LegendCommandID.ModifyTheme, LegendCommands.ModifyTheme), // All Controls
                      new Button(LegendCommandID.ToggleGridLines, LegendCommands.ToggleGridLines), // All Controls
                      new Button(LegendCommandID.SnapToGrid, LegendCommands.SnapToGrid), // All Controls
                      new Button(LegendCommandID.AddHorizontalGuideline, LegendCommands.AddHorizontalGuideline), // All Controls
                      new Button(LegendCommandID.AddVerticalGuideline, LegendCommands.AddVerticalGuideline), // All Controls
                      new Button(LegendCommandID.SnapToTopGuideline, LegendCommands.SnapToTopGuideline), // All Controls
                      new Button(LegendCommandID.SnapToBottomGuideline, LegendCommands.SnapToBottomGuideline), // All Controls
                      new Button(LegendCommandID.SnapToLeftGuideline, LegendCommands.SnapToLeftGuideline), // All Controls
                      new Button(LegendCommandID.SnapToRightGuideline, LegendCommands.SnapToRightGuideline), // All Controls
                      new Button(LegendCommandID.QuickRefresh, LegendCommands.QuickRefresh), // All Controls
                    }
                  }
                }
              },
              new Button("LayerControlCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LayerControlCommandID.LcViewEntireLayer, LayerControlCommands.LcViewEntireLayer), // All Controls
                      new Button(LayerControlCommandID.LcLayerProperties, LayerControlCommands.LcLayerProperties), // All Controls
                      new Button(LayerControlCommandID.LcLabelFont, LayerControlCommands.LcLabelFont), // All Controls
                      new Button(LayerControlCommandID.LcOtherNoSelect, LayerControlCommands.LcOtherNoSelect), // All Controls
                      new Button(LayerControlCommandID.LcRenameMap, LayerControlCommands.LcRenameMap), // All Controls
                      new Button(LayerControlCommandID.LcMapOptions, LayerControlCommands.LcMapOptions), // All Controls
                      new Button(LayerControlCommandID.LcAddGroup, LayerControlCommands.LcAddGroup), // All Controls
                      new Button(LayerControlCommandID.LcRenameGroup, LayerControlCommands.LcRenameGroup), // All Controls
                      new Button(LayerControlCommandID.LcUnGroup, LayerControlCommands.LcUnGroup), // All Controls
                      new Button(LayerControlCommandID.AddLayers, LayerControlCommands.AddLayers), // All Controls
                      new Button(LayerControlCommandID.LcAddDisplayOverride, LayerControlCommands.LcAddDisplayOverride), // All Controls
                      new Button(LayerControlCommandID.LcAddLabelOverride, LayerControlCommands.LcAddLabelOverride), // All Controls
                      new Button(LayerControlCommandID.LcDisplayOverrideProperties, LayerControlCommands.LcDisplayOverrideProperties), // All Controls
                      new Button(LayerControlCommandID.LcLabelOverrideProperties, LayerControlCommands.LcLabelOverrideProperties), // All Controls
                      new Button(LayerControlCommandID.LcSplitOverride, LayerControlCommands.LcSplitOverride), // All Controls
                      new Button(LayerControlCommandID.LcRemoveOverride, LayerControlCommands.LcRemoveOverride), // All Controls
                      new Button(LayerControlCommandID.LcBrowseTable, LayerControlCommands.LcBrowseTable), // All Controls
                      new Button(LayerControlCommandID.LcZoomToTileServer, LayerControlCommands.LcZoomToTileServer), // All Controls
                      new Button(LayerControlCommandID.LcClearCustomLabels, LayerControlCommands.LcClearCustomLabels), // All Controls
                      new Button(LayerControlCommandID.LabelPriority, LayerControlCommands.LabelPriority), // All Controls
                      new Button(LayerControlCommandID.LcSelectAll, LayerControlCommands.LcSelectAll), // All Controls
                      new Button(LayerControlCommandID.LayerControlOptions, LayerControlCommands.LayerControlOptions), // All Controls
                      new Button(LayerControlCommandID.RegionStyle, LayerControlCommands.RegionStyle), // All Controls
                      new Button(LayerControlCommandID.RegionStyleStacked, LayerControlCommands.RegionStyleStacked), // All Controls
                      new Button(LayerControlCommandID.ToggleStyleOverride, LayerControlCommands.ToggleStyleOverride), // All Controls
                      new Button(LayerControlCommandID.LineStyle, LayerControlCommands.LineStyle), // All Controls
                      new Button(LayerControlCommandID.SymbolStyle, LayerControlCommands.SymbolStyle), // All Controls
                      new Button(LayerControlCommandID.LineStyleStacked, LayerControlCommands.LineStyleStacked), // All Controls
                      new Button(LayerControlCommandID.SymbolStyleStacked, LayerControlCommands.SymbolStyleStacked), // All Controls
                      new Button(LayerControlCommandID.ShowNodes, LayerControlCommands.ShowNodes), // All Controls
                      new Button(LayerControlCommandID.ShowCentroids, LayerControlCommands.ShowCentroids), // All Controls
                      new Button(LayerControlCommandID.ShowLineDirection, LayerControlCommands.ShowLineDirection), // All Controls
                      new Button(LayerControlCommandID.TextStyle, LayerControlCommands.TextStyle), // All Controls
                      new Button(LayerControlCommandID.ToggleStackedStyle, LayerControlCommands.ToggleStackedStyle), // All Controls
                      new Button(LayerControlCommandID.ToggleImageGrayScale, LayerControlCommands.ToggleImageGrayScale), // All Controls
                      new Button(LayerControlCommandID.LabelDisplayProps, LayerControlCommands.LabelDisplayProps), // All Controls
                      new Button(LayerControlCommandID.LabelRulesProps, LayerControlCommands.LabelRulesProps), // All Controls
                      new Button(LayerControlCommandID.LabelLineStyle, LayerControlCommands.LabelLineStyle), // All Controls
                      new Button(LayerControlCommandID.LcRenameToFriendlyName, LayerControlCommands.LcRenameToFriendlyName), // All Controls
                    }
                  }
                }
              },
            }
          },
          new Button("Spatial, Gridline, Theme, Redistrict", ControlType.BackStageTabItem)
          {
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]
            {
              new Button("SpatialCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(SpatialCommandID.VoronoiTable, SpatialCommands.VoronoiTable), // All Controls
                      new Button(SpatialCommandID.DriveRegionsTable, SpatialCommands.DriveRegionsTable), // All Controls
                      new Button(SpatialCommandID.LineStyle, SpatialCommands.LineStyle), // All Controls
                      new Button(SpatialCommandID.RegionStyle, SpatialCommands.RegionStyle), // All Controls
                      new Button(SpatialCommandID.SymbolStyle, SpatialCommands.SymbolStyle), // All Controls
                      new Button(SpatialCommandID.TextStyle, SpatialCommands.TextStyle), // All Controls
                      new Button(SpatialCommandID.DigitizerSetup, SpatialCommands.DigitizerSetup), // All Controls
                      new Button(SpatialCommandID.Reshape, SpatialCommands.Reshape), // All Controls
                      new Button(SpatialCommandID.Smooth, SpatialCommands.Smooth), // All Controls
                      new Button(SpatialCommandID.Unsmooth, SpatialCommands.Unsmooth), // All Controls
                      new Button(SpatialCommandID.ConvertToPolyline, SpatialCommands.ConvertToPolyline), // All Controls
                      new Button(SpatialCommandID.CombineObjects, SpatialCommands.CombineObjects), // All Controls
                      new Button(SpatialCommandID.Buffer, SpatialCommands.Buffer), // All Controls
                      new Button(SpatialCommandID.ConvertToRegion, SpatialCommands.ConvertToRegion), // All Controls
                      new Button(SpatialCommandID.SetTarget, SpatialCommands.SetTarget), // All Controls
                      new Button(SpatialCommandID.ClearTarget, SpatialCommands.ClearTarget), // All Controls
                      new Button(SpatialCommandID.SplitTarget, SpatialCommands.SplitTarget), // All Controls
                      new Button(SpatialCommandID.EraseTarget, SpatialCommands.EraseTarget), // All Controls
                      new Button(SpatialCommandID.EraseOutsideTarget, SpatialCommands.EraseOutsideTarget), // All Controls
                      new Button(SpatialCommandID.OverlayNode, SpatialCommands.OverlayNode), // All Controls
                      new Button(SpatialCommandID.ConvexHull, SpatialCommands.ConvexHull), // All Controls
                      new Button(SpatialCommandID.Enclose, SpatialCommands.Enclose), // All Controls
                      new Button(SpatialCommandID.CheckRegions, SpatialCommands.CheckRegions), // All Controls
                      new Button(SpatialCommandID.Clean, SpatialCommands.Clean), // All Controls
                      new Button(SpatialCommandID.Snap, SpatialCommands.Snap), // All Controls
                      new Button(SpatialCommandID.Disaggregate, SpatialCommands.Disaggregate), // All Controls
                      new Button(SpatialCommandID.Voronoi, SpatialCommands.Voronoi), // All Controls
                      new Button(SpatialCommandID.PolylineSplit, SpatialCommands.PolylineSplit), // All Controls
                      new Button(SpatialCommandID.OffsetObject, SpatialCommands.OffsetObject), // All Controls
                      new Button(SpatialCommandID.RotateObject, SpatialCommands.RotateObject), // All Controls
                      new Button(SpatialCommandID.PolylineSplitAtNode, SpatialCommands.PolylineSplitAtNode), // All Controls
                      new Button(SpatialCommandID.CreateDriveRegions, SpatialCommands.CreateDriveRegions), // All Controls
                      new Button(SpatialCommandID.InsertText, SpatialCommands.InsertText), // All Controls
                      new Button(SpatialCommandID.InsertSymbol, SpatialCommands.InsertSymbol), // All Controls
                      new Button(SpatialCommandID.InsertLine, SpatialCommands.InsertLine), // All Controls
                      new Button(SpatialCommandID.InsertPolyline, SpatialCommands.InsertPolyline), // All Controls
                      new Button(SpatialCommandID.InsertPolygon, SpatialCommands.InsertPolygon), // All Controls
                      new Button(SpatialCommandID.InsertEllipse, SpatialCommands.InsertEllipse), // All Controls
                      new Button(SpatialCommandID.InsertArc, SpatialCommands.InsertArc), // All Controls
                      new Button(SpatialCommandID.InsertRectangle, SpatialCommands.InsertRectangle), // All Controls
                      new Button(SpatialCommandID.InsertRoundedRectangle, SpatialCommands.InsertRoundedRectangle), // All Controls
                    }
                  }
                }
              },
              new Button("GridlineCommandId", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(GridlineCommandId.GridlineCreate, GridlineCommands.GridlineCreate, noWarnings: true), // All Controls // NoCommand
                      new Button(GridlineCommandId.GridlinePropertiesDialog, GridlineCommands.GridlinePropertiesDialog, noWarnings: true), // All Controls// No Command
                    }
                  }
                }
              },
              new Button("ThemeCommandId", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(ThemeCommandId.ThmSaveAsTemplate, ThemeCommands.ThmSaveAsTemplate, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSaveAsDefault, ThemeCommands.ThmSaveAsDefault, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRemoveDefault, ThemeCommands.ThmRemoveDefault, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRefreshData, ThemeCommands.ThmRefreshData, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeSetField, ThemeCommands.ThmRangeSetField, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeSetRanges, ThemeCommands.ThmRangeSetRanges, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeSetRoundBy, ThemeCommands.ThmRangeSetRoundBy, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeEqualCount, ThemeCommands.ThmRangeEqualCount, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeEqualRange, ThemeCommands.ThmRangeEqualRange, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeStdDev, ThemeCommands.ThmRangeStdDev, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeNaturalBreak, ThemeCommands.ThmRangeNaturalBreak, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeQuantile, ThemeCommands.ThmRangeQuantile, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmRangeCustom, ThemeCommands.ThmRangeCustom, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmCustomize, ThemeCommands.ThmCustomize, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThemeColorPaletteColorChanged, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolSetField, ThemeCommands.ThmSymbolSetField, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolMethodSquareRoot, ThemeCommands.ThmSymbolMethodSquareRoot, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolMethodConstant, ThemeCommands.ThmSymbolMethodConstant, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolMethodLog, ThemeCommands.ThmSymbolMethodLog, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolShowNegativeValueSymbol, ThemeCommands.ThmSymbolShowNegativeValueSymbol, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolSetNegativeSymbol, ThemeCommands.ThmSymbolSetNegativeSymbol, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolSetPositiveSymbol, ThemeCommands.ThmSymbolSetPositiveSymbol, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolSetSymbolSize, ThemeCommands.ThmSymbolSetSymbolSize, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmSymbolSetValueAtMax, ThemeCommands.ThmSymbolSetValueAtMax, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarStacked, ThemeCommands.ThmBarStacked, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarStackedGraduated, ThemeCommands.ThmBarStackedGraduated, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarMultiple, ThemeCommands.ThmBarMultiple, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarMultipleIndependentScale, ThemeCommands.ThmBarMultipleIndependentScale, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarHeight, ThemeCommands.ThmBarHeight, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarWidth, ThemeCommands.ThmBarWidth, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarOrientation, ThemeCommands.ThmBarOrientation, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarMethodSquareRoot, ThemeCommands.ThmBarMethodSquareRoot, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarMethodConstant, ThemeCommands.ThmBarMethodConstant, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmBarMethodLog, ThemeCommands.ThmBarMethodLog, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieWholePies, ThemeCommands.ThmPieWholePies, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieHalfPies, ThemeCommands.ThmPieHalfPies, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieGraduationSqRoot, ThemeCommands.ThmPieGraduationSqRoot, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieGraduationConstant, ThemeCommands.ThmPieGraduationConstant, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieGraduationLog, ThemeCommands.ThmPieGraduationLog, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieGraduationNone, ThemeCommands.ThmPieGraduationNone, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPiePlacement, ThemeCommands.ThmPiePlacement, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieStyles, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieSize, ThemeCommands.ThmPieSize, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmPieAngle, ThemeCommands.ThmPieAngle, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmDotDensitySetField, ThemeCommands.ThmDotDensitySetField, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmDotDensityChartTypeCircle, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmDotDensityChartTypeSquare, noWarnings: true), // All Controls
                      new Button(ThemeCommandId.ThmDotDensitySetColor, ThemeCommands.ThmDotDensitySetColor, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmDotDensitySetSize, ThemeCommands.ThmDotDensitySetSize, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmDotDensitySetMaxSizeValue, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmIndividualSetField, ThemeCommands.ThmIndividualSetField, noWarnings: true), // All Controls // No Command
                      new Button(ThemeCommandId.ThmIndividualValueColorChanged, noWarnings: true), // All Controls // No Command
                    }
                  }
                }
              },
              new Button("RedistrictCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(RedistrictCommandID.Assign, RedistrictCommands.Assign), // All Controls
                      new Button(RedistrictCommandID.Target, RedistrictCommands.Target), // All Controls
                      new Button(RedistrictCommandID.Add, RedistrictCommands.Add), // All Controls
                      new Button(RedistrictCommandID.Delete, RedistrictCommands.Delete), // All Controls
                      new Button(RedistrictCommandID.Options, RedistrictCommands.Options), // All Controls
                    }
                  }
                }
              },
            }
          },
          new Button("Application, Tool, Query, Browse, Edit, Map", ControlType.BackStageTabItem)
          {
            Index = 3,
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]
            {
              new Button("ApplicationCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.NewTable, ApplicationCommands.NewTable), // All Controls
                      new Button(ApplicationCommandID.OpenTable, ApplicationCommands.OpenTable), // All Controls
                      new Button(ApplicationCommandID.CloseTable, ApplicationCommands.CloseTable), // All Controls
                      new Button(ApplicationCommandID.CloseAll, ApplicationCommands.CloseAll), // All Controls
                      new Button(ApplicationCommandID.SaveTable, ApplicationCommands.SaveTable), // All Controls
                      new Button(ApplicationCommandID.SaveCopyAs, ApplicationCommands.SaveCopyAs), // All Controls
                      new Button(ApplicationCommandID.AddWorkspace, ApplicationCommands.AddWorkspace), // All Controls
                      new Button(ApplicationCommandID.SaveWorkspace, ApplicationCommands.SaveWorkspace), // All Controls
                      new Button(ApplicationCommandID.RunMapBasic, ApplicationCommands.RunMapBasic), // All Controls
                      new Button(ApplicationCommandID.PageSetup, ApplicationCommands.PageSetup), // All Controls
                      new Button(ApplicationCommandID.Print, ApplicationCommands.Print), // All Controls
                      new Button(ApplicationCommandID.Exit, ApplicationCommands.Exit), // All Controls
                      new Button(ApplicationCommandID.OpenDBMS, ApplicationCommands.OpenDBMS), // All Controls
                      new Button(ApplicationCommandID.SaveQuery, ApplicationCommands.SaveQuery), // All Controls
                      new Button(ApplicationCommandID.CloseDBMS, ApplicationCommands.CloseDBMS), // All Controls
                      new Button(ApplicationCommandID.OpenUniversalData, ApplicationCommands.OpenUniversalData), // All Controls
                      new Button(ApplicationCommandID.PrintToPDF, ApplicationCommands.PrintToPDF), // All Controls
                      new Button(ApplicationCommandID.OpenWorkspace, ApplicationCommands.OpenWorkspace), // All Controls
                      new Button(ApplicationCommandID.Import, ApplicationCommands.Import), // All Controls
                      new Button(ApplicationCommandID.SaveWindowAs, ApplicationCommands.SaveWindowAs), // All Controls
                      new Button(ApplicationCommandID.GetMapBasicUtilities, ApplicationCommands.GetMapBasicUtilities), // All Controls
                      new Button(ApplicationCommandID.CustomMapBasicHandler, ApplicationCommands.CustomMapBasicHandler), // All Controls
                      new Button(ApplicationCommandID.CustomToolButton, ApplicationCommands.CustomToolButton), // All Controls
                    }
                  }
                }
              },
              new Button("ToolCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(ToolCommandID.Select, ToolCommands.Select), // All Controls
                      new Button(ToolCommandID.Recenter, ToolCommands.Recenter), // All Controls
                      new Button(ToolCommandID.SearchRadius, ToolCommands.SearchRadius), // All Controls
                      new Button(ToolCommandID.SearchBoundary, ToolCommands.SearchBoundary), // All Controls
                      new Button(ToolCommandID.ZoomIn, ToolCommands.ZoomIn), // All Controls
                      new Button(ToolCommandID.ZoomOut, ToolCommands.ZoomOut), // All Controls
                      new Button(ToolCommandID.PointQuery, ToolCommands.PointQuery), // All Controls
                      new Button(ToolCommandID.LabelTool, ToolCommands.LabelTool), // All Controls
                      new Button(ToolCommandID.Ruler, ToolCommands.Ruler), // All Controls
                      new Button(ToolCommandID.SearchRect, ToolCommands.SearchRect), // All Controls
                      new Button(ToolCommandID.AddNode, ToolCommands.AddNode), // All Controls
                      new Button(ToolCommandID.SelectRasterRegPoint, ToolCommands.SelectRasterRegPoint), // All Controls
                      new Button(ToolCommandID.SearchPolygon, ToolCommands.SearchPolygon), // All Controls
                      new Button(ToolCommandID.HotLink, ToolCommands.HotLink), // All Controls
                    }
                  }
                }
              },
              new Button("QueryCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(QueryCommandID.SelectQuery, QueryCommands.SelectQuery), // All Controls
                      new Button(QueryCommandID.SqlQuery, QueryCommands.SqlQuery), // All Controls
                      new Button(QueryCommandID.SelectAll, noWarnings: true), // All Controls // No Command
                      new Button(QueryCommandID.UnSelect, QueryCommands.UnSelect), // All Controls
                      new Button(QueryCommandID.Find, QueryCommands.Find), // All Controls
                      new Button(QueryCommandID.FindSelection, QueryCommands.FindSelection), // All Controls
                      new Button(QueryCommandID.InvertSelect, QueryCommands.InvertSelect), // All Controls
                      new Button(QueryCommandID.FindFrontSelection, QueryCommands.FindFrontSelection), // All Controls
                      new Button(QueryCommandID.FindAddress, QueryCommands.FindAddress), // All Controls
                    }
                  }
                }
              },
              new Button("BrowseCommandsID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(BrowseCommandsID.UnselectAll, BrowseCommands.UnselectAll), // All Controls
                      new Button(BrowseCommandsID.NewRow, BrowseCommands.NewRow), // All Controls
                      new Button(BrowseCommandsID.PickFields, BrowseCommands.PickFields), // All Controls
                      new Button(BrowseCommandsID.MultiSort, BrowseCommands.MultiSort), // All Controls
                      new Button(BrowseCommandsID.ShowGridLines, BrowseCommands.ShowGridLines), // All Controls
                      new Button(BrowseCommandsID.BrowserFont, BrowseCommands.BrowserFont), // All Controls
                      new Button(BrowseCommandsID.ClearSort, BrowseCommands.ClearSort), // All Controls
                      new Button(BrowseCommandsID.SortAscending, BrowseCommands.SortAscending), // All Controls
                      new Button(BrowseCommandsID.SortDescending, BrowseCommands.SortDescending), // All Controls
                      new Button(BrowseCommandsID.Filter, BrowseCommands.Filter), // All Controls
                      new Button(BrowseCommandsID.ClearFilter, BrowseCommands.ClearFilter), // All Controls
                      new Button(BrowseCommandsID.ToggleSort, BrowseCommands.ToggleSort), // All Controls
                      new Button(BrowseCommandsID.ClearFilters, BrowseCommands.ClearFilters), // All Controls
                      new Button(BrowseCommandsID.SelectAll, BrowseCommands.SelectAll), // All Controls
                      new Button(BrowseCommandsID.ReapplySort, BrowseCommands.ReapplySort), // All Controls
                      new Button(BrowseCommandsID.ClearAll, BrowseCommands.ClearAll), // All Controls
                      new Button(BrowseCommandsID.CreateQuery, BrowseCommands.CreateQuery), // All Controls
                    }
                  }
                }
              },
              new Button("EditCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(EditCommandID.Undo, EditCommands.Undo), // All Controls
                      new Button(EditCommandID.Cut, EditCommands.Cut), // All Controls
                      new Button(EditCommandID.Copy, EditCommands.Copy), // All Controls
                      new Button(EditCommandID.Paste, EditCommands.Paste), // All Controls
                      new Button(EditCommandID.ClearMapObjects, EditCommands.ClearMapObjects), // All Controls
                      new Button(EditCommandID.GetInfo, EditCommands.GetInfo), // All Controls
                    }
                  }
                }
              },
              new Button("MapCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(MapCommandID.AddBasemapAerial, MapCommands.AddBasemapAerial), // All Controls
                      new Button(MapCommandID.AddBasemapHybrid, MapCommands.AddBasemapHybrid), // All Controls
                      new Button(MapCommandID.AddBasemapRoads, MapCommands.AddBasemapRoads), // All Controls
                      new Button(MapCommandID.AddThematic, MapCommands.AddThematic), // All Controls
                      new Button(MapCommandID.ModifyThematic, noWarnings: true), // All Controls
                      new Button(MapCommandID.LayerControlDialog, noWarnings: true), // All Controls // No Command
                      new Button(MapCommandID.MapOptions, MapCommands.MapOptions), // All Controls
                      new Button(MapCommandID.ChangeView, MapCommands.ChangeView), // All Controls
                      new Button(MapCommandID.PreviousView, MapCommands.PreviousView), // All Controls
                      new Button(MapCommandID.ViewEntireLayer, MapCommands.ViewEntireLayer), // All Controls
                      new Button(MapCommandID.SaveCosmetic, MapCommands.SaveCosmetic), // All Controls
                      new Button(MapCommandID.ClearCosmetic, MapCommands.ClearCosmetic), // All Controls
                      new Button(MapCommandID.CloneMapper, MapCommands.CloneMapper), // All Controls
                      new Button(MapCommandID.SetClipRegion, MapCommands.SetClipRegion), // All Controls
                      new Button(MapCommandID.ClipRegionOnOff, MapCommands.ClipRegionOnOff), // All Controls
                      new Button(MapCommandID.ClearCustomLabels, MapCommands.ClearCustomLabels), // All Controls
                      new Button(MapCommandID.AutoscrollOnOff, noWarnings: true), // All Controls // No Command
                      new Button(MapCommandID.CreateLegend, noWarnings: true), // All Controls // No Command
                      new Button(MapCommandID.Create3Dmap), // All Controls
                      new Button(MapCommandID.CreatePrismmap), // All Controls
                      new Button(MapCommandID.ViewEntireSelectionLayer, MapCommands.ViewEntireSelectionLayer), // All Controls
                      new Button(MapCommandID.SelectAllFromSelection, MapCommands.SelectAllFromSelection), // All Controls
                      new Button(MapCommandID.MakeSelectionEditable, MapCommands.MakeSelectionEditable), // All Controls
                      new Button(MapCommandID.CreateScalebar, MapCommands.CreateScalebar), // All Controls
                      new Button(MapCommandID.MoveMapTo, MapCommands.MoveMapTo), // All Controls
                      new Button(MapCommandID.CreateLegendPref, noWarnings: true), // All Controls
                      new Button(MapCommandID.CreateLegendDesigner, MapCommands.CreateLegendDesigner), // All Controls
                      new Button(MapCommandID.ViewNearestTileServerLevel, MapCommands.ViewNearestTileServerLevel), // All Controls
                      new Button(MapCommandID.WorkspaceExplorer, MapCommands.WorkspaceExplorer), // All Controls
                      new Button(MapCommandID.LockScale, MapCommands.LockScale), // All Controls
                      new Button(MapCommandID.SelectableLabels, MapCommands.SelectableLabels), // All Controls
                      new Button(MapCommandID.ViewEntireMap, MapCommands.ViewEntireMap), // All Controls
                      new Button(MapCommandID.ViewEntireSelectedObjects, MapCommands.ViewEntireSelectedObjects), // All Controls
                      new Button(MapCommandID.SnapToNode, MapCommands.SnapToNode), // All Controls
                      new Button(MapCommandID.RedrawOnOff, MapCommands.RedrawOnOff), // All Controls
                      new Button(MapCommandID.DragMap, MapCommands.DragMap), // All Controls
                      new Button(MapCommandID.ViewEntireGrid_3DMap, MapCommands.ViewEntireGrid_3DMap), // All Controls
                      new Button(MapCommandID.Properties_3DMap, MapCommands.Properties_3DMap), // All Controls
                      new Button(MapCommandID.RefreshGridTexture_3DMap, MapCommands.RefreshGridTexture_3DMap), // All Controls
                      new Button(MapCommandID.Wireframe_3DMap, MapCommands.Wireframe_3DMap), // All Controls
                      new Button(MapCommandID.CloneView_3DMap, MapCommands.CloneView_3DMap), // All Controls
                      new Button(MapCommandID.PreviousView_3DMap, MapCommands.PreviousView_3DMap), // All Controls
                      new Button(MapCommandID.ViewpointControl_3DMap, MapCommands.ViewpointControl_3DMap), // All Controls
                      new Button(MapCommandID.AdornmentProperties, MapCommands.AdornmentProperties), // All Controls
                      new Button(MapCommandID.RemoveAdornment, MapCommands.RemoveAdornment), // All Controls
                      new Button(MapCommandID.HotlinkOptions, MapCommands.HotlinkOptions), // All Controls
                    }
                  }
                }
              },
            }
          },
          new Button("Hidden menus", ControlType.BackStageTabItem)
          {
            AccessableTo = UserLevel.Admin | UserLevel.Tester,
            Children = new Button[]
            {
              new Button("ApplicationCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(ApplicationCommandID.GetMapBasicUtilities, ApplicationCommands.GetMapBasicUtilities), //
                      new Button(ApplicationCommandID.CustomMapBasicHandler, ApplicationCommands.CustomMapBasicHandler), //
                      new Button(ApplicationCommandID.CustomToolButton, ApplicationCommands.CustomToolButton), //
                      new Button(ApplicationCommandID.Exit, ApplicationCommands.Exit), //
                    }
                  }
                }
              },
              new Button("EditCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(EditCommandID.GetInfo, EditCommands.GetInfo), //
                    }
                  }
                }
              },
              new Button("HelpCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(HelpCommandID.About, HelpCommands.About), // 
                      new Button(HelpCommandID.TechSupport, HelpCommands.TechSupport), //
                      new Button(HelpCommandID.MapInfoWwwStoreEuro, HelpCommands.MapInfoWwwStoreEuro), //
                      new Button(HelpCommandID.MapInfoWww, HelpCommands.MapInfoWww), //
                      new Button(HelpCommandID.MapInfoWwwStore, HelpCommands.MapInfoWwwStore), //
                      new Button(HelpCommandID.SmartUpdate, HelpCommands.SmartUpdate), //
                      new Button(HelpCommandID.WwwTutorial, HelpCommands.WwwTutorial), //
                      new Button(HelpCommandID.TransferLicense, HelpCommands.TransferLicense), //
                      new Button(HelpCommandID.BorrowLicense, HelpCommands.BorrowLicense), //
                      new Button(HelpCommandID.ReturnBorrowedLicense, HelpCommands.ReturnBorrowedLicense), //
                      new Button(HelpCommandID.ProductFeedback, HelpCommands.ProductFeedback), //
                      new Button(HelpCommandID.BingTermsOfUse, HelpCommands.BingTermsOfUse), //
                      new Button(HelpCommandID.MapInfoNewsfeed, HelpCommands.MapInfoNewsfeed), //
                      new Button(HelpCommandID.UserBingKey, HelpCommands.UserBingKey), //
                      new Button(HelpCommandID.StartAdvancedEvaluation, HelpCommands.StartAdvancedEvaluation), //
                      new Button(HelpCommandID.ActivateAdvancedLicense, HelpCommands.ActivateAdvancedLicense), //
                      new Button(HelpCommandID.ActivateFlexeraLicenseForSubscriptionLicensedUser, HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUser), //
                    }
                  }
                }
              },
              new Button("LayerControlCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LayerControlCommandID.LcLabelFont, LayerControlCommands.LcLabelFont), //
                      new Button(LayerControlCommandID.LcOtherNoSelect, LayerControlCommands.LcOtherNoSelect), //
                      new Button(LayerControlCommandID.LcAddDisplayOverride, LayerControlCommands.LcAddDisplayOverride), //
                      new Button(LayerControlCommandID.LcAddLabelOverride, LayerControlCommands.LcAddLabelOverride), //
                      new Button(LayerControlCommandID.LcDisplayOverrideProperties, LayerControlCommands.LcDisplayOverrideProperties), //
                      new Button(LayerControlCommandID.LcLabelOverrideProperties, LayerControlCommands.LcLabelOverrideProperties), //
                      new Button(LayerControlCommandID.LcSplitOverride, LayerControlCommands.LcSplitOverride), //
                      new Button(LayerControlCommandID.LcRemoveOverride, LayerControlCommands.LcRemoveOverride), //
                      new Button(LayerControlCommandID.LcSelectAll, LayerControlCommands.LcSelectAll), //
                      new Button(LayerControlCommandID.LcRenameToFriendlyName, LayerControlCommands.LcRenameToFriendlyName), //
                    }
                  }
                }
              },
              new Button("LayoutCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LayoutCommandID.RefreshLegends, LayoutCommands.RefreshLegends), //
                      new Button(LayoutCommandID.StackUndo, LayoutCommands.StackUndo), //
                      new Button(LayoutCommandID.StackRedo, LayoutCommands.StackRedo), //
                      new Button(LayoutCommandID.AddSymbol, LayoutCommands.AddSymbol), //
                      new Button(LayoutCommandID.AddLine, LayoutCommands.AddLine), //
                      new Button(LayoutCommandID.AddEllipse, LayoutCommands.AddEllipse), //
                      new Button(LayoutCommandID.AddRectangle, LayoutCommands.AddRectangle), //
                      new Button(LayoutCommandID.AddRoundedRectangle, LayoutCommands.AddRoundedRectangle), //
                      new Button(LayoutCommandID.LineSpacingDouble, LayoutCommands.LineSpacingDouble), //
                      new Button(LayoutCommandID.LineSpacingOnePointFive, LayoutCommands.LineSpacingOnePointFive), //
                      new Button(LayoutCommandID.LineSpacingSingle, LayoutCommands.LineSpacingSingle), //
                      new Button(LayoutCommandID.TextJustifyCenter, LayoutCommands.TextJustifyCenter), //
                      new Button(LayoutCommandID.TextJustifyLeft, LayoutCommands.TextJustifyLeft), //
                      new Button(LayoutCommandID.TextJustifyRight, LayoutCommands.TextJustifyRight), //
                      new Button(LayoutCommandID.AddPolygon, LayoutCommands.AddPolygon), //
                      new Button(LayoutCommandID.AddPolyline, LayoutCommands.AddPolyline), //
                    }
                  }
                }
              },
              new Button("MapCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(MapCommandID.Create3Dmap), //
                      new Button(MapCommandID.ViewEntireGrid_3DMap, MapCommands.ViewEntireGrid_3DMap), //
                      new Button(MapCommandID.Properties_3DMap, MapCommands.Properties_3DMap), //
                      new Button(MapCommandID.RefreshGridTexture_3DMap, MapCommands.RefreshGridTexture_3DMap), //
                      new Button(MapCommandID.Wireframe_3DMap, MapCommands.Wireframe_3DMap), //
                      new Button(MapCommandID.CloneView_3DMap, MapCommands.CloneView_3DMap), //
                      new Button(MapCommandID.PreviousView_3DMap, MapCommands.PreviousView_3DMap), //
                      new Button(MapCommandID.ViewpointControl_3DMap, MapCommands.ViewpointControl_3DMap), //
                      new Button(MapCommandID.AdornmentProperties, MapCommands.AdornmentProperties), //
                      new Button(MapCommandID.RemoveAdornment, MapCommands.RemoveAdornment), //
                    }
                  }
                }
              },
              new Button("LegendCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(LegendCommandID.DisableGuidelines, LegendCommands.DisableGuidelines), //
                      new Button(LegendCommandID.RemoveGuidelines, LegendCommands.RemoveGuidelines), //
                      new Button(LegendCommandID.RemoveFrames, LegendCommands.RemoveFrames), //
                      new Button(LegendCommandID.FrameProperties, LegendCommands.FrameProperties), //
                      new Button(LegendCommandID.AddFrames, LegendCommands.AddFrames), //
                      new Button(LegendCommandID.AddTextFrame, LegendCommands.AddTextFrame), //
                    }
                  }
                }
              },
              new Button("TableListCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(TableListCommandID.TlvSelectAllFromTable, TableListCommands.TlvSelectAllFromTable), //
                      new Button(TableListCommandID.TlvRefreshTable, TableListCommands.TlvRefreshTable), //
                      new Button(TableListCommandID.TlvCreatePoints, TableListCommands.TlvCreatePoints), //
                      new Button(TableListCommandID.TlvCompareStructure, TableListCommands.TlvCompareStructure), //
                    }
                  }
                }
              },
              new Button("WindowCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(WindowCommandID.StatisticsWindowCopy, WindowCommands.StatisticsWindowCopy), //
                      new Button(WindowCommandID.ClearMsgWin, WindowCommands.ClearMsgWin), //
                    }
                  }
                }
              },
              new Button("WindowListCommandID", ControlType.RibbonMenuGroup)
              {
                Children = new Button[]
                {
                  new Button("", ControlType.WrapPanel)
                  {
                    ItemWidht = 300,
                    Children = new Button[]
                    {
                      new Button(WindowListCommandID.SelectAllOfType, WindowListCommands.SelectAllOfType), //
                      new Button(WindowListCommandID.HideSelectedWindow, WindowListCommands.HideSelectedWindow), //
                      new Button(WindowListCommandID.ActivateSelectedWindow, WindowListCommands.ActivateSelectedWindow), //
                      new Button(WindowListCommandID.CloseSelectedWindow, WindowListCommands.CloseSelectedWindow), //
                      new Button(WindowListCommandID.RenameSelectedWindow, WindowListCommands.RenameSelectedWindow), //
                      new Button(WindowListCommandID.CloneSelectedWindow, WindowListCommands.CloneSelectedWindow), // 
                    }
                  }
                }
              },
            }
          }
        };
      MapMiniToolBar = new Button[] { 
        new Button(ControlType.StackPanel) {
          Children = new Button[] {
            new Button(WindowCommandID.WorkspaceExplorer, WindowCommands.WorkspaceExplorer){
              Caption = "",
              IsLarge = false
            }
          }
        } 
      };
      LayoutMiniToolBar = new Button[] {
        //new Button(ControlType.StackPanel) {
        //  Children = new Button[] {
        //    Example.Button
        //  }
        //}
      };
      Ribbon = new Ribbon()
      {
        ProText = "LGT",
        Tabs = Tabs,
        Backstage = Backstage,
        MapMiniToolBar = MapMiniToolBar,
        LayoutMiniToolBar = LayoutMiniToolBar
      };
    }
    public static Ribbon Ribbon { get; set; }
    public static Tab[] Tabs { get; set; }
    public static Button[] Backstage { get; set; }
    public static Button[] MapMiniToolBar { get; set; }
    public static Button[] LayoutMiniToolBar { get; set; }

    public static Button temp { get; set; }
    internal static Button myOpenButtons = new Button(ApplicationCommandID.OpenWorkspace, ApplicationCommands.OpenWorkspace, ControlType.DropDownButton)
    {
      Caption = "Open",
      IsLarge = true,
      Enabled = true,
      Children = new Button[] {
          new Button("Workspaces, Tables, Programs", ControlType.DropDownMenuGroup){

            Children = new Button[]
            {
              new Button(ControlType.StackPanel)
              {
                Children = new Button[]
                {
                  new Button(ApplicationCommandID.OpenWorkspace, ApplicationCommands.OpenWorkspace){ IsLarge = false },
                  new Button(ApplicationCommandID.AddWorkspace, ApplicationCommands.AddWorkspace){ IsLarge = false },
                  new Button(ApplicationCommandID.OpenTable, ApplicationCommands.OpenTable){ IsLarge = false },
                  new Button(ApplicationCommandID.OpenUniversalData, ApplicationCommands.OpenUniversalData){ IsLarge = false },
                  new Button(ApplicationCommandID.OpenDBMS, ApplicationCommands.OpenDBMS){ IsLarge = false },
                }
              }
            }
          },
          new Button("Web Services", ControlType.DropDownMenuGroup){
            Children = new Button(ControlType.StackPanel){
              Children = new Button[]
              {
                new Button(WebServicesCommandID.OpenWms, WebServicesCommands.OpenWms){ IsLarge = false },
                new Button(WebServicesCommandID.OpenWfs, WebServicesCommands.OpenWfs){ IsLarge = false },
                new Button(WebServicesCommandID.OpenWmts, WebServicesCommands.OpenWmts){ IsLarge = false },
              }
            },
          }
        }
    };
    internal static TabGroup myClipboardGroup = new TabGroup("HOME_Clipboard", "Clipboard")
    {
      Controls = new Button[]{
          new Button(EditCommandID.Copy, EditCommands.Copy),
          new Button(EditCommandID.Paste, EditCommands.Paste),
          new Button(EditCommandID.Cut, EditCommands.Cut),
          new Button(EditCommandID.Undo, EditCommands.Undo),

        }
    };
    internal static Button mySQLSelect = new Button(ControlType.DropDownButton)
    {
      Command = QueryCommands.SelectQuery,
      IsLarge = true,
      Children = new Button[]
        {
          new Button(QueryCommandID.SqlQuery, QueryCommands.SqlQuery),
          new Button(QueryCommandID.SelectQuery, QueryCommands.SelectQuery)
        }
    };
    internal static Button myFind = new Button(QueryCommandID.FindAddress, QueryCommands.FindAddress, ControlType.DropDownButton)
    {
      Caption = "Find",
      IsLarge = false,
      Children = new Button[]{
        new Button(QueryCommandID.FindSelection, QueryCommands.FindSelection){ IsLarge = true },
        new Button(QueryCommandID.FindAddress, QueryCommands.FindAddress){ IsLarge = true },
        new Button(QueryCommandID.Find, QueryCommands.Find){ IsLarge = true },
      }
    };
  }
}
