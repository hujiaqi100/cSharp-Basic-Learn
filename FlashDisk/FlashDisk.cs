using System;
using ForBasic_Reflection;
namespace FlashDisk
{
  public class FlashDisk : IUsb
  {

    public void GetInfo()
    {
      Console.WriteLine("FlashDisk -- public void GetInfo()");
    }
    public void Read()
    {
      Console.WriteLine("FlashDisk -- public void Read()");
    }
    public void Write()
    {
      Console.WriteLine("FlashDisk -- public void Write()");
    }
  }
}

