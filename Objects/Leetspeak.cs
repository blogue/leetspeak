using System;
using System.Text;
using System.Collections.Generic;

namespace Leetspeak.Objects
{
  public class Leet
  {
    public static StringBuilder InputToString(StringBuilder userString)
    {
      userString.Replace("e", "3");
      userString.Replace("o", "0");
      userString.Replace("L", "1");
      userString.Replace("s", "Z");
      userString.Replace(" Z", " s");
      return userString;
    }
  }
}
