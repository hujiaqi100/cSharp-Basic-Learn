using System;
using ForBasic_Class;

namespace ForBasic_Class

{

  public abstract class Drink
  {
    public abstract void tea();
  }

  /*
   * 编译时多态：通过 C# 中的方法重载和运算符重载来实现编译时多态，也称为静态绑定或早期绑定；
     运行时多态：通过方法重载实现的运行时多态，也称为动态绑定或后期绑定。
  */
  public class Polymorphism : Drink
  {
    public Polymorphism()
    {
    }
    //编译时多态 
    public void Eat()
    {
      Console.WriteLine("nothing");
    }
    public void Eat(string food)
    {
      Console.WriteLine($"eat {food}");
    }

    //运行时多态 重写

    public override void tea()
    {
      Console.WriteLine("public override void tea()");
    }

  }
}


// Main


//Polymorphism polymorphism = new();
//polymorphism.Eat();
//polymorphism.Eat("rice");