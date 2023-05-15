using System;
namespace ForBasic_Reflection
{
  public interface IUsb
  {
    void GetInfo()
    {
    }
    void Read()
    {
    }
    void Write()
    {
    }
  }
}


//    Main

// string USBPath = Path.Combine(Environment.CurrentDirectory, "USB");
//Console.WriteLine(USBPath);
//var dllFiles = Directory.GetFiles(USBPath);
//var deviceList = new List<IUsb>();
//foreach (var dll in dllFiles)
//{
//  Assembly ass = AssemblyLoadContext.Default.LoadFromAssemblyPath(dll);
//  var typeList = ass.GetTypes();

//  foreach (var item in typeList)
//  {
//    Console.WriteLine(item);
//    var interfaceList = item.GetInterfaces();

//    foreach (var i in interfaceList)
//    {

//      if (i.Name == "IUsb")
//      {
//        var usb = (IUsb)Activator.CreateInstance(item);
//        deviceList.Add(usb);
//      }
//    }
//  }
//}
//foreach (var item in deviceList)
//{
//  item.GetInfo();
//  item.Write();
//  item.Read();
//}