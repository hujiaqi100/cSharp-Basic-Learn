using System;
namespace ForBasic_Delegate
{
  /*
   * 在 C# 中，事件是一种特殊的委托，
   * 它允许对象在发生一些特定的情况下通知其它对象。
   * 说得更具体一些，事件允许类在发生一个特定的操作时触发一组委托，
   * 这组委托被称为事件处理器。
   * 让我们通过一个简单的例子来了解一下事件是如何工作的。
   */
  public class Button
  {
    public event EventHandler Clicked;
    public void OnClick()
    {
      if (Clicked != null)
      {
        Clicked(this, EventArgs.Empty);
      }
    }
  }
  public class UserInterface
  {
    public void OnButtonClicked(object sender, EventArgs e)
    {
      Console.WriteLine("Button is clicked");
    }
  }
}

