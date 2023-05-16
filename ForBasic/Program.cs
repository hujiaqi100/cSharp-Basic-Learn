using System;
using ForBasic_Class;
using ForBasic_Interface;
//using ForBasic_Other;
using ForBasic_Files;
using ForBasic_Async;
using ForBasic_Attribute;
using ForBasic_Reflection;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.IO;
using System.Reflection;
using ForBasic_Delegate;
namespace ForBasic
{
  public class MainBasic
  {
    static void Main()
    {
      Button btn = new Button();
      UserInterface ui = new UserInterface();
      btn.Clicked += ui.OnButtonClicked;
      btn.OnClick();
      Console.Read();
    }
  }
}



