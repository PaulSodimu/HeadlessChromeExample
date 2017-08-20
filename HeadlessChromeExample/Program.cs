using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System; 

namespace HeadlessChromeExample
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create crome options with headles arg
      ChromeOptions options = new ChromeOptions();
      options.AddArgument("--headless");

      var driver = new ChromeDriver(options);
      driver.Url = "http://www.paulsodimu.co.uk";

      //Take Screenshot 
      Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
      ss.SaveAsFile($"{AppContext.BaseDirectory}\\Shot.png", ScreenshotImageFormat.Png);

      Console.ReadKey();
      driver.Quit();
    }
  }
}
