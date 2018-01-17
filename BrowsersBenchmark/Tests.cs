using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace BrowsersBenchmark
{
    public class Tests
    {
        private readonly IWebDriver _webDriver;
        private readonly string _webDriverName;
        private readonly string _resultsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BrowserBenchmarkResults");

        public Tests(IWebDriver webDriver, string webDriverName)
        {
            _webDriver = webDriver;
            _webDriverName = webDriverName;
            if (!Directory.Exists(_resultsDirectory))
            {
                Directory.CreateDirectory(_resultsDirectory);
            }
        }

        public void LargePhotoTest()
        {
            var fileName = "LargePhotoTest.csv";

            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/LargePhoto.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);

            var content = $"{_webDriverName};{navigationStart};{requestTime};{responseTime};{wholeRequestTime};{domRenderingTime};{pageLoadTime}";

            AddToFile(fileName, content);
        }

        public void GifTest()
        {
            var fileName = "GifTest.csv";

            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/3DGif.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);

            var content = $"{_webDriverName};{navigationStart};{requestTime};{responseTime};{wholeRequestTime};{domRenderingTime};{pageLoadTime}";

            AddToFile(fileName, content);
        }

        public void LocalGameTest()
        {
            var fileName = "LocalGameTest.csv";
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/Game.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);

            var content = $"{_webDriverName};{navigationStart};{requestTime};{responseTime};{wholeRequestTime};{domRenderingTime};{pageLoadTime}";

            AddToFile(fileName, content);
        }

        public void OuterGameTest()
        {
            var fileName = "OuterGameTest.csv";
            _webDriver.Navigate().GoToUrl(@"http://ozogames.com/webgl-3d-games/endless-truck-online-game.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);

            var content = $"{_webDriverName};{navigationStart};{requestTime};{responseTime};{wholeRequestTime};{domRenderingTime};{pageLoadTime}";

            AddToFile(fileName, content);
        }

        public void ThreeDimensionsModel()
        {
            var fileName = "ThreeDimensionsModel.csv";
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/Sketchfab.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);

            var content = $"{_webDriverName};{navigationStart};{requestTime};{responseTime};{wholeRequestTime};{domRenderingTime};{pageLoadTime}";

            AddToFile(fileName, content);
        }

        public void InsertionSortTest()
        {
            var fileName = "InsertionSortTest.csv";
            var script = File.ReadAllText(@"D:\selenium projekt\BrowserBenchmark\BrowsersBenchmark\Resources\Sorting.js");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ((IJavaScriptExecutor)_webDriver).ExecuteScript(script);
            stopWatch.Stop();

            var content = $"{_webDriverName};{stopWatch.ElapsedMilliseconds}";
            AddToFile(fileName, content, false);
        }

        private void AddToFile(string fileName, string content, bool addFirstRow = true)
        {
            var filePath = Path.Combine(_resultsDirectory, fileName);
            if (!File.Exists(filePath))
            {
                InitializeFile(filePath, addFirstRow);
            }

            using (var tw = new StreamWriter(filePath, true))
            {
                tw.WriteLine(content);
                tw.Close();
            }
        }

        private void InitializeFile(string filePath, bool addFirstRow)
        {
            File.Create(filePath).Close();
            if (addFirstRow)
            {
                var firstRow =
                    "Browser;NavigationStart;RequestTime;ResponseTime;WholeRequestTime;DomRenderingTime;PageLoadTime";

                using (var tw = new StreamWriter(filePath, true))
                {
                    tw.WriteLine(firstRow);
                    tw.Close();
                }
            }
        }
    }
}
