using System;
using ForBasic_Class;

namespace ForBasic_Class
{
  public class Animal_Contruction
  {
    public string name;
    public int age;

    public static int id;
    //可以给默认值
    //public Animal_Contruction(string name = "cat", int age = 1)
    //{
    //  this.name = name;
    //  this.age = age;
    //}

    /* 静态构造函数
     * 
     * 
       静态构造函数具有以下特性：
       静态构造函数不使用访问权限修饰符修饰或不具有参数；
       类或结构体中只能具有一个静态构造函数；
       静态构造函数不能继承或重载；
       静态构造函数不能直接调用，仅可以由公共语言运行时 (CLR) 调用；
       用户无法控制程序中静态构造函数的执行时间；
       在创建第一个实例或引用任何静态成员之前，将自动调用静态构造函数以初始化类；
       静态构造函数会在实例构造函数之前运行
    */

    //static Animal_Contruction()
    //{
    //  id = 10;
    //}


    /**
     * 私有构造函
     * 
     * 私有构造函数是一种特殊的实例构造函数，
     * 通常用在只包含静态成员的类中。
     * 如果一个类中具有一个或多个私有构造函数而没有公共构造函数的话，
     * 那么其他类（除嵌套类外）
     * 则无法创建该类的实例
     */

    private Animal_Contruction()
    {
      Console.WriteLine("private Animal_Contruction()");
    }
  }

}



//Animal_Contruction animal = new Animal_Contruction("dog", 2);
//Animal_Contruction animal1 = new Animal_Contruction();

//Console.WriteLine(Animal_Contruction.id);