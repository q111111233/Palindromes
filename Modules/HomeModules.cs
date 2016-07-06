using Nancy;
using System;

namespace Palindromes
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/palin"] = _ => {
        string s = Request.Form["input"];
        Game g = new Game(s);
        return View["result.cshtml", g.Palin()];
      };
    }
  }
}
