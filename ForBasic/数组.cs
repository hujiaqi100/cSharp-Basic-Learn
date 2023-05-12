using System;
using System.Collections.Generic;
namespace ForBasic
{
  public class TestStruct
  {
    public string name;
    public int id;
    public TestStruct(string name, int id)
    {
      this.name = name;
      this.id = id;
    }
  }
  public class ArrayUseTest
  {
    public List<TestStruct> testStructs = new List<TestStruct>();
    public List<TestStruct> testStructsNext = new List<TestStruct>();

    public ArrayUseTest()
    {
      testStructs.Add(new TestStruct("hjq1", 1));
      testStructs.Add(new TestStruct("hjq2", 2));
      testStructs.Add(new TestStruct("hjq3", 3));

      InsertItem(1, new TestStruct("hjq5", 5), testStructs);
      RemoveElement(1, testStructs);

      testStructsNext.Add(new TestStruct("maybe1", 1));
      testStructsNext.Add(new TestStruct("maybe2", 2));
      testStructsNext.Add(new TestStruct("maybe3", 3));


      //var newCombineArray = testStructs.Concat(testStructsNext);
      var newCombineArray = CombineArray<TestStruct>(testStructs, testStructsNext);




      foreach (var item in newCombineArray)
      {
        Console.WriteLine($"name={item.name} -- id={item.id}");
      }
    }


    /**
     * @{pararms} idx 在哪插
     * @{pararms} testStruct 插什么
     */
    public void InsertItem(int idx, TestStruct testStruct, List<TestStruct> testStructs)
    {
      testStructs.Insert(idx, testStruct);
    }

    /**
     * @{pararms} idx 删哪个
     */
    public void RemoveElement(int idx, List<TestStruct> testStructs)
    {
      testStructs.RemoveAt(idx);
    }

    /**
     * @{pararms} arr 连哪个
     * Concat纯函数
     */
    public List<T> CombineArray<T>(List<T> arr1, List<T> arr2)
    {
      return arr1.Concat(arr2).ToList();
    }
  }


  //new ArrayUseTest();

}

