// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.ApplicationCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class ApplicationCommands
  {
    private static readonly MapInfoCommand NewTableCommand;
    private static readonly MapInfoCommand OpenTableCommand;
    private static readonly MapInfoCommand OpenDBMSCommand;
    private static readonly MapInfoCommand OpenUniversalDataCommand;
    private static readonly MapInfoCommand ImportCommand;
    private static readonly MapInfoCommand CloseTableCommand;
    private static readonly MapInfoCommand CloseAllCommand;
    private static readonly MapInfoCommand CloseDBMSCommand;
    private static readonly MapInfoCommand SaveTableCommand;
    private static readonly MapInfoCommand SaveCopyAsCommand;
    private static readonly MapInfoCommand SaveQueryCommand;
    private static readonly MapInfoCommand SaveWorkspaceCommand;
    private static readonly MapInfoCommand SaveWindowAsCommand;
    private static readonly MapInfoCommand PrintCommand;
    private static readonly MapInfoCommand PrintToPDFCommand;
    private static readonly MapInfoCommand ExitCommand;
    private static readonly MapInfoCommand OpenWorkspaceCommand;
    private static readonly MapInfoCommand AddWorkspaceCommand;
    private static readonly MapInfoCommand RunMapBasicCommand;
    private static readonly MapInfoCommand PageSetupCommand;
    private static readonly MapInfoCommand GetMapBasicUtilitiesCommand;
    private static readonly MapInfoCommand RunCurrentEditMapBasicCommand;
    private static readonly MapInfoCommand ClearEditContentsCommand;
    private static readonly MapInfoCommand SaveEditContentsCommand;
    private static readonly MapInfoCommand CustomMapBasicRoutineCommand;
    private static readonly MapInfoCommand CustomToolButtonCommand;
    private static readonly MapInfoCommand SaveCurrentWorkspaceCommand;
    private static readonly UrlOpenCommands OpenUrlCommand;
    private static readonly SystemInfoCommands SystemInfoCommand;

    internal static MapInfoCommand CreateCommand(
      string desc,
      string name,
      int id,
      InputGesture keyGesture)
    {
      InputGestureCollection inputGestureCollection = new InputGestureCollection();
      if (keyGesture != null)
        inputGestureCollection.Add(keyGesture);
      return (MapInfoCommand) new MapBasicRunMenuCommand(id, name, inputGestureCollection);
    }

    static ApplicationCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(101, nameof (NewTable), MapInfoCommand.GetGesture(Resources.Command_NewTable_KeyGesture));
      basicRunMenuCommand1.Text = Resources.Command_NewTable_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/newTable_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/newTable_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_NewTable_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_NewTable_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.NewTableCommand = (MapInfoCommand) basicRunMenuCommand1;
      ApplicationCommands.NewTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(102, nameof (OpenTable), MapInfoCommand.GetGesture(Resources.Command_OpenTable_KeyGesture));
      basicRunMenuCommand2.Text = Resources.Command_OpenTable_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/openTable_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Mapping/openTable_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_OpenTable_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_OpenTable_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.EnableCommand = true;
      basicRunMenuCommand2.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.OpenTableCommand = (MapInfoCommand) basicRunMenuCommand2;
      ApplicationCommands.OpenTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(116, nameof (OpenDBMS), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_OpenDBMS_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openDatabaseTable_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openDatabaseTable_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_OpenDBMS_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_OpenDBMS_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = true;
      basicRunMenuCommand3.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.OpenDBMSCommand = (MapInfoCommand) basicRunMenuCommand3;
      ApplicationCommands.OpenDBMSCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(126, nameof (OpenUniversalData), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_OpenUniversalData_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openUniversal_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openUniversal_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_OpenUniversalData_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_OpenUniversalData_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_Disabled_NeedFME;
      basicRunMenuCommand4.EnableCommand = true;
      basicRunMenuCommand4.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.OpenUniversalDataCommand = (MapInfoCommand) basicRunMenuCommand4;
      ApplicationCommands.OpenUniversalDataCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(103, nameof (CloseTable), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_CloseTable_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/closeTable_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_CloseTable_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_CloseTable_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.CloseTableCommand = (MapInfoCommand) basicRunMenuCommand5;
      ApplicationCommands.CloseTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(104, nameof (CloseAll), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_CloseAll_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeAll_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeAll_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_CloseAll_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_CloseAll_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTableOrLayoutWindow;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.CloseAllCommand = (MapInfoCommand) basicRunMenuCommand6;
      ApplicationCommands.CloseAllCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(124, nameof (CloseDBMS), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_CloseDBMS_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeDbms_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/closeDbms_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_CloseDBMS_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_CloseDBMS_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenDBMSConnection;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.CloseDBMSCommand = (MapInfoCommand) basicRunMenuCommand7;
      ApplicationCommands.CloseDBMSCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(105, nameof (SaveTable), MapInfoCommand.GetGesture(Resources.Command_SaveTable_KeyGesture));
      basicRunMenuCommand8.Text = Resources.Command_SaveTable_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveTable_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveTable_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_SaveTable_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_SaveTable_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedEditedTable;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveTableCommand = (MapInfoCommand) basicRunMenuCommand8;
      ApplicationCommands.SaveTableCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(106, nameof (SaveCopyAs), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_SaveCopyAs_Label;
      basicRunMenuCommand9.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveCopyAs_16x16.png";
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveCopyAs_32x32.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_SaveCopyAs_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_SaveCopyAs_ToolTip_Text;
      basicRunMenuCommand9.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand9.EnableCommand = false;
      basicRunMenuCommand9.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveCopyAsCommand = (MapInfoCommand) basicRunMenuCommand9;
      ApplicationCommands.SaveCopyAsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(117, nameof (SaveQuery), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_SaveQuery_Label;
      basicRunMenuCommand10.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveQuery_16x16.png";
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveQuery_32x32.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_SaveQuery_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_SaveQuery_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_Disabled_NeedSelection;
      basicRunMenuCommand10.EnableCommand = false;
      basicRunMenuCommand10.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveQueryCommand = (MapInfoCommand) basicRunMenuCommand10;
      ApplicationCommands.SaveQueryCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(109, nameof (SaveWorkspace), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_SaveWorkspace_Label;
      basicRunMenuCommand11.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/saveWorkspaceAs_16x16.png";
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/saveWorkspaceAs_32x32.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_SaveWorkspace_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_SaveWorkspace_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand11.EnableCommand = true;
      basicRunMenuCommand11.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveWorkspaceCommand = (MapInfoCommand) basicRunMenuCommand11;
      ApplicationCommands.SaveWorkspaceCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(109, nameof (SaveCurrentWorkspace), MapInfoCommand.GetGesture(Resources.Command_SaveCurrentWorkspace_KeyGesture));
      basicRunMenuCommand12.Text = Resources.Command_SaveCurrentWorkspace_Label;
      basicRunMenuCommand12.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/saveWorkspace_16x16.png";
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/saveWorkspace_32x32.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_SaveCurrentWorkspace_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_SaveCurrentWorkspace_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand12.EnableCommand = true;
      basicRunMenuCommand12.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveCurrentWorkspaceCommand = (MapInfoCommand) basicRunMenuCommand12;
      ApplicationCommands.SaveCurrentWorkspaceCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(609, nameof (SaveWindowAs), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_SaveWindowAs_Label;
      basicRunMenuCommand13.MenuItemText = Resources.Command_SaveWindowAs_MenuItemText;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/exportAsImage_16x16.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/exportAsImage_32x32.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_SaveWindowAs_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_SaveWindowAs_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_Disabled_NeedFrontDocumentWindow;
      basicRunMenuCommand13.EnableCommand = false;
      basicRunMenuCommand13.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveWindowAsCommand = (MapInfoCommand) basicRunMenuCommand13;
      ApplicationCommands.SaveWindowAsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(112, nameof (Print), MapInfoCommand.GetGesture(Resources.Command_Print_KeyGesture));
      basicRunMenuCommand14.Text = Resources.Command_Print_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/print_16x16.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/print_32x32.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_Print_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_Print_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_Disabled_NeedFrontDocumentWindow;
      basicRunMenuCommand14.EnableCommand = false;
      basicRunMenuCommand14.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.PrintCommand = (MapInfoCommand) basicRunMenuCommand14;
      ApplicationCommands.PrintCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand((int) sbyte.MaxValue, nameof (PrintToPDF), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_PrintToPDF_Label;
      basicRunMenuCommand15.MenuItemText = Resources.Command_PrintToPDF_MenuItemText;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/printToPdf_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/printToPdf_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_PrintToPDF_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_PrintToPDF_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_Disabled_NeedInstalledPdfDriverAndFrontDocumentWindow;
      basicRunMenuCommand15.EnableCommand = false;
      basicRunMenuCommand15.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.PrintToPDFCommand = (MapInfoCommand) basicRunMenuCommand15;
      ApplicationCommands.PrintToPDFCommand.CreateScreenTip();
      MapInfo.Commands.ExitCommand exitCommand = new MapInfo.Commands.ExitCommand(113, nameof (Exit), MapInfoCommand.GetGesture(Resources.Command_Exit_KeyGesture));
      exitCommand.Text = Resources.Command_Exit_Label;
      exitCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/exitWhite_64x64.png";
      exitCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/exitWhite_64x64.png";
      exitCommand.ToolTipDescription = Resources.Command_Exit_ToolTip_Description;
      exitCommand.ToolTipText = Resources.Command_Exit_ToolTip_Text;
      exitCommand.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      exitCommand.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.ExitCommand = (MapInfoCommand) exitCommand;
      ApplicationCommands.ExitCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(132, nameof (OpenWorkspace), MapInfoCommand.GetGesture(Resources.Command_OpenWorkspace_KeyGesture));
      basicRunMenuCommand16.Text = Resources.Command_OpenWorkspace_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWorkspace_16x16.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWorkspace_32x32.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_OpenWorkspace_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_OpenWorkspace_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand16.EnableCommand = true;
      basicRunMenuCommand16.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.OpenWorkspaceCommand = (MapInfoCommand) basicRunMenuCommand16;
      ApplicationCommands.OpenWorkspaceCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(108, nameof (AddWorkspace), MapInfoCommand.GetGesture(Resources.Command_AddWorkspace_KeyGesture));
      basicRunMenuCommand17.Text = Resources.Command_AddWorkspace_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/insertWorkspace_16x16.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/insertWorkspace_32x32.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_AddWorkspace_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_AddWorkspace_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand17.EnableCommand = true;
      basicRunMenuCommand17.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.AddWorkspaceCommand = (MapInfoCommand) basicRunMenuCommand17;
      ApplicationCommands.AddWorkspaceCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(110, nameof (RunMapBasic), MapInfoCommand.GetGesture(Resources.Command_RunMapBasic_KeyGesture));
      basicRunMenuCommand18.Text = Resources.Command_RunMapBasic_Label;
      basicRunMenuCommand18.MenuItemText = Resources.Command_RunMapBasic_MenuItemText;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/toolManager_16x16.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/toolManager_32x32.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_RunMapBasic_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_RunMapBasic_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand18.EnableCommand = true;
      basicRunMenuCommand18.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.RunMapBasicCommand = (MapInfoCommand) basicRunMenuCommand18;
      ApplicationCommands.RunMapBasicCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(111, nameof (PageSetup), (InputGestureCollection) null);
      basicRunMenuCommand19.Text = Resources.Command_PageSetup_Label;
      basicRunMenuCommand19.MenuItemText = Resources.Command_PageSetup_MenuItemText;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/margins_16x16.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Layout/margins_32x32.png";
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_PageSetup_ToolTip_Description;
      basicRunMenuCommand19.ToolTipText = Resources.Command_PageSetup_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenTable;
      basicRunMenuCommand19.EnableCommand = false;
      basicRunMenuCommand19.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.PageSetupCommand = (MapInfoCommand) basicRunMenuCommand19;
      ApplicationCommands.PageSetupCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand20 = new MapBasicRunMenuCommand(1811, nameof (GetMapBasicUtilities), (InputGestureCollection) null);
      basicRunMenuCommand20.Text = Resources.Command_GetMapBasicUtilities_Label;
      basicRunMenuCommand20.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/getTools_16x16.png";
      basicRunMenuCommand20.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/getTools_32x32.png";
      basicRunMenuCommand20.ToolTipDescription = Resources.Command_GetMapBasicUtilities_ToolTip_Description;
      basicRunMenuCommand20.ToolTipText = Resources.Command_GetMapBasicUtilities_ToolTip_Text;
      basicRunMenuCommand20.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand20.EnableCommand = true;
      basicRunMenuCommand20.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.GetMapBasicUtilitiesCommand = (MapInfoCommand) basicRunMenuCommand20;
      ApplicationCommands.GetMapBasicUtilitiesCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand21 = new MapBasicRunMenuCommand(401, nameof (Import), (InputGestureCollection) null);
      basicRunMenuCommand21.Text = Resources.Command_Import_Label;
      basicRunMenuCommand21.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/import_16x16.png";
      basicRunMenuCommand21.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/import_32x32.png";
      basicRunMenuCommand21.ToolTipDescription = Resources.Command_Import_ToolTip_Description;
      basicRunMenuCommand21.ToolTipText = Resources.Command_Import_ToolTip_Text;
      basicRunMenuCommand21.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand21.EnableCommand = true;
      basicRunMenuCommand21.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.ImportCommand = (MapInfoCommand) basicRunMenuCommand21;
      ApplicationCommands.ImportCommand.CreateScreenTip();
      RunEditMapBasicCommand editMapBasicCommand = new RunEditMapBasicCommand(nameof (RunCurrentMapBasic), (InputGestureCollection) null);
      editMapBasicCommand.Text = Resources.Command_RunCurrentMapBasic_Label;
      editMapBasicCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/mapbasicWindow_16x16.png";
      editMapBasicCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/mapbasicWindow_32x32.png";
      editMapBasicCommand.ToolTipDescription = Resources.Command_RunCurrentMapBasic_ToolTip_Description;
      editMapBasicCommand.ToolTipText = Resources.Command_RunCurrentMapBasic_ToolTip_Text;
      editMapBasicCommand.ToolTipDisabledText = Resources.Command_Disabled_NeedSelectedCommand;
      editMapBasicCommand.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.RunCurrentEditMapBasicCommand = (MapInfoCommand) editMapBasicCommand;
      ApplicationCommands.RunCurrentEditMapBasicCommand.CreateScreenTip();
      ClearEditContentCommand editContentCommand1 = new ClearEditContentCommand(nameof (ClearEditContents), (InputGestureCollection) null);
      editContentCommand1.Text = Resources.Command_ClearEditContent_Label;
      editContentCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/clearMapbasicWindow_16x16.png";
      editContentCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/clearMapbasicWindow_32x32.png";
      editContentCommand1.ToolTipDescription = Resources.Command_ClearEditContent_ToolTip_Description;
      editContentCommand1.ToolTipText = Resources.Command_ClearEditContent_ToolTip_Text;
      editContentCommand1.ToolTipDisabledText = Resources.Command_Disabled_NeedContent;
      editContentCommand1.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.ClearEditContentsCommand = (MapInfoCommand) editContentCommand1;
      ApplicationCommands.ClearEditContentsCommand.CreateScreenTip();
      SaveEditContentCommand editContentCommand2 = new SaveEditContentCommand(nameof (SaveEditContents), (InputGestureCollection) null);
      editContentCommand2.Text = Resources.Command_SaveEditContent_Label;
      editContentCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveTable_16x16.png";
      editContentCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/saveTable_32x32.png";
      editContentCommand2.ToolTipDescription = Resources.Command_SaveEditContent_ToolTip_Description;
      editContentCommand2.ToolTipText = Resources.Command_SaveEditContent_ToolTip_Text;
      editContentCommand2.ToolTipDisabledText = Resources.Command_Disabled_NeedContent;
      editContentCommand2.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.SaveEditContentsCommand = (MapInfoCommand) editContentCommand2;
      ApplicationCommands.SaveEditContentsCommand.CreateScreenTip();
      UrlOpenCommands urlOpenCommands = new UrlOpenCommands();
      urlOpenCommands.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/products_64x64.png";
      urlOpenCommands.ToolTipText = Resources.Command_OpenUrl_ToolTip_Text;
      urlOpenCommands.ToolTipDescription = Resources.Command_OpenUrl_ToolTip_Description;
      urlOpenCommands.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      ApplicationCommands.OpenUrlCommand = urlOpenCommands;
      ApplicationCommands.OpenUrlCommand.CreateScreenTip();
      SystemInfoCommands systemInfoCommands = new SystemInfoCommands();
      systemInfoCommands.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/about_64x64.png";
      systemInfoCommands.ToolTipText = Resources.Command_SystemInfo_ToolTip_Text;
      systemInfoCommands.ToolTipDescription = Resources.Command_SystemInfo_ToolTip_Description;
      systemInfoCommands.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      ApplicationCommands.SystemInfoCommand = systemInfoCommands;
      ApplicationCommands.SystemInfoCommand.CreateScreenTip();
      CustomCallbackHandlerCommand callbackHandlerCommand = new CustomCallbackHandlerCommand("CustomCallbackHandler", (InputGestureCollection) null);
      callbackHandlerCommand.Text = Resources.Command_CustomCallbackHandler_Label;
      callbackHandlerCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tools_16x16.png";
      callbackHandlerCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tools_32x32.png";
      callbackHandlerCommand.ToolTipDescription = Resources.Command_CustomCallbackHandler_ToolTip_Description;
      callbackHandlerCommand.ToolTipText = Resources.Command_CustomCallbackHandler_ToolTip_Text;
      callbackHandlerCommand.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      callbackHandlerCommand.Category = Resources.Command_Category_ApplicationCommands;
      ApplicationCommands.CustomMapBasicRoutineCommand = (MapInfoCommand) callbackHandlerCommand;
      ApplicationCommands.CustomMapBasicRoutineCommand.CreateScreenTip();
      CustomMapBasicToolButtonCommand toolButtonCommand = new CustomMapBasicToolButtonCommand(nameof (CustomToolButton), (InputGestureCollection) null);
      toolButtonCommand.Text = Resources.Command_CustomToolButton_Label;
      toolButtonCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tools_16x16.png";
      toolButtonCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Window/tools_32x32.png";
      toolButtonCommand.ToolTipDescription = Resources.Command_CustomToolButton_ToolTip_Description;
      toolButtonCommand.ToolTipText = Resources.Command_CustomToolButton_ToolTip_Text;
      toolButtonCommand.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      toolButtonCommand.Category = Resources.Command_Category_ApplicationCommands;
      toolButtonCommand.EnableCommand = false;
      ApplicationCommands.CustomToolButtonCommand = (MapInfoCommand) toolButtonCommand;
      ApplicationCommands.CustomToolButtonCommand.CreateScreenTip();
    }

    public static MapInfoCommand NewTable
    {
      get
      {
        return ApplicationCommands.NewTableCommand;
      }
    }

    public static MapInfoCommand OpenTable
    {
      get
      {
        return ApplicationCommands.OpenTableCommand;
      }
    }

    public static MapInfoCommand OpenDBMS
    {
      get
      {
        return ApplicationCommands.OpenDBMSCommand;
      }
    }

    public static MapInfoCommand OpenUniversalData
    {
      get
      {
        return ApplicationCommands.OpenUniversalDataCommand;
      }
    }

    public static MapInfoCommand Import
    {
      get
      {
        return ApplicationCommands.ImportCommand;
      }
    }

    public static MapInfoCommand CloseTable
    {
      get
      {
        return ApplicationCommands.CloseTableCommand;
      }
    }

    public static MapInfoCommand CloseAll
    {
      get
      {
        return ApplicationCommands.CloseAllCommand;
      }
    }

    public static MapInfoCommand CloseDBMS
    {
      get
      {
        return ApplicationCommands.CloseDBMSCommand;
      }
    }

    public static MapInfoCommand SaveTable
    {
      get
      {
        return ApplicationCommands.SaveTableCommand;
      }
    }

    public static MapInfoCommand SaveCopyAs
    {
      get
      {
        return ApplicationCommands.SaveCopyAsCommand;
      }
    }

    public static MapInfoCommand SaveQuery
    {
      get
      {
        return ApplicationCommands.SaveQueryCommand;
      }
    }

    public static MapInfoCommand SaveWorkspace
    {
      get
      {
        return ApplicationCommands.SaveWorkspaceCommand;
      }
    }

    public static MapInfoCommand SaveWindowAs
    {
      get
      {
        return ApplicationCommands.SaveWindowAsCommand;
      }
    }

    public static MapInfoCommand Print
    {
      get
      {
        return ApplicationCommands.PrintCommand;
      }
    }

    public static MapInfoCommand PrintToPDF
    {
      get
      {
        return ApplicationCommands.PrintToPDFCommand;
      }
    }

    public static MapInfoCommand Exit
    {
      get
      {
        return ApplicationCommands.ExitCommand;
      }
    }

    public static MapInfoCommand OpenWorkspace
    {
      get
      {
        return ApplicationCommands.OpenWorkspaceCommand;
      }
    }

    public static MapInfoCommand AddWorkspace
    {
      get
      {
        return ApplicationCommands.AddWorkspaceCommand;
      }
    }

    public static MapInfoCommand RunMapBasic
    {
      get
      {
        return ApplicationCommands.RunMapBasicCommand;
      }
    }

    public static MapInfoCommand PageSetup
    {
      get
      {
        return ApplicationCommands.PageSetupCommand;
      }
    }

    public static MapInfoCommand GetMapBasicUtilities
    {
      get
      {
        return ApplicationCommands.GetMapBasicUtilitiesCommand;
      }
    }

    public static MapInfoCommand RunCurrentMapBasic
    {
      get
      {
        return ApplicationCommands.RunCurrentEditMapBasicCommand;
      }
    }

    public static MapInfoCommand ClearEditContents
    {
      get
      {
        return ApplicationCommands.ClearEditContentsCommand;
      }
    }

    public static MapInfoCommand SaveEditContents
    {
      get
      {
        return ApplicationCommands.SaveEditContentsCommand;
      }
    }

    public static UrlOpenCommands OpenUrl
    {
      get
      {
        return ApplicationCommands.OpenUrlCommand;
      }
    }

    public static SystemInfoCommands SystemInfo
    {
      get
      {
        return ApplicationCommands.SystemInfoCommand;
      }
    }

    public static MapInfoCommand CustomMapBasicHandler
    {
      get
      {
        return ApplicationCommands.CustomMapBasicRoutineCommand;
      }
    }

    public static MapInfoCommand CustomToolButton
    {
      get
      {
        return ApplicationCommands.CustomToolButtonCommand;
      }
    }

    public static MapInfoCommand SaveCurrentWorkspace
    {
      get
      {
        return ApplicationCommands.SaveCurrentWorkspaceCommand;
      }
    }
  }
}
