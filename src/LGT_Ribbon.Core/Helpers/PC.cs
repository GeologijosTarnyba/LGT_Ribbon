using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LGT_Ribbon.Core
{
  /// <summary>
  /// Class to describe user rights in LGT_Ribbon aplication.
  /// </summary>
  public static class PC
  {

    private static readonly Dictionary<UserLevel, List<string>> LevelLists = new Dictionary<UserLevel, List<string>>();
    #region Constructor
    static PC()
    {
      foreach (UserLevel item in (UserLevel[])Enum.GetValues(typeof(UserLevel)))
      {
        LevelLists[item] = new List<string>();
      }
    }
    #endregion

    #region Helper Methods
    private static string ExternalIP
    {
      get { 
        string externalip = new WebClient().DownloadString("http://icanhazip.com");
        return externalip.Replace("\n", "");
      }
    }
    #endregion
    /// <summary>
    /// 
    /// </summary>
    /// <param name="roleFile"></param>
    /// <returns>Returns true if initialization was successful.</returns>
    // TODO: probably should be void function, throwing if initialization was not successful.
    public static bool Initialize(string roleFile)
    {
      if (!File.Exists(roleFile))
        return false;

      foreach (var eilute in File.ReadLines(roleFile).Select(item => new { UserName = item.Split(' ')[0], Role = StringToUserLevel(item.Split(' ')[1]) }))
      {
        LevelLists[eilute.Role].Add(eilute.UserName);
      }
      return true;
    }
    private static UserLevel StringToUserLevel(string levelText)
    {
      if (Enum.TryParse<UserLevel>(levelText, out UserLevel l))
        return l;
      return UserLevel.None;
    }
    private static UserLevel? level = null;
    /// <summary>
    /// Returns all users <see cref="UserLevel"/> values as <c>Flag</c> enumerator.
    /// User is considered User if he is in LGT Network.
    /// Other values will be looked up based on windows username and <see cref="LevelLists"/> distionary.
    /// </summary>
    public static UserLevel Level {
      get {
        // Level doesnt change, return catched, if already known.
        if (level != null)
          return (UserLevel)level;

        level = UserLevel.None;

        // Jei vartotojas yra vidinis
        if (Environment.UserDomainName == "LGT" || ExternalIP == "195.182.86.162")
        {
          // Visi LGT darbuotojai turi bent "User" teises
          level = level | UserLevel.User;

          // Ir teises nurodytas <Resource1.RoleFileLoc> faile.
          foreach (var singleLevelList in LevelLists)
          {
            foreach (var userName in singleLevelList.Value)
            {
              if (userName.ToLower() == Environment.UserName.ToLower())
                level = level | singleLevelList.Key;
            }
          }
        }
        return (UserLevel)level;
      }
    }

    /// <summary>
    /// Patikrina ar useris turi nurodyto lygio teises
    /// </summary>
    /// <param name="allowedLevels">nurodytas lygis</param>
    /// <returns></returns>
    public static bool Is(UserLevel allowedLevels)
    {
      var myLevel = Level;
      return (allowedLevels & myLevel) != UserLevel.None;
    }
  }
}
