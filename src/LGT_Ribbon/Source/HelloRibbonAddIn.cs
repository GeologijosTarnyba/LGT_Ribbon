/*****************************************************************************
*       Copyright © 2015 Pitney Bowes Software Inc.
*       All rights reserved.
*****************************************************************************/

using LGT_Ribbon.Core;
using LGT_Ribbon.DBLite;
using MapInfo.Commands;
using MapInfo.Events;
using MapInfo.Types;
using System;
using System.IO;
using System.Linq;
using System.Windows;


namespace LGT_Ribbon
{
  public class MapInfoProSampleHelloRibbonAddIn : MapInfoProAddInBase
  {
    protected IMapInfoEvents MapInfoEvent;
    public IRibbonTab MyTab;
    public LiteDatabase mydb;
    public Form1 form1 { get; set; }
    public Form2 form2 { get; set; }
    public Ribbon Ribbon;
    public override void Initialize(IMapInfoPro mapInfoApplication, string mbxname)
    {

      base.Initialize(mapInfoApplication, mbxname);

      MapInfoEvent = MapInfoEvents.InitializeEvents(mapInfoApplication, ThisApplication);

      #if false
      #region Example: Adding custom tab manually from code
      MyTab = mapInfoApplication.Ribbon.Tabs.Add("Scrapes");

      //Adding group name Ribbon
      var bar = MyTab.Groups.Add("ScrapGroup", "Scrape");
      //bar.IsLauncherVisible = false;

      var doScrapeButton = bar.Controls.Add("doScrape", "Scrape", ControlType.Button) as IRibbonButtonControl;
      doScrapeButton.IsLarge = true;
      doScrapeButton.Command = new DelegateCommand(ScrapeTabMethod).ViewToContractAdapter();

      var addTolaytoutButton = bar.Controls.Add("doScrape", "Scrape", ControlType.Button) as IRibbonButtonControl;
      addTolaytoutButton.IsLarge = true;
      addTolaytoutButton.Command = new DelegateCommand(CreateMapFrame).ViewToContractAdapter();

      //var renewDatabaseButton = bar.Controls.Add("doRenew", "Atnaujinti", ControlType.Button) as IRibbonButtonControl;
      //renewDatabaseButton.IsLarge = true;
      //renewDatabaseButton.Command = new DelegateCommand(RenewLocalDatabase).ViewToContractAdapter();
      #endregion
      #endif
      #region My tabs
      PC.Initialize(Resource1.RoleFileLoc);
      mydb = new LiteDatabase(Resource1.LiteDbFileLoc, $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\MapInfo\\LGTRibbon", "ribbon");

      try {
        if (mydb.RenewLocalCopy()) {
          this.PakeitimuLogas();
        }
        Ribbon = mydb.GetRibbon();
      } catch (Exception e) {
        MessageBox.Show($"Klaida atnaujinant lokalią duomenų bazės kopiją {e.Message}");
      }

      if (Ribbon == null || PC.Is(UserLevel.Admin))
      {
        var questionCaption = (Ribbon == null ? "Nepavyko nuskaityti db" : "Admin");
        if (MessageBox.Show("Įdėti numatytuosius mygtukus ?", questionCaption, MessageBoxButton.YesNo) == MessageBoxResult.Yes) {
          Ribbon = Seed.Seed1.Ribbon;
          var localDbPavadinimas = mydb.WriteRibbonLocaly(Ribbon);
          //MessageBox.Show($"{localDbPavadinimas} sukurtas."); // Galima atkomentuoti galima neatkomentuoti.
        }
      }
      Ribbon?.Create(mapInfoApplication);
      #endregion
      var mapHolder = this.MapInfoApplication.Ribbon
        .Tabs.FirstOrDefault(item => item.Caption == "LAYOUT")
        .Groups.FirstOrDefault(item => item.Caption == "Insert")
        .Controls.FirstOrDefault(item => item.Caption == "Map");

      var AddMapToLayoutButton = (mapHolder as IControlGroup).Controls.Add("Layout_Insert_Map_Existing", "Existing map") as IRibbonButtonControl;
      AddMapToLayoutButton.SmallIcon = (mapHolder as IImageControl).SmallIcon;
      AddMapToLayoutButton.Command = new DelegateCommand(CallForm2).ViewToContractAdapter();
    }

    public void PakeitimuLogas()
    {
      if (form1 == null || form1.IsDisposed) {
        form1 = new Form1();
        form1.CreateControl();
        form1.Show();
        form1.TopMost = true;
      }
    }
    public override void Unload()
    {
      if (form1 != null && !form1.IsDisposed) {
        form1.Dispose();
      }
      if (form2 != null && !form2.IsDisposed) {
        form2.Dispose();
      }
      Ribbon?.Unload();
      base.Unload();
    }

    #region ScrapeTabMethod
    private void CreateMapFrame(object sender)
    {
      MB.AddMapToLayout(this.MapInfoApplication);
    }
    private void ScrapeTabMethod(object sender)
    {
      form2 = new Form2() {
        MapInfoPro = this.MapInfoApplication
      };
      form2.CreateControl();
      form2.Show();
      form2.TopMost = true;
    }
    private void CallForm2(object sender)
    {
      form2 = new Form2(){ 
        MapInfoPro = this.MapInfoApplication
      };
      form2.CreateControl();
      form2.Show();
      form2.TopMost = true;
    }

    #endregion
  }
}
