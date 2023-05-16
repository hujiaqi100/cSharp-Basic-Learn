using System;

namespace ForBasic_Delegate;
/**
 * 
 * 委托类似于 C/C++ 中的函数指针，但委托是完全面向对象的。另外，C++ 中的指针会记住函数，而委托则是同时封装对象实例和方法；
  委托允许将方法作为参数进行传递；
  委托可用于定义回调方法；
  委托可以链接在一起，例如可以对一个事件调用多个方法；
  方法不必与委托类型完全匹配；
  C# 2.0 版引入了匿名函数的概念，
  可以将代码块作为参数（而不是单独定义的方法）进行传递。
  C# 3.0 引入了 Lambda 表达式，利用它们可以更简练地编写内联代码块。
  匿名方法和 Lambda 表达式都可编译为委托类型，这些功能现在统称为匿名函数。
 */
public delegate void MyDelegate(string message);

public class Delegate
{
  public void DisplayMessage(string message, MyDelegate callback)
  {
    Console.WriteLine(message);
    if (callback != null)
    {
      callback("Message displayed successfully");
    }
  }
}


// Main

//public static void CallbackFunction(string message)
//{
//  Console.WriteLine("Callback message1: " + message);
//}
//public static void CallbackFunctionPlus(string message)
//{
//  Console.WriteLine("Callback message: " + message);
//}

//ForBasic_Delegate.Delegate de = new();
//MyDelegate my = CallbackFunction;
//MyDelegate my2 = CallbackFunctionPlus;
//MyDelegate my3 = my + my2;
//my3 = my3 - my + my; //调整执行顺序
//      de.DisplayMessage("aa", my3);