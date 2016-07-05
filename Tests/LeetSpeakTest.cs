using Xunit;
using Leetspeak.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetspeak
{

  public class LeetSpeakTest
  {
    [Fact]
    public void Leetspeak_Test()
    {
      StringBuilder leetString = new StringBuilder("I am sam");
      StringBuilder newString = new StringBuilder("I am Sam");
      StringBuilder leetResult = Leet.InputToString(leetString);
      string newTestString = newString.ToString();
      string newleetResult = leetResult.ToString();
      Assert.Equal(newTestString, newleetResult);
    }
  }
}
