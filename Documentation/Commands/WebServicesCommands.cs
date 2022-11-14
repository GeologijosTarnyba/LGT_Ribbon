// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.WebServicesCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class WebServicesCommands
  {
    private static readonly MapBasicRunMenuCommand _openWmsCommand;
    private static readonly MapBasicRunMenuCommand _openWfsCommand;
    private static readonly MapBasicRunMenuCommand _wmsPropsCommand;
    private static readonly MapBasicRunMenuCommand _wfsPropsCommand;
    private static readonly MapBasicRunMenuCommand _wfsRefreshCommand;
    private static readonly MapBasicRunMenuCommand _openWmtsCommand;
    private static readonly MapBasicRunMenuCommand _wmtsPropsCommand;
    private static readonly MapBasicRunMenuCommand _serverList;
    private static readonly CommerceCloudLogout _logout;
    private static readonly OpenCommerceCloudDialog _loginCommerceCloudDialog;
    private static readonly OpenCommerceCloudDialog _signUpCommerceCloudDialog;

    static WebServicesCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(118, nameof (OpenWms), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_OpenWms_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWms_16x16.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWms_32x32.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_OpenWms_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_OpenWms_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._openWmsCommand = basicRunMenuCommand1;
      WebServicesCommands._openWmsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(236, "ServerList", (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_OpenWms_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWms_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWms_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_OpenWms_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_OpenWms_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.EnableCommand = true;
      basicRunMenuCommand2.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._serverList = basicRunMenuCommand2;
      WebServicesCommands._serverList.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(119, nameof (OpenWfs), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_OpenWfs_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWfs_16x16.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWfs_32x32.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_OpenWfs_ToolTip_Description;
      basicRunMenuCommand3.ToolTipText = Resources.Command_OpenWfs_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = true;
      basicRunMenuCommand3.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._openWfsCommand = basicRunMenuCommand3;
      WebServicesCommands._openWfsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(120, nameof (OpenWmts), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_OpenWmts_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWmts_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/openWmts_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_OpenWmts_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_OpenWmts_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand4.EnableCommand = true;
      basicRunMenuCommand4.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._openWmtsCommand = basicRunMenuCommand4;
      WebServicesCommands._openWmtsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(421, nameof (WmsProps), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_WmsProps_Label;
      basicRunMenuCommand5.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWMS_16x16.png";
      basicRunMenuCommand5.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWMS_32x32.png";
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_WmsProps_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_WmsProps_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWmsTable;
      basicRunMenuCommand5.EnableCommand = false;
      basicRunMenuCommand5.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._wmsPropsCommand = basicRunMenuCommand5;
      WebServicesCommands._wmsPropsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(427, nameof (WmtsProps), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_WmtsProps_Label;
      basicRunMenuCommand6.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWMTS_16x16.png";
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWMTS_32x32.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_WmtsProps_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_WmtsProps_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWmtsTable;
      basicRunMenuCommand6.EnableCommand = false;
      basicRunMenuCommand6.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._wmtsPropsCommand = basicRunMenuCommand6;
      WebServicesCommands._wmtsPropsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(423, nameof (WfsProps), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_WfsProps_Label;
      basicRunMenuCommand7.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWFS_16x16.png";
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/configWFS_32x32.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_WfsProps_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_WfsProps_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWfsTable;
      basicRunMenuCommand7.EnableCommand = false;
      basicRunMenuCommand7.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._wfsPropsCommand = basicRunMenuCommand7;
      WebServicesCommands._wfsPropsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(422, nameof (WfsRefresh), MapInfoCommand.GetGesture(Resources.Command_WfsRefresh_KeyGesture));
      basicRunMenuCommand8.Text = Resources.Command_WfsRefresh_Label;
      basicRunMenuCommand8.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_16x16.png";
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_32x32.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_WfsRefresh_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_WfsRefresh_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWfsTable;
      basicRunMenuCommand8.EnableCommand = false;
      basicRunMenuCommand8.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._wfsRefreshCommand = basicRunMenuCommand8;
      WebServicesCommands._wfsRefreshCommand.CreateScreenTip();
      OpenCommerceCloudDialog commerceCloudDialog1 = new OpenCommerceCloudDialog(true);
      commerceCloudDialog1.Text = "Open LI API sign up dialog";
      commerceCloudDialog1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_16x16.png";
      commerceCloudDialog1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_32x32.png";
      commerceCloudDialog1.ToolTipDescription = Resources.Command_WfsRefresh_ToolTip_Description;
      commerceCloudDialog1.ToolTipText = Resources.Command_WfsRefresh_ToolTip_Text;
      commerceCloudDialog1.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWfsTable;
      commerceCloudDialog1.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._signUpCommerceCloudDialog = commerceCloudDialog1;
      WebServicesCommands._signUpCommerceCloudDialog.CreateScreenTip();
      OpenCommerceCloudDialog commerceCloudDialog2 = new OpenCommerceCloudDialog(false);
      commerceCloudDialog2.Text = "Open LI API sign up dialog";
      commerceCloudDialog2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_16x16.png";
      commerceCloudDialog2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_32x32.png";
      commerceCloudDialog2.ToolTipDescription = Resources.Command_WfsRefresh_ToolTip_Description;
      commerceCloudDialog2.ToolTipText = Resources.Command_WfsRefresh_ToolTip_Text;
      commerceCloudDialog2.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWfsTable;
      commerceCloudDialog2.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._loginCommerceCloudDialog = commerceCloudDialog2;
      WebServicesCommands._loginCommerceCloudDialog.CreateScreenTip();
      CommerceCloudLogout commerceCloudLogout = new CommerceCloudLogout();
      commerceCloudLogout.Text = "Log the current user out of the Commerce Cloud";
      commerceCloudLogout.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_16x16.png";
      commerceCloudLogout.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Table/refreshConnection_32x32.png";
      commerceCloudLogout.ToolTipDescription = Resources.Command_WfsRefresh_ToolTip_Description;
      commerceCloudLogout.ToolTipText = Resources.Command_WfsRefresh_ToolTip_Text;
      commerceCloudLogout.ToolTipDisabledText = Resources.Command_Disabled_NeedOpenWfsTable;
      commerceCloudLogout.Category = Resources.Command_Category_WebServiceCommands;
      WebServicesCommands._logout = commerceCloudLogout;
      WebServicesCommands._logout.CreateScreenTip();
    }

    public static MapInfoCommand OpenServerList
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._serverList;
      }
    }

    public static MapInfoCommand OpenWms
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._openWmsCommand;
      }
    }

    public static MapInfoCommand OpenWfs
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._openWfsCommand;
      }
    }

    public static MapInfoCommand OpenWmts
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._openWmtsCommand;
      }
    }

    public static MapInfoCommand WmsProps
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._wmsPropsCommand;
      }
    }

    public static MapInfoCommand WmtsProps
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._wmtsPropsCommand;
      }
    }

    public static MapInfoCommand WfsProps
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._wfsPropsCommand;
      }
    }

    public static MapInfoCommand WfsRefresh
    {
      get
      {
        return (MapInfoCommand) WebServicesCommands._wfsRefreshCommand;
      }
    }

    public static OpenCommerceCloudDialog OpenSignUpDialog
    {
      get
      {
        return WebServicesCommands._signUpCommerceCloudDialog;
      }
    }

    public static OpenCommerceCloudDialog OpenLoginDialog
    {
      get
      {
        return WebServicesCommands._loginCommerceCloudDialog;
      }
    }

    public static CommerceCloudLogout Logout
    {
      get
      {
        return WebServicesCommands._logout;
      }
    }
  }
}
