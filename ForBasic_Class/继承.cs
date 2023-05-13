using System;
using ForBasic_Class;

namespace ForBasic_Class
{
  public class Animal_Extends
  {
    public string name;
    public int age;

    public Animal_Extends()
    {
      Console.WriteLine("public Animal_Extends()");
    }
    public Animal_Extends(string name)
    {
      this.name = name;
      Console.WriteLine("public Animal_Extends(string name)");
    }
    public Animal_Extends(int a)
    {
      Console.WriteLine("public Animal_Extends(int a)");
    }
    public void Hulu()
    {
      Console.WriteLine("Hulu");
    }
  }

  public class Cat : Animal_Extends
  {
    public Cat()
    {
      Console.WriteLine("public Cat()");
    }
    public Cat(string name) : base(name)
    {
      this.name = name;
      Console.WriteLine("public Animal_Extends(string name)");
    }
    public void Sleep()
    {
      base.Hulu();
    }
  }
}



// Main

//var cat = new Cat("huihui");
//cat.Sleep();