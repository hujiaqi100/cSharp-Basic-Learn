using System;
/**
 * 在使用枚举类型时有以下几点需要注意：
 *   枚举类型中不能定义方法；
 *   枚举类型具有固定的常量集；
 *   枚举类型可提高类型的安全性；
 *   枚举类型可以遍历。
 */
namespace ForBasic
{
  public enum DayTime
  {
    morning,
    noon = 2,
    night
  }
  public class EnumTest
  {
    public EnumTest()
    {
      Console.WriteLine($"{DayTime.morning},{DayTime.noon},{DayTime.night}");
      Console.WriteLine("======");
      Console.WriteLine($"type = {DayTime.morning.GetType()}");
      Console.WriteLine("======");
      Console.WriteLine($"int {(int)DayTime.morning}");
      Console.WriteLine("======");

      foreach (var item in Enum.GetValues(typeof(DayTime)))
      {
        Console.WriteLine((int)item);
      }

    }
  }

  // Main
  // new EnumTest();
}

