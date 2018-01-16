﻿using System;
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

        public Tests(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void LargePhotoTest()
        {
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/LargePhoto.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver); 
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver); 
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);
        }

        public void GifTest()
        {
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/3DGif.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);
        }

        public void LocalGameTest()
        {
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/Game.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);
        }

        public void OuterGameTest()
        {
            _webDriver.Navigate().GoToUrl(@"http://ozogames.com/webgl-3d-games/endless-truck-online-game.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);
        }

        public void ThreeDimensionsModel()
        {
            _webDriver.Navigate().GoToUrl("file:///D:/selenium%20projekt/BrowserBenchmark/BrowsersBenchmark/Resources/Sketchfab.html");

            var navigationStart = WebTimeService.NavigationStart(_webDriver);
            var requestTime = WebTimeService.RequestTime(_webDriver);
            var responseTime = WebTimeService.ResponseTime(_webDriver);
            var wholeRequestTime = WebTimeService.WholeRequestTime(_webDriver);
            var domRenderingTime = WebTimeService.DomRenderingTime(_webDriver);
            var pageLoadTime = WebTimeService.PageLoadTime(_webDriver);
        }

        public void InsertionSortTest()
        {
            var script = File.ReadAllText(@"D:\selenium projekt\BrowserBenchmark\BrowsersBenchmark\Resources\Sorting.js");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ((IJavaScriptExecutor)_webDriver).ExecuteScript(script);
            stopWatch.Stop();

            var time = stopWatch.ElapsedMilliseconds;

            MessageBox.Show(time.ToString());
        }
    }
}
