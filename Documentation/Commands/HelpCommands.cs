// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.HelpCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Constants;
using MapInfo.Controls.Properties;
using System.Windows.Input;

namespace MapInfo.Commands
{
  public static class HelpCommands
  {
    private static readonly MapBasicRunMenuCommand HelpContentsCommand;
    private static readonly MapBasicRunMenuCommand HelpSearchCommand;
    private static readonly MapBasicRunMenuCommand AboutCommand;
    private static readonly MapBasicRunMenuCommand TechSupportCommand;
    private static readonly MapBasicRunMenuCommand MapInfoWwwStoreEuroCommand;
    private static readonly MapBasicRunMenuCommand MapInfoWwwCommand;
    private static readonly MapBasicRunMenuCommand MapInfoWwwStoreCommand;
    private static readonly MapBasicRunMenuCommand SmartUpdateCommand;
    private static readonly MapBasicRunMenuCommand WwwTutorialCommand;
    private static readonly MapBasicRunMenuCommand TransferLicenseCommand;
    private static readonly MapBasicRunMenuCommand BorrowLicenseCommand;
    private static readonly MapBasicRunMenuCommand ReturnBorrowedLicenseCommand;
    private static readonly MapBasicRunMenuCommand ProductFeedbackCommand;
    private static readonly MapBasicRunMenuCommand BingTermsOfUseCommand;
    private static readonly MapBasicRunMenuCommand MapInfoNewsfeedCommand;
    private static readonly MapBasicRunMenuCommand UserBingKeyCommand;
    private static readonly MapBasicRunMenuCommand StartAdvancedEvaluationCommand;
    private static readonly MapBasicRunMenuCommand ActivateAdvancedLicenseCommand;
    private static readonly MapBasicRunMenuCommand ActivateFlexeraLicenseForSubscriptionLicensedUserCommand;
    private static readonly LicenseDocumentationCommand LicenseDocumentCommand;
    private static readonly CopyrightCommand CopyrightCommand;
    private static readonly ContextHelpCommands ContextHelpCommand;

    static HelpCommands()
    {
      MapBasicRunMenuCommand basicRunMenuCommand1 = new MapBasicRunMenuCommand(1202, nameof (HelpContents), (InputGestureCollection) null);
      basicRunMenuCommand1.Text = Resources.Command_HelpContents_Label;
      basicRunMenuCommand1.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/search_64x64.png";
      basicRunMenuCommand1.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/search_64x64.png";
      basicRunMenuCommand1.ToolTipDescription = Resources.Command_HelpContents_ToolTip_Description;
      basicRunMenuCommand1.ToolTipText = Resources.Command_HelpContents_ToolTip_Text;
      basicRunMenuCommand1.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand1.EnableCommand = true;
      basicRunMenuCommand1.CustomHelpId = new int?(MapInfoConstants.HelpSearchHelpId);
      basicRunMenuCommand1.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.HelpContentsCommand = basicRunMenuCommand1;
      HelpCommands.HelpContentsCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand2 = new MapBasicRunMenuCommand(1203, nameof (HelpSearch), (InputGestureCollection) null);
      basicRunMenuCommand2.Text = Resources.Command_HelpSearch_Label;
      basicRunMenuCommand2.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_16x16.png";
      basicRunMenuCommand2.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_32x32.png";
      basicRunMenuCommand2.ToolTipDescription = Resources.Command_HelpSearch_ToolTip_Description;
      basicRunMenuCommand2.ToolTipText = Resources.Command_HelpSearch_ToolTip_Text;
      basicRunMenuCommand2.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand2.EnableCommand = true;
      basicRunMenuCommand2.CustomHelpId = new int?(MapInfoConstants.HelpSearchHelpId);
      basicRunMenuCommand2.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.HelpSearchCommand = basicRunMenuCommand2;
      HelpCommands.HelpSearchCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand3 = new MapBasicRunMenuCommand(1205, nameof (About), (InputGestureCollection) null);
      basicRunMenuCommand3.Text = Resources.Command_About_Label;
      basicRunMenuCommand3.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/about_32x32.png";
      basicRunMenuCommand3.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/about_48x48.png";
      basicRunMenuCommand3.ToolTipDescription = Resources.Command_About_ToolTip_Desciption;
      basicRunMenuCommand3.ToolTipText = Resources.Command_About_ToolTip_Text;
      basicRunMenuCommand3.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand3.EnableCommand = true;
      basicRunMenuCommand3.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.AboutCommand = basicRunMenuCommand3;
      HelpCommands.AboutCommand.CreateScreenTip();
      HelpCommands.ContextHelpCommand = new ContextHelpCommands();
      MapBasicRunMenuCommand basicRunMenuCommand4 = new MapBasicRunMenuCommand(1212, nameof (SmartUpdate), (InputGestureCollection) null);
      basicRunMenuCommand4.Text = Resources.Command_SmartUpdate_Label;
      basicRunMenuCommand4.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_16x16.png";
      basicRunMenuCommand4.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_32x32.png";
      basicRunMenuCommand4.ToolTipDescription = Resources.Command_SmartUpdate_ToolTip_Description;
      basicRunMenuCommand4.ToolTipText = Resources.Command_SmartUpdate_ToolTip_Text;
      basicRunMenuCommand4.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand4.EnableCommand = true;
      basicRunMenuCommand4.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.SmartUpdateCommand = basicRunMenuCommand4;
      HelpCommands.SmartUpdateCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand5 = new MapBasicRunMenuCommand(1221, nameof (MapInfoNewsfeed), (InputGestureCollection) null);
      basicRunMenuCommand5.Text = Resources.Command_MapInfoNewsfeed_Label;
      basicRunMenuCommand5.ToolTipDescription = Resources.Command_MapInfoNewsfeed_ToolTip_Description;
      basicRunMenuCommand5.ToolTipText = Resources.Command_MapInfoNewsfeed_ToolTip_Text;
      basicRunMenuCommand5.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand5.EnableCommand = true;
      basicRunMenuCommand5.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.MapInfoNewsfeedCommand = basicRunMenuCommand5;
      HelpCommands.MapInfoNewsfeedCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand6 = new MapBasicRunMenuCommand(1216, nameof (TransferLicense), (InputGestureCollection) null);
      basicRunMenuCommand6.Text = Resources.Command_TransferLicense_Label;
      basicRunMenuCommand6.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/transferLicense_64x64.png";
      basicRunMenuCommand6.ToolTipDescription = Resources.Command_TransferLicense_ToolTip_Description;
      basicRunMenuCommand6.ToolTipText = Resources.Command_TransferLicense_ToolTip_Text;
      basicRunMenuCommand6.ToolTipDisabledText = Resources.Command_TransferLicense_Tooltip_Disabled_Text;
      basicRunMenuCommand6.EnableCommand = true;
      basicRunMenuCommand6.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.TransferLicenseCommand = basicRunMenuCommand6;
      HelpCommands.TransferLicenseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand7 = new MapBasicRunMenuCommand(1217, nameof (BorrowLicense), (InputGestureCollection) null);
      basicRunMenuCommand7.Text = Resources.Command_BorrowLicense_Label;
      basicRunMenuCommand7.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/borrowLicense_64x64.png";
      basicRunMenuCommand7.ToolTipDescription = Resources.Command_BorrowLicense_ToolTip_Description;
      basicRunMenuCommand7.ToolTipText = Resources.Command_BorrowLicense_ToolTip_Text;
      basicRunMenuCommand7.ToolTipDisabledText = Resources.Command_BorrowLicense_Tooltip_Disabled_Text;
      basicRunMenuCommand7.EnableCommand = true;
      basicRunMenuCommand7.CustomHelpId = new int?(9620);
      basicRunMenuCommand7.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.BorrowLicenseCommand = basicRunMenuCommand7;
      HelpCommands.BorrowLicenseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand8 = new MapBasicRunMenuCommand(1218, nameof (ReturnBorrowedLicense), (InputGestureCollection) null);
      basicRunMenuCommand8.Text = Resources.Command_ReturnBorrowedLicense_Label;
      basicRunMenuCommand8.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/returnLicense_64x64.png";
      basicRunMenuCommand8.ToolTipDescription = Resources.Command_ReturnBorrowedLicense_ToolTip_Description;
      basicRunMenuCommand8.ToolTipText = Resources.Command_ReturnBorrowedLicense_ToolTip_Text;
      basicRunMenuCommand8.ToolTipDisabledText = Resources.Command_ReturnBorrowedLicense_Tooltip_Disabled_Text;
      basicRunMenuCommand8.EnableCommand = true;
      basicRunMenuCommand8.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.ReturnBorrowedLicenseCommand = basicRunMenuCommand8;
      HelpCommands.ReturnBorrowedLicenseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand9 = new MapBasicRunMenuCommand(1223, nameof (StartAdvancedEvaluation), (InputGestureCollection) null);
      basicRunMenuCommand9.Text = Resources.Command_StartAdvancedEvaluation_Label;
      basicRunMenuCommand9.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/advancedLicense.png";
      basicRunMenuCommand9.ToolTipDescription = Resources.Command_StartAdvancedEvaluation_ToolTip_Description;
      basicRunMenuCommand9.ToolTipText = Resources.Command_StartAdvancedEvaluation_ToolTip_Text;
      basicRunMenuCommand9.EnableCommand = true;
      basicRunMenuCommand9.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.StartAdvancedEvaluationCommand = basicRunMenuCommand9;
      HelpCommands.StartAdvancedEvaluationCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand10 = new MapBasicRunMenuCommand(1224, nameof (ActivateAdvancedLicense), (InputGestureCollection) null);
      basicRunMenuCommand10.Text = Resources.Command_ActivateAdvancedLicense_Label;
      basicRunMenuCommand10.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/advancedLicense.png";
      basicRunMenuCommand10.ToolTipDescription = Resources.Command_ActivateAdvancedLicense_ToolTip_Description;
      basicRunMenuCommand10.ToolTipText = Resources.Command_ActivateAdvancedLicense_ToolTip_Text;
      basicRunMenuCommand10.ToolTipDisabledText = Resources.Command_ActivateAdvancedLicense_Tooltip_Disabled_Text;
      basicRunMenuCommand10.EnableCommand = true;
      basicRunMenuCommand10.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.ActivateAdvancedLicenseCommand = basicRunMenuCommand10;
      HelpCommands.ActivateAdvancedLicenseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand11 = new MapBasicRunMenuCommand(1225, nameof (ActivateFlexeraLicenseForSubscriptionLicensedUser), (InputGestureCollection) null);
      basicRunMenuCommand11.Text = Resources.Command_ActivateFlexeraLicenseForSubscriptionLicensedUser_Label;
      basicRunMenuCommand11.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/advancedLicense.png";
      basicRunMenuCommand11.ToolTipDescription = Resources.Command_ActivateFlexeraLicenseForSubscriptionLicensedUser_ToolTip_Description;
      basicRunMenuCommand11.ToolTipText = Resources.Command_ActivateFlexeraLicenseForSubscriptionLicensedUser_ToolTip_Text;
      basicRunMenuCommand11.ToolTipDisabledText = Resources.Command_ActivateFlexeraLicenseForSubscriptionLicensedUser_ToolTip_Disabled_Text;
      basicRunMenuCommand11.EnableCommand = true;
      basicRunMenuCommand11.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUserCommand = basicRunMenuCommand11;
      HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUserCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand12 = new MapBasicRunMenuCommand(1222, nameof (UserBingKey), (InputGestureCollection) null);
      basicRunMenuCommand12.Text = Resources.Command_UserBingKey_Label;
      basicRunMenuCommand12.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/bingKey_64x64.png";
      basicRunMenuCommand12.ToolTipDescription = Resources.Command_UserBingKey_ToolTip_Description;
      basicRunMenuCommand12.ToolTipText = Resources.Command_UserBingKey_ToolTip_Text;
      basicRunMenuCommand12.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand12.EnableCommand = true;
      basicRunMenuCommand12.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.UserBingKeyCommand = basicRunMenuCommand12;
      HelpCommands.UserBingKeyCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand13 = new MapBasicRunMenuCommand(1219, nameof (ProductFeedback), (InputGestureCollection) null);
      basicRunMenuCommand13.Text = Resources.Command_ProductFeedback_Label;
      basicRunMenuCommand13.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/suggestions_32x32.png";
      basicRunMenuCommand13.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/suggestions_48x48.png";
      basicRunMenuCommand13.ToolTipDescription = Resources.Command_ProductFeedback_ToolTip_Description;
      basicRunMenuCommand13.ToolTipText = Resources.Command_ProductFeedback_ToolTip_Text;
      basicRunMenuCommand13.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand13.EnableCommand = true;
      basicRunMenuCommand13.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.ProductFeedbackCommand = basicRunMenuCommand13;
      HelpCommands.ProductFeedbackCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand14 = new MapBasicRunMenuCommand(1210, nameof (MapInfoWww), (InputGestureCollection) null);
      basicRunMenuCommand14.Text = Resources.Command_MapInfoWww_Label;
      basicRunMenuCommand14.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/products_64x64.png";
      basicRunMenuCommand14.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/products_64x64.png";
      basicRunMenuCommand14.ToolTipDescription = Resources.Command_MapInfoWww_ToolTip_Description;
      basicRunMenuCommand14.ToolTipText = Resources.Command_MapInfoWww_ToolTip_Text;
      basicRunMenuCommand14.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand14.EnableCommand = true;
      basicRunMenuCommand14.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.MapInfoWwwCommand = basicRunMenuCommand14;
      HelpCommands.MapInfoWwwCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand15 = new MapBasicRunMenuCommand(1220, nameof (BingTermsOfUse), (InputGestureCollection) null);
      basicRunMenuCommand15.Text = Resources.Command_BingTermsOfUse_Label;
      basicRunMenuCommand15.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_16x16.png";
      basicRunMenuCommand15.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_32x32.png";
      basicRunMenuCommand15.ToolTipDescription = Resources.Command_BingTermsOfUse_ToolTip_Description;
      basicRunMenuCommand15.ToolTipText = Resources.Command_BingTermsOfUse_ToolTip_Text;
      basicRunMenuCommand15.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand15.EnableCommand = true;
      basicRunMenuCommand15.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.BingTermsOfUseCommand = basicRunMenuCommand15;
      HelpCommands.BingTermsOfUseCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand16 = new MapBasicRunMenuCommand(1208, nameof (TechSupport), (InputGestureCollection) null);
      basicRunMenuCommand16.Text = Resources.Command_TechSupport_Label;
      basicRunMenuCommand16.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_64x64.png";
      basicRunMenuCommand16.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/help_64x64.png";
      basicRunMenuCommand16.ToolTipDescription = Resources.Command_TechSupport_ToolTip_Description;
      basicRunMenuCommand16.ToolTipText = Resources.Command_TechSupport_ToolTip_Text;
      basicRunMenuCommand16.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand16.EnableCommand = true;
      basicRunMenuCommand16.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.TechSupportCommand = basicRunMenuCommand16;
      HelpCommands.TechSupportCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand17 = new MapBasicRunMenuCommand(1211, nameof (MapInfoWwwStore), (InputGestureCollection) null);
      basicRunMenuCommand17.Text = Resources.Command_MapInfoWwwStore_Label;
      basicRunMenuCommand17.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/onlineStore_32x32.png";
      basicRunMenuCommand17.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/onlineStore_48x48.png";
      basicRunMenuCommand17.ToolTipDescription = Resources.Command_MapInfoWwwStore_ToolTip_Description;
      basicRunMenuCommand17.ToolTipText = Resources.Command_MapInfoWwwStore_ToolTip_Text;
      basicRunMenuCommand17.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand17.EnableCommand = true;
      basicRunMenuCommand17.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.MapInfoWwwStoreCommand = basicRunMenuCommand17;
      HelpCommands.MapInfoWwwStoreCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand18 = new MapBasicRunMenuCommand(1209, "MapInfoWwwEuroStore", (InputGestureCollection) null);
      basicRunMenuCommand18.Text = Resources.Command_MapInfoWwwEuroStore_Label;
      basicRunMenuCommand18.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/onlineStore_32x32.png";
      basicRunMenuCommand18.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/onlineStore_48x48.png";
      basicRunMenuCommand18.ToolTipDescription = Resources.Command_MapInfoWwwStore_ToolTip_Description;
      basicRunMenuCommand18.ToolTipText = Resources.Command_MapInfoWwwStore_ToolTip_Text;
      basicRunMenuCommand18.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand18.EnableCommand = true;
      basicRunMenuCommand18.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.MapInfoWwwStoreEuroCommand = basicRunMenuCommand18;
      HelpCommands.MapInfoWwwStoreEuroCommand.CreateScreenTip();
      MapBasicRunMenuCommand basicRunMenuCommand19 = new MapBasicRunMenuCommand(1213, nameof (WwwTutorial), (InputGestureCollection) null);
      basicRunMenuCommand19.Text = Resources.Command_WwwTutorial_Label;
      basicRunMenuCommand19.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/video_64x64.png";
      basicRunMenuCommand19.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/video_64x64.png";
      basicRunMenuCommand19.ToolTipDescription = Resources.Command_WwwTutorial_ToolTip_Description;
      basicRunMenuCommand19.ToolTipText = Resources.Command_WwwTutorial_ToolTip_Text;
      basicRunMenuCommand19.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      basicRunMenuCommand19.EnableCommand = true;
      basicRunMenuCommand19.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.WwwTutorialCommand = basicRunMenuCommand19;
      HelpCommands.WwwTutorialCommand.CreateScreenTip();
      LicenseDocumentationCommand documentationCommand = new LicenseDocumentationCommand(nameof (LicenseDocument), (InputGestureCollection) null);
      documentationCommand.Text = Resources.About_Licensing_Button_Text;
      documentationCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/bingKey_64x64.png";
      documentationCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/bingKey_64x64.png";
      documentationCommand.ToolTipDescription = Resources.Command_About_License_Tooltip_Description;
      documentationCommand.ToolTipText = Resources.Command_About_License_Tooltip_Text;
      documentationCommand.ToolTipDisabledText = Resources.Command_About_License_Tooltip_Disabled_Text;
      documentationCommand.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.LicenseDocumentCommand = documentationCommand;
      HelpCommands.LicenseDocumentCommand.CreateScreenTip();
      CopyrightCommand copyrightCommand = new CopyrightCommand(nameof (Copyright), (InputGestureCollection) null);
      copyrightCommand.Text = Resources.Command_About_Copyright_Button_Text;
      copyrightCommand.SmallIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/copyright_16x16.png";
      copyrightCommand.LargeIcon = "pack://application:,,,/MapInfo.StyleResources;component/Images/Application/copyright_32x32.png";
      copyrightCommand.ToolTipDescription = Resources.Command_About_Copyright_ToolTip_Description;
      copyrightCommand.ToolTipText = Resources.Command_About_Copyright_Tooltip_Text;
      copyrightCommand.ToolTipDisabledText = Resources.Command_AlwaysEnabled;
      copyrightCommand.Category = Resources.Command_Category_HelpCommands;
      HelpCommands.CopyrightCommand = copyrightCommand;
      HelpCommands.CopyrightCommand.CreateScreenTip();
    }

    public static MapInfoCommand About
    {
      get
      {
        return (MapInfoCommand) HelpCommands.AboutCommand;
      }
    }

    public static MapInfoCommand HelpContents
    {
      get
      {
        return (MapInfoCommand) HelpCommands.HelpContentsCommand;
      }
    }

    public static MapInfoCommand HelpSearch
    {
      get
      {
        return (MapInfoCommand) HelpCommands.HelpSearchCommand;
      }
    }

    internal static ContextHelpCommands ContextHelp
    {
      get
      {
        return HelpCommands.ContextHelpCommand;
      }
    }

    public static MapInfoCommand SmartUpdate
    {
      get
      {
        return (MapInfoCommand) HelpCommands.SmartUpdateCommand;
      }
    }

    public static MapInfoCommand MapInfoNewsfeed
    {
      get
      {
        return (MapInfoCommand) HelpCommands.MapInfoNewsfeedCommand;
      }
    }

    public static MapInfoCommand TransferLicense
    {
      get
      {
        return (MapInfoCommand) HelpCommands.TransferLicenseCommand;
      }
    }

    public static MapInfoCommand BorrowLicense
    {
      get
      {
        return (MapInfoCommand) HelpCommands.BorrowLicenseCommand;
      }
    }

    public static MapInfoCommand ReturnBorrowedLicense
    {
      get
      {
        return (MapInfoCommand) HelpCommands.ReturnBorrowedLicenseCommand;
      }
    }

    public static MapInfoCommand StartAdvancedEvaluation
    {
      get
      {
        return (MapInfoCommand) HelpCommands.StartAdvancedEvaluationCommand;
      }
    }

    public static MapInfoCommand ActivateAdvancedLicense
    {
      get
      {
        return (MapInfoCommand) HelpCommands.ActivateAdvancedLicenseCommand;
      }
    }

    public static MapInfoCommand ActivateFlexeraLicenseForSubscriptionLicensedUser
    {
      get
      {
        return (MapInfoCommand) HelpCommands.ActivateFlexeraLicenseForSubscriptionLicensedUserCommand;
      }
    }

    public static MapInfoCommand UserBingKey
    {
      get
      {
        return (MapInfoCommand) HelpCommands.UserBingKeyCommand;
      }
    }

    public static MapInfoCommand ProductFeedback
    {
      get
      {
        return (MapInfoCommand) HelpCommands.ProductFeedbackCommand;
      }
    }

    public static MapInfoCommand MapInfoWww
    {
      get
      {
        return (MapInfoCommand) HelpCommands.MapInfoWwwCommand;
      }
    }

    public static MapInfoCommand TechSupport
    {
      get
      {
        return (MapInfoCommand) HelpCommands.TechSupportCommand;
      }
    }

    public static MapInfoCommand MapInfoWwwStore
    {
      get
      {
        return (MapInfoCommand) HelpCommands.MapInfoWwwStoreCommand;
      }
    }

    public static MapInfoCommand MapInfoWwwStoreEuro
    {
      get
      {
        return (MapInfoCommand) HelpCommands.MapInfoWwwStoreEuroCommand;
      }
    }

    public static MapInfoCommand WwwTutorial
    {
      get
      {
        return (MapInfoCommand) HelpCommands.WwwTutorialCommand;
      }
    }

    public static MapInfoCommand BingTermsOfUse
    {
      get
      {
        return (MapInfoCommand) HelpCommands.BingTermsOfUseCommand;
      }
    }

    public static MapInfoCommand LicenseDocument
    {
      get
      {
        return (MapInfoCommand) HelpCommands.LicenseDocumentCommand;
      }
    }

    public static MapInfoCommand Copyright
    {
      get
      {
        return (MapInfoCommand) HelpCommands.CopyrightCommand;
      }
    }
  }
}
