using System.IO;
using System.Reflection;
using System.Diagnostics;
using System;
using System.Reflection.Metadata;

namespace ForBasic_Files
{

  /**
   *  FileStream 类在 System.IO 命名空间下，使用它可以读取、写入和关闭文件。创建 FileStream 类对象的语法格式如下所示：
      FileStream <object_name> = new FileStream(<file_name>, <FileMode Enumerator>, <FileAccess Enumerator>, <FileShare Enumerator>);
   * 
   *  file_name：文件的路径（包含文件名在内）；
   *  
   *  
      FileMode：枚举类型，用来设定文件的打开方式，可选值如下：
      Append：打开一个已有的文件，并将光标放置在文件的末尾。如果文件不存在，则创建文件；
      Create：创建一个新的文件，如果文件已存在，则将旧文件删除，然后创建新文件；
      CreateNew：创建一个新的文件，如果文件已存在，则抛出异常；
      Open：打开一个已有的文件，如果文件不存在，则抛出异常；
      OpenOrCreate：打开一个已有的文件，如果文件不存在，则创建一个新的文件并打开；
      Truncate：打开一个已有的文件，然后将文件清空（删除原有内容），如果文件不存在，则抛出异常。



      FileAccess：枚举类型，用来设置文件的存取，可选值有 Read、ReadWrite 和 Write；




      FileShare：枚举类型，用来设置文件的权限，可选值如下：
      Inheritable：允许子进程继承文件句柄，Win32 不直接支持此功能；
      None：在文件关闭前拒绝共享当前文件，打开该文件的任何请求（由此进程或另一进程发出的请求）都将失败；
      Read：允许随后打开文件读取，如果未指定此标志，则文件关闭前，任何打开该文件以进行读取的请求都将失败，需要注意的是，即使指定了此标志，仍需要附加权限才能够访问该文件；
      ReadWrite：允许随后打开文件读取或写入，如果未指定此标志，则文件关闭前，任何打开该文件以进行读取或写入的请求都将失败，需要注意的是，即使指定了此标志，仍需要附加权限才能够访问该文件；
      Write：允许随后打开文件写入，如果未指定此标志，则文件关闭前，任何打开该文件以进行写入的请求都将失败，需要注意的是，即使指定了此标志，仍可能需要附加权限才能够访问该文件；
      Delete：允许随后删除文件。

   */
  public class Files
  {
    public Files()
    {
      string path = Path.Combine(Environment.CurrentDirectory, "ccd.txt");
      //CreateFile(path, "ccccc");
      //ReadFile(path);
      //ExistsFile(path);
      DeleteFile(path);
    }
    // 创建文件 / 写入文件
    public void CreateFile(string path, string content)
    {
      using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
      {
        using (StreamWriter writer = new StreamWriter(fs))
        {
          writer.WriteLine(content); // 写入内容
        }
      }
    }
    // 读取文件
    public void ReadFile(string path)
    {
      using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
      {
        using (StreamReader reader = new StreamReader(fs))
        {
          Console.WriteLine(reader.ReadToEnd()); // 写入内容
        }
      }
    }
    // 判断文件是否存在
    public void ExistsFile(string path)
    {
      bool isExists = File.Exists(path); // 判断文件是否存在
      Console.WriteLine("文件是否存在：" + isExists);
    }

    // 删除文件
    public void DeleteFile(string path)
    {
      if (File.Exists(path))
      {
        File.Delete(path);
        Console.WriteLine("文件删除成功");
      }
      else
      {
        Console.WriteLine("文件不存在");
      }
    }

  }
}


