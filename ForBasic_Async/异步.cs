using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;
using HtmlAgilityPack;
namespace ForBasic_Async;
public static class Async
{
  public static async void GetData(string url, string xPath)
  {
    var httpClient = new HttpClient();

    // 发送GET请求并获取响应内容
    var response = await httpClient.GetAsync(url);

    // 确认响应的状态码
    if (!response.IsSuccessStatusCode)
    {
      Console.WriteLine($"Failed to get website content. Status code: {response.StatusCode}");
      return;
    }

    // 获取响应内容的HTML文本
    var htmlContent = await response.Content.ReadAsStringAsync();

    // 创建一个HTML文档对象
    var htmlDocument = new HtmlDocument();
    htmlDocument.LoadHtml(htmlContent);
    // 获取指定路径下的所有a标签xPath
    var aTags = htmlDocument.DocumentNode.SelectNodes(xPath).ToList();

    if (aTags != null && aTags.Count > 0)
    {
      // 输出每个a标签的文本
      foreach (var aTag in aTags)
      {
        Console.WriteLine($"Text: {aTag.InnerText}");
      }
    }
    else
    {
      Console.WriteLine("未找到指定节点!");
    }
  }

}

// Main

//string url = "http://c.biancheng.net/csharp/file-io.html";
//string xpath = "//*[@id=\"contents\"]/dd/a";
//Async.GetData(url, xpath);