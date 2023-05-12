using System;
using ForBasic;

namespace ForBasic
{
  /**
   * 结构体与类非常相似，但有以下几点区别：
   *  结构体是一个值类型，而类是一个引用类型。
   *  结构体的内存分配是在栈中进行，而类的内存分配是在堆中进行。
   *  结构体可以不使用 new 运算符就可以初始化，而类必须使用 new 运算符来初始化。
   *  结构体不支持继承，而类支持继承。
   */
  public struct Car
  {
    public string brand;
    public string model;
    public Car(string brand, string model)
    {
      this.brand = brand;
      this.model = model;
    }
  }
  public class StructUseTest
  {
    public void changeBrand(ref Car car)
    {
      car.brand = "bb";
    }
  }
}


//            Main
//Car myCar = new Car("aa", "bb");
//new StructUseTest().changeBrand(ref myCar);
//Console.WriteLine(myCar.brand);

