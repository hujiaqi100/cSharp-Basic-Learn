using System;
using ForBasic_Reflection;
namespace SSD
{
  public class SSD : IUsb
  {

    public void GetInfo()
    {
      Console.WriteLine("SSD -- public void GetInfo()");
    }
    public void Read()
    {
      Console.WriteLine("SSD -- public void Read()");
    }
    public void Write()
    {
      Console.WriteLine("SSD -- public void Write()");
    }
  }
  public class Aa : IUsb
  {

    public void GetInfo()
    {
      Console.WriteLine("SSD -- public void GetInfo()");
    }
    public void Read()
    {
      Console.WriteLine("SSD -- public void Read()");
    }
    public void Write()
    {
      Console.WriteLine("SSD -- public void Write()");
    }
  }
}

