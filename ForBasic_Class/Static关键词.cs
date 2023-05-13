using System;
namespace ForBasic_Class
{

  /*
   * 使用 static 定义的成员属性称为“静态属性”
   * 静态属性可以直接通过类名.属性名的形式直接访问
   * 不需要事先创建类的实例
   * 静态属性不仅可以使用成员函数来初始化
   * 还可以直接在类外进行初始化。
   */
  public class StaticKeyword
  {
    public static string name;
    static StaticKeyword()
    {
      StaticKeyword.name = "hello";
      Console.WriteLine("static StaticKeyword()");
    }
    public StaticKeyword()
    {
      Console.WriteLine("public StaticKeyword()");
    }
  }
}


// Main

//StaticKeyword staticKeyword1 = new();
//StaticKeyword staticKeyword2 = new();
//Console.WriteLine(StaticKeyword.name);
