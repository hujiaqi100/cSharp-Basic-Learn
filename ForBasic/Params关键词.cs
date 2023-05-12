using System;
using System.Collections.Generic;
namespace ForBasic
{
  public class TempElement
  {
    public int a;
    public string b;
    public TempElement(int a, string b)
    {
      this.a = a;
      this.b = b;
    }
  }
  public class ParamsKeywordTest
  {
    public void ParamsArray(params TempElement[] arr)
    {
      foreach (var item in arr)
      {
        Console.Write(item.a);
        Console.Write("------");
        Console.Write(item.b);
        Console.WriteLine();
      }
    }
  }

  //        Main Function Test Codes

  //ParamsKeywordTest paramsKeywordTest = new();
  //var x = new List<TempElement>();
  //x.Add(new TempElement(1, "2"));
  //x.Add(new TempElement(5, "6"));
  //paramsKeywordTest.ParamsArray(new TempElement(1, "2"), new TempElement(5, "6"));

}

