using System;
using System.Collections.Generic;
using System.Text;

namespace LGT_Ribbon.Core
{
  /// <summary>
  /// Enumerator to describe user rights in LGTRibbon application.
  /// </summary>
  [Flags]
  public enum UserLevel
  {
    Unknown = -1,
    None = 0,
    Admin = 1,
    User = 2,
    Tester = 4

  }
}
