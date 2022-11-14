using LGT_Ribbon.Core;
using System;
using System.IO;
using System.Linq;

namespace LGT_Ribbon.DBLite
{
  public class LiteDatabase
  {
    #region Constructors
    /// <summary>
    /// 
    /// </summary>
    /// <param name="remoteDatabaseFile">Pilnas kelias į LiteDB duomenų bazės failą</param>
    /// <param name="localLocation">Aplankas kuriame sukurti lokalia duomenų bazės kopija</param>
    /// <param name="collectionName">duomenų bazės failo pavadinimas ir duomenų bazėje esančios kolekcijos pavadinimas</param>
    public LiteDatabase(string remoteDatabaseFile, string localLocation, string collectionName = "ribbon")
    {
      this._remoteDatabaseFile = remoteDatabaseFile;
      this._localFolder = localLocation;
      this._localDatabaseFile = $"{localLocation}\\{collectionName}.db";
      this._collectionName = collectionName;
    }
    #endregion

    #region Public Properties
    public readonly string _remoteDatabaseFile;
    public readonly string _localFolder;
    public readonly string _localDatabaseFile;
    private readonly string _collectionName;
    #endregion

    private static string writeRibbon(Ribbon ribbon, string fileLocation, string collectionName) {
      //using (var db = new LiteDatabase(fileLocation))
      //{
      //  var col = db.GetCollection<Ribbon>(collectionName);
      //  col.Insert(ribbon);
      //}
      using (var db = new LiteDB.LiteDatabase(fileLocation)) {
        var col = db.GetCollection<Ribbon>(collectionName);
        col.Insert(ribbon);
        return fileLocation;
      }
    }
    #region Public Methods
    public string WriteRibbonLocaly(Ribbon ribbon)
    {
      return writeRibbon(ribbon, this._localDatabaseFile, this._collectionName);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns>return true if newer version of dabase was coppied, false otherwise</returns>
    public bool RenewLocalCopy()
    {
      if (!File.Exists(this._localDatabaseFile) || File.GetLastWriteTime(this._remoteDatabaseFile) != File.GetLastWriteTime(this._localDatabaseFile)) {
        Directory.CreateDirectory(this._localFolder);
        File.Copy(this._remoteDatabaseFile, this._localDatabaseFile, true);
        return true;
      }
      return false;
    }
    public bool LocalFileExists()
    {
      return File.Exists(this._localDatabaseFile);
    }
    public bool GlobalFileExists()
    {
      return File.Exists(this._remoteDatabaseFile);
    }

    public Ribbon GetRibbon(bool firstTry = true)
    {
      try
      {
        if (!File.Exists(this._localDatabaseFile))
        {
          this.RenewLocalCopy();
        }

        using (var db = new LiteDB.LiteDatabase(this._localDatabaseFile)) {
          var col = db.GetCollection<Ribbon>(this._collectionName);
          return col.Find(item => true).LastOrDefault();
        }
      } catch (Exception e)
      {
        throw new Exception($"Could not read database in GetRibbon. {e}");
      }
    }
    #endregion
  }
}
