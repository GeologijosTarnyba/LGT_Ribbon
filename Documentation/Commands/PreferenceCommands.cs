// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.PreferenceCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class PreferenceCommands
  {
    private static readonly MapInfoCommand PreferencesCommand;
    private static readonly MapInfoCommand SystemPreferencesCommand;
    private static readonly MapInfoCommand MapPreferencesCommand;
    private static readonly MapInfoCommand LegendPreferencesCommand;
    private static readonly MapInfoCommand StartUpPreferencesCommand;
    private static readonly MapInfoCommand CountryPreferencesCommand;
    private static readonly MapInfoCommand PathPreferencesCommand;
    private static readonly MapInfoCommand OutputPreferencesCommand;
    private static readonly MapInfoCommand PrinterPreferencesCommand;
    private static readonly MapInfoCommand StylesPreferencesCommand;
    private static readonly MapInfoCommand ProcImagePreferencesCommand;
    private static readonly MapInfoCommand WebservicesPreferencesCommand;
    private static readonly MapInfoCommand LayoutPreferencesCommand;
    private static readonly MapInfoCommand BrowserPreferencesCommand;
    private static readonly MapInfoCommand NotificationsPreferencesCommand;
    private static readonly MapInfoCommand PerformancePreferencesCommand;
    private static readonly MapInfoCommand WindowStatePreferencesCommand;
    private static readonly MapInfoCommand WorkspacePreferencesCommand;
    private static readonly MapInfoCommand MapBasicWindowPreferencesCommand;
    private static readonly MapInfoCommand ExplorerPreferencesCommand;
    private static readonly MapInfoCommand TaskManagerPreferencesCommand;
    private static readonly MapInfoCommand WindowListPreferencesCommand;

    static PreferenceCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(208, nameof (Preferences), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_Preferences_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/toolManager_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/toolManager_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_Preferences_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_Preferences_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.PreferencesCommand = (MapInfoCommand) basicRunMenuCommand1;
      PreferenceCommands.PreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(210, nameof (SystemPreferences), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_SystemPreferences_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optSystemSettings_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optSystemSettings_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_SystemPreferences_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_SystemPreferences_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.EnableCommand = true;
      basicRunMenuCommand2.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.SystemPreferencesCommand = (MapInfoCommand) basicRunMenuCommand2;
      PreferenceCommands.SystemPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(212, nameof (MapPreferences), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_MapPreferences_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newMap_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newMap_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_MapPreferences_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_MapPreferences_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = true;
      basicRunMenuCommand3.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.MapPreferencesCommand = (MapInfoCommand) basicRunMenuCommand3;
      PreferenceCommands.MapPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(215, nameof (LegendPreferences), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_LegendPreferences_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/insertLegend_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/insertLegend_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_LegendPreferences_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_LegendPreferences_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand4.EnableCommand = true;
      basicRunMenuCommand4.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.LegendPreferencesCommand = (MapInfoCommand) basicRunMenuCommand4;
      PreferenceCommands.LegendPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(211, nameof (StartUpPreferences), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_StartUpPreferences_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optStartup_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optStartup_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_StartUpPreferences_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_StartUpPreferences_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand5.EnableCommand = true;
      basicRunMenuCommand5.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.StartUpPreferencesCommand = (MapInfoCommand) basicRunMenuCommand5;
      PreferenceCommands.StartUpPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(213, nameof (CountryPreferences), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_CountryPreferences_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optAddressMatch_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optAddressMatch_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_CountryPreferences_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_CountryPreferences_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand6.EnableCommand = true;
      basicRunMenuCommand6.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.CountryPreferencesCommand = (MapInfoCommand) basicRunMenuCommand6;
      PreferenceCommands.CountryPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(214, nameof (PathPreferences), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_PathPreferences_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optDirectories_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optDirectories_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_PathPreferences_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_PathPreferences_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand7.EnableCommand = true;
      basicRunMenuCommand7.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.PathPreferencesCommand = (MapInfoCommand) basicRunMenuCommand7;
      PreferenceCommands.PathPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(216, nameof (OutputPreferences), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_OutputPreferences_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optOutputSettings_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optOutputSettings_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_OutputPreferences_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_OutputPreferences_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand8.EnableCommand = true;
      basicRunMenuCommand8.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.OutputPreferencesCommand = (MapInfoCommand) basicRunMenuCommand8;
      PreferenceCommands.OutputPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(217, nameof (PrinterPreferences), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_PrinterPreferences_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/print_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/print_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_PrinterPreferences_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_PrinterPreferences_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand9.EnableCommand = true;
      basicRunMenuCommand9.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.PrinterPreferencesCommand = (MapInfoCommand) basicRunMenuCommand9;
      PreferenceCommands.PrinterPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(218, nameof (StylesPreferences), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_StylesPreferences_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optStyles_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optStyles_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_StylesPreferences_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_StylesPreferences_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand10.EnableCommand = true;
      basicRunMenuCommand10.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.StylesPreferencesCommand = (MapInfoCommand) basicRunMenuCommand10;
      PreferenceCommands.StylesPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(219, nameof (ProcImagePreferences), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_ProcImagePreferences_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optImageProc_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optImageProc_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_ProcImagePreferences_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_ProcImagePreferences_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand11.EnableCommand = true;
      basicRunMenuCommand11.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.ProcImagePreferencesCommand = (MapInfoCommand) basicRunMenuCommand11;
      PreferenceCommands.ProcImagePreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(220, nameof (WebservicesPreferences), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_WebservicesPreferences_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optWebServices_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optWebServices_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_WebservicesPreferences_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_WebservicesPreferences_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand12.EnableCommand = true;
      basicRunMenuCommand12.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.WebservicesPreferencesCommand = (MapInfoCommand) basicRunMenuCommand12;
      PreferenceCommands.WebservicesPreferencesCommand.CreateScreenTip();
      MapInfo.Commands.LayoutPreferencesCommand preferencesCommand1 = new MapInfo.Commands.LayoutPreferencesCommand(nameof (LayoutPreferences), (InputGestureCollection) null);
      preferencesCommand1.Text = Resources.Command_LayoutPreferences_Label;
      preferencesCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newLayoutPage_16x16.png";
      preferencesCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/newLayoutPage_32x32.png";
      preferencesCommand1.ToolTipDescription = Resources.Command_LayoutPreferences_ToolTip_Description;
      preferencesCommand1.ToolTipText = Resources.Command_LayoutPreferences_ToolTip_Text;
      preferencesCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      preferencesCommand1.EnableCommand = true;
      preferencesCommand1.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.LayoutPreferencesCommand = (MapInfoCommand) preferencesCommand1;
      PreferenceCommands.LayoutPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(222, nameof (BrowserPreferences), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_BrowserPreferences_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/newBrowser_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_BrowserPreferences_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_BrowserPreferences_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand13.EnableCommand = true;
      basicRunMenuCommand13.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.BrowserPreferencesCommand = (MapInfoCommand) basicRunMenuCommand13;
      PreferenceCommands.BrowserPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(223, nameof (NotificationsPreferences), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_NotificationsPreferences_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optNotifications_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optNotifications_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_NotificationsPreferences_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_NotificationsPreferences_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand14.EnableCommand = true;
      basicRunMenuCommand14.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.NotificationsPreferencesCommand = (MapInfoCommand) basicRunMenuCommand14;
      PreferenceCommands.NotificationsPreferencesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(224, nameof (PerformancePreferences), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_PerformancePreferences_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optPerformance_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/optPerformance_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_PerformancePreferences_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_PerformancePreferences_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand15.EnableCommand = true;
      basicRunMenuCommand15.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.PerformancePreferencesCommand = (MapInfoCommand) basicRunMenuCommand15;
      PreferenceCommands.PerformancePreferencesCommand.CreateScreenTip();
      MapInfo.Commands.WorkspacePreferencesCommand preferencesCommand2 = new MapInfo.Commands.WorkspacePreferencesCommand(nameof (WorkspacePreferences), (InputGestureCollection) null);
      preferencesCommand2.Text = Resources.Command_WorkspacePreferences_Label;
      preferencesCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWorkspace_16x16.png";
      preferencesCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWorkspace_32x32.png";
      preferencesCommand2.ToolTipDescription = Resources.Command_WorkspacePreferences_ToolTip_Description;
      preferencesCommand2.ToolTipText = Resources.Command_WorkspacePreferences_ToolTip_Text;
      preferencesCommand2.EnableCommand = true;
      preferencesCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      preferencesCommand2.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.WorkspacePreferencesCommand = (MapInfoCommand) preferencesCommand2;
      PreferenceCommands.WorkspacePreferencesCommand.CreateScreenTip();
      MapInfo.Commands.WindowStatePreferencesCommand preferencesCommand3 = new MapInfo.Commands.WindowStatePreferencesCommand(nameof (WindowStatePreferences), (InputGestureCollection) null);
      preferencesCommand3.Text = Resources.Command_WindowStatePreferences_Label;
      preferencesCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tasksWindow_16x16.png";
      preferencesCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tasksWindow_32x32.png";
      preferencesCommand3.ToolTipDescription = Resources.Command_WindowStatePreferences_ToolTip_Description;
      preferencesCommand3.ToolTipText = Resources.Command_WindowStatePreferences_ToolTip_Text;
      preferencesCommand3.EnableCommand = true;
      preferencesCommand3.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.WindowStatePreferencesCommand = (MapInfoCommand) preferencesCommand3;
      PreferenceCommands.WindowStatePreferencesCommand.CreateScreenTip();
      MapInfo.Commands.MapBasicWindowPreferencesCommand preferencesCommand4 = new MapInfo.Commands.MapBasicWindowPreferencesCommand(nameof (MapBasicWindowPreferences), (InputGestureCollection) null);
      preferencesCommand4.Text = Resources.Command_MapBasicWindowPreferences_Label;
      preferencesCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/mapbasicWindow_32x32.png";
      preferencesCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/mapbasicWindow_16x16.png";
      preferencesCommand4.ToolTipDescription = Resources.Command_MapBasicWindowPreferences_ToolTip_Description;
      preferencesCommand4.ToolTipText = Resources.Command_MapBasicWindowPreferences_ToolTip_Text;
      preferencesCommand4.EnableCommand = true;
      preferencesCommand4.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.MapBasicWindowPreferencesCommand = (MapInfoCommand) preferencesCommand4;
      PreferenceCommands.MapBasicWindowPreferencesCommand.CreateScreenTip();
      MapInfo.Commands.ExplorerPreferencesCommand preferencesCommand5 = new MapInfo.Commands.ExplorerPreferencesCommand(nameof (ExplorerPreferences), (InputGestureCollection) null);
      preferencesCommand5.Text = Resources.Command_ExplorerPreferences_Label;
      preferencesCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/workspaceExplorerWindow_32x32.png";
      preferencesCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/workspaceExplorerWindow_16x16.png";
      preferencesCommand5.ToolTipDescription = Resources.Command_ExplorerPreferences_ToolTip_Description;
      preferencesCommand5.ToolTipText = Resources.Command_ExplorerPreferences_ToolTip_Text;
      preferencesCommand5.EnableCommand = true;
      preferencesCommand5.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.ExplorerPreferencesCommand = (MapInfoCommand) preferencesCommand5;
      PreferenceCommands.ExplorerPreferencesCommand.CreateScreenTip();
      MapInfo.Commands.TaskManagerPreferencesCommand preferencesCommand6 = new MapInfo.Commands.TaskManagerPreferencesCommand(nameof (TaskManagerPreferences), (InputGestureCollection) null);
      preferencesCommand6.Text = Resources.Command_TaskManagerPreferences_Label;
      preferencesCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tasksWindow_32x32.png";
      preferencesCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tasksWindow_16x16.png";
      preferencesCommand6.ToolTipDescription = Resources.Command_TaskManagerPreferences_ToolTip_Description;
      preferencesCommand6.ToolTipText = Resources.Command_TaskManagerPreferences_ToolTip_Text;
      preferencesCommand6.EnableCommand = true;
      preferencesCommand6.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.TaskManagerPreferencesCommand = (MapInfoCommand) preferencesCommand6;
      PreferenceCommands.TaskManagerPreferencesCommand.CreateScreenTip();
      MapInfo.Commands.WindowListPreferencesCommand preferencesCommand7 = new MapInfo.Commands.WindowListPreferencesCommand(nameof (WindowListPreferences), (InputGestureCollection) null);
      preferencesCommand7.Text = Resources.Command_WindowListPreferences_Label;
      preferencesCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/windowList_32x32.png";
      preferencesCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/windowList_16x16.png";
      preferencesCommand7.ToolTipDescription = Resources.Command_WindowListPreferences_ToolTip_Description;
      preferencesCommand7.ToolTipText = Resources.Command_WindowListPreferences_ToolTip_Text;
      preferencesCommand7.EnableCommand = true;
      preferencesCommand7.Category = Resources.Command_Category_PreferenceCommands;
      PreferenceCommands.WindowListPreferencesCommand = (MapInfoCommand) preferencesCommand7;
      PreferenceCommands.WindowListPreferencesCommand.CreateScreenTip();
    }

    public static MapInfoCommand Preferences
    {
      get
      {
        return PreferenceCommands.PreferencesCommand;
      }
    }

    public static MapInfoCommand SystemPreferences
    {
      get
      {
        return PreferenceCommands.SystemPreferencesCommand;
      }
    }

    public static MapInfoCommand MapPreferences
    {
      get
      {
        return PreferenceCommands.MapPreferencesCommand;
      }
    }

    public static MapInfoCommand LegendPreferences
    {
      get
      {
        return PreferenceCommands.LegendPreferencesCommand;
      }
    }

    public static MapInfoCommand StartUpPreferences
    {
      get
      {
        return PreferenceCommands.StartUpPreferencesCommand;
      }
    }

    public static MapInfoCommand CountryPreferences
    {
      get
      {
        return PreferenceCommands.CountryPreferencesCommand;
      }
    }

    public static MapInfoCommand PathPreferences
    {
      get
      {
        return PreferenceCommands.PathPreferencesCommand;
      }
    }

    public static MapInfoCommand OutputPreferences
    {
      get
      {
        return PreferenceCommands.OutputPreferencesCommand;
      }
    }

    public static MapInfoCommand PrinterPreferences
    {
      get
      {
        return PreferenceCommands.PrinterPreferencesCommand;
      }
    }

    public static MapInfoCommand StylesPreferences
    {
      get
      {
        return PreferenceCommands.StylesPreferencesCommand;
      }
    }

    public static MapInfoCommand ProcImagePreferences
    {
      get
      {
        return PreferenceCommands.ProcImagePreferencesCommand;
      }
    }

    public static MapInfoCommand WebservicesPreferences
    {
      get
      {
        return PreferenceCommands.WebservicesPreferencesCommand;
      }
    }

    public static MapInfoCommand LayoutPreferences
    {
      get
      {
        return PreferenceCommands.LayoutPreferencesCommand;
      }
    }

    public static MapInfoCommand BrowserPreferences
    {
      get
      {
        return PreferenceCommands.BrowserPreferencesCommand;
      }
    }

    public static MapInfoCommand NotificationsPreferences
    {
      get
      {
        return PreferenceCommands.NotificationsPreferencesCommand;
      }
    }

    public static MapInfoCommand PerformancePreferences
    {
      get
      {
        return PreferenceCommands.PerformancePreferencesCommand;
      }
    }

    public static MapInfoCommand WindowStatePreferences
    {
      get
      {
        return PreferenceCommands.WindowStatePreferencesCommand;
      }
    }

    public static MapInfoCommand WorkspacePreferences
    {
      get
      {
        return PreferenceCommands.WorkspacePreferencesCommand;
      }
    }

    public static MapInfoCommand ExplorerPreferences
    {
      get
      {
        return PreferenceCommands.ExplorerPreferencesCommand;
      }
    }

    public static MapInfoCommand MapBasicWindowPreferences
    {
      get
      {
        return PreferenceCommands.MapBasicWindowPreferencesCommand;
      }
    }

    public static MapInfoCommand TaskManagerPreferences
    {
      get
      {
        return PreferenceCommands.TaskManagerPreferencesCommand;
      }
    }

    public static MapInfoCommand WindowListPreferences
    {
      get
      {
        return PreferenceCommands.WindowListPreferencesCommand;
      }
    }
  }
}
