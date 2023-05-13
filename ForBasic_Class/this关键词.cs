using System;
namespace ForBasic_Class
{
  public class ThisKeyword
  {
    public string name = "hello";
    //public ThisKeyword()
    //{
    //  Console.WriteLine("public ThisKeyword()");
    //}
    // 串联构造函数
    //public ThisKeyword(string name) : this()
    //{
    //  this.name = name;
    //  Console.WriteLine("public ThisKeyword(string name) : this()");
    //}


    // 类的索引器
    //public string this[int index]
    //{
    //  get => name;
    //  set
    //  {
    //    if (index == 0)
    //    {
    //      name = value;
    //    }
    //  }
    //}

    //this 关键字作为原始类型的扩展方法
    //public ThisKeyword()
    //{
    //  string a = "aa";
    //  Console.WriteLine(a.Add("cc"));
    //}
  }
  //this 关键字作为原始类型的扩展方法
  //public static class Extension
  //{
  //  public static string Add(this string str1, string str2)
  //  {
  //    string a = str1 + str2;
  //    Console.WriteLine(a);
  //    return a;
  //  }
  //}



  //    Main


  //    var thiskey = new ThisKeyword();
  //    Console.WriteLine(thiskey[0]);
  //    thiskey[0] = "hello";
  //    Console.WriteLine(thiskey.name);
}

