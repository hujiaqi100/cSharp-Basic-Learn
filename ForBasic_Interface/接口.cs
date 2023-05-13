namespace ForBasic_Interface;

/**
 * 接口可以看作是一个约定，其中定义了类或结构体继承接口后需要实现功能，接口的特点如下所示：
      接口是一个引用类型，通过接口可以实现多重继承；
      接口中只能声明"抽象"成员，所以不能直接对接口进行实例化；
      接口中可以包含方法、属性、事件、索引器等成员；
      接口名称一般习惯使用字母“I”作为开头（不是必须的，不这样声明也可以）；
      接口中成员的访问权限默认为 public，所以我们在定义接口时不用再为接口成员指定任何访问权限修饰符，否则编译器会报错；
      在声明接口成员的时候，不能为接口成员编写具体的可执行代码，也就是说，只要在定义成员时指明成员的名称和参数就可以了；
      接口一旦被实现（被一个类继承），派生类就必须实现接口中的所有成员，除非派生类本身也是抽象类。
*/


public interface ICarName
{
  string Name { get; set; }
  void showName(string Name);
}
public interface Icomponey
{
  string Componey { get; set; }
}
public interface ICarModel : Icomponey
{
  string Model { get; set; }
  void showModel(string Model);
}
public class Car : ICarName, ICarModel
{
  public string Name { get => Name; set => Name = value; }
  public string Model { get => Model; set => Model = value; }
  public string Componey { get; set; }
  public void showName(string Name)
  {
    Console.WriteLine("public void showName(string Name)");
  }
  public void showModel(string Model)
  {
    Console.WriteLine("public void showModel(string Model)");
  }
}

// Main

//Car car = new();