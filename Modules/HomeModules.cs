using Nancy;
using System.Collections.Generic;
using Leetspeak.Objects;
using Xunit;
using System;
using System.Text;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        string inputText = Request.Form["text"];
        StringBuilder newInputText = new StringBuilder(inputText);
        StringBuilder translatedInput = Leet.InputToString(newInputText);
        return View["result.cshtml", translatedInput];
      };

    }
  }
}
