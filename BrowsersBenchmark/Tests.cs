using System;
using System.Collections.Generic;
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

        public Tests(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void LargePhotoTest()
        {
            _webDriver.Navigate().GoToUrl(@"D:\selenium projekt\BrowserBenchmark\BrowsersBenchmark\Resources\LargePhoto.html");

            var navigationStart = WebTimeService.WholeRequestTime(_webDriver);

            MessageBox.Show(navigationStart.ToString());
        }

        public void GifTest()
        {
            _webDriver.Navigate().GoToUrl(@"D:\selenium projekt\BrowserBenchmark\BrowsersBenchmark\Resources\3DGif.html");

            var navigationStart = WebTimeService.WholeRequestTime(_webDriver);

            MessageBox.Show(navigationStart.ToString());
        }
    }
}
