#define PI
using System;
namespace ForBasic_Other
{
  /*
   * 
   * 预处理指令的作用主要是向编译器发出指令
   * 以便在程序编译开始之前对信息进行一些预处理操作
   * 在 C# 中，预处理器指令均以#开头
   * 并且预处理器指令之前只能出现空格不能出现任何代码
   * 另外，预处理器指令不是语句，因此它们不需要以分号;结尾。
   * 
   * 
   *  #define	用于定义一系列字符，可以将这些字符称为符号
      #undef	用于取消一个已定义符号
      #if	用于测试符号是否为真
      #else	用于创建复合条件指令，与 #if 一起使用
      #elif	用于创建复合条件指令
      #endif	指定一个条件指令的结束
      #line	用于修改编译器的行数以及（可选地）输出错误和警告的文件名
      #error	用于在代码的指定位置生成一个错误
      #warning	用于在代码的指定位置生成一级警告
      #region	用于在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块
      #endregion	用于标识 #region 块的结束
   * 
   */
  #region hello
  public class Preprocessor
  {
    string name = "hello";
    public Preprocessor()
    {
#if (!name)
      Console.WriteLine(1);
#else
      Console.WriteLine(2);
#endif
    }
  }
  #endregion 
}


