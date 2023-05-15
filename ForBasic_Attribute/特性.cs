using System;
using System.Diagnostics;
using System.Reflection;
using ForBasic_Attribute;

namespace ForBasic_Attribute
{
  /**
   * 使用特性可以向程序中添加元数据，元数据是指程序中各种元素的相关信息，所有 .NET 程序中都包含一组指定的元数据；
      可以将一个或多个特性应用于整个程序、模块或者较小的程序元素（例如类和属性）中；
      特性可以像方法和属性一样接受自变量；
      程序可使用反射来检查自己的元数据或其他程序中的元数据。
   */
  //AttributeUsage用于定义自定义属性的使用范围。它可以指定自定义属性在应用于哪些程序元素时有效，并且可以限制该属性的多次使用。
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class MyAttribute : Attribute
  {
    public string AuthorName { get; }

    public MyAttribute(string name)
    {
      AuthorName = name;
    }
  }
  [MyAttribute("dd")]
  [MyAttribute("aa")]
  public class Test
  {
    public string a = "aa";
    public Test()
    {
    }
    //叠加使用
    [MyAttribute("cc")]
    public void TestMyAttribute()
    {
      Console.WriteLine("22");
    }
  }
  //继承后Inherited是false的不能用反射
  public class Chid : Test { }


  ////////////////////////////////////////////////////////////////////////



  //预定义特性 Conditional 用来标记一个方法，
  //它的执行依赖于指定的预处理标识符。
  //根据该特性值的不同，
  //在编译时会起到不同的效果，
  //例如当值为 Debug 或 Trace 时，
  //会在调试代码时显示变量的值。

  public class TestCondition
  {


    [Conditional("DEBUG")]
    public void test()
    {
      Console.WriteLine("public void test()");
    }

  }

  ////////////////////////////////////////////////


  //预定义特性 Obsolete
  //用来标记不应被使用的程序，
  //您可以使用它来通知编译器放弃某个目标元素。
  //例如当您需要使用一个新方法来替代类中的某个旧方法时，
  //就可以使用该特性将旧方法标记为 obsolete（过时的）并来输出一条消息，
  //来提示我们应该使用新方法代替旧方法

  public class TestObsolete
  {


    [Obsolete("OldMethod 已弃用，请改用 NewMethod", true)]
    public void test()
    {
      Console.WriteLine("public void test()");
    }

  }
}

//  Main

//Test test = new();
//test.TestMyAttribute();

//Chid child = new();
//child.TestMyAttribute();
//TestObsolete testCondition = new();
//testCondition.test();


//反射获取特性内容
//Type type = typeof(Test);
//MethodInfo[] methods = type.GetMethods();
//foreach (MethodInfo method in methods)
//{
//  object[] attributes = method.GetCustomAttributes(true);
//  foreach (object attribute in attributes)
//  {
//    MyAttribute myAttribute = attribute as MyAttribute;
//    if (myAttribute != null)
//    {
//      Console.WriteLine(myAttribute.AuthorName);
//    }
//  }
//}