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
namespace ForBasic
{


  public class MainBasic
  {
    static void Main()
    {
      Type type = typeof(Test);
      MethodInfo[] methods = type.GetMethods();
      foreach (MethodInfo method in methods)
      {
        object[] attributes = method.GetCustomAttributes(true);
        foreach (object attribute in attributes)
        {
          MyAttribute myAttribute = attribute as MyAttribute;
          if (myAttribute != null)
          {
            Console.WriteLine(myAttribute.AuthorName);
          }
        }
      }
      Console.Read();
    }
  }


}



