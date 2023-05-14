using System;
namespace ForBasic_Files
{
  public class Dirs
  {
    public Dirs()
    {
      string? folderName = null;
      //folderName = "aa";
      string path = Path.Combine(Environment.CurrentDirectory, folderName ?? "");
      TraverseDir(path);
    }


    // 遍历文件夹
    public void TraverseDir(string path)
    {
      DirectoryInfo folder = new DirectoryInfo(path);
      if (!folder.Exists)
      {
        Console.WriteLine("文件夹不存在");
        return;
      }
      Console.WriteLine("当前文件夹：" + folder.FullName);
      FileInfo[] files = folder.GetFiles();
      foreach (var file in files)
      {
        Console.WriteLine("文件名：" + file.Name);
      }
      DirectoryInfo[] dirs = folder.GetDirectories();
      if (dirs.Length == 0)
      {
        Console.WriteLine("子文件夹不存在");
        return;
      }

      foreach (var dir in dirs)
      {
        TraverseDir(dir.FullName);
      }
    }

    // 创建文件夹
    public void CreateDir(string path)
    {
      Console.WriteLine(path);
      Directory.CreateDirectory(path);
    }

    // 删除文件夹

    public void DeleteDir(string path)
    {
      Console.WriteLine(path);
      Directory.Delete(path);
    }
  }
}



// Main

//Dirs dirs = new();