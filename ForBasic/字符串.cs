using System;
namespace ForBasic
{
  public class StringUseTest
  {
    public string _string;
    public StringUseTest(string str)
    {
      this._string = str;
    }

    public char[] StringToArrayForChar()
    {
      return _string.ToCharArray();
    }


    public string[] StringToArray(string str)
    {
      return _string.Split(str);
    }


    public string StringJoint(string str)
    {
      return _string + str;
    }


    /**
     * from startIdx to fromStartToEnd 
     */
    public string StringSplit(int startIdx, int fromStartToEnd)
    {
      return _string.Substring(startIdx, fromStartToEnd);
    }


    public bool ExistPartOfString(string str)
    {
      return _string.Contains(str);
    }


    public int GetPartOfStringIndex(char ch)
    {
      return _string.IndexOf(ch);
    }


    public bool EqualsTwoStrings(string str)
    {
      return _string.Equals(str);
    }


    //             Main Function Test Codes

    //StringUseTest stringUseTest = new("abcdefg");
    //// 转单个字符
    //char[] chars = stringUseTest.StringToArrayForChar();
    //foreach (var item in chars)
    //{
    //  Console.WriteLine(item);
    //}
    //// 按指定字符转
    //string[] strings = stringUseTest.StringToArray("d");
    //foreach (var item in strings)
    //{
    //  Console.WriteLine(item);
    //}
    // 拆分字符串
    //string a = stringUseTest.StringSplit(2, stringUseTest._string.Length - 2);
    //Console.WriteLine(a);



    //var a = stringUseTest.ExistPartOfString("bc");
    //Console.WriteLine(a);
    //var a = stringUseTest.GetPartOfStringIndex('h');
    //Console.WriteLine(a);
    //var a = stringUseTest.EqualsTwoStrings("def");
    //Console.WriteLine(a);
  }
}

