using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LGT_Ribbon.Core
{
  public static class RandomString
  {
    private static Random random = new Random();
    public static string Generate(int length)
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }
  }
}
