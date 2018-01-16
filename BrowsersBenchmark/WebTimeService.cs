using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BrowsersBenchmark
{
    public static class WebTimeService
    {
        public static object NavigationStart(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
               @"var now = new Date().getTime();
                var performance = window.performance || {};
                var page_load_time = now - performance.timing.navigationStart;    
                return page_load_time");
        }

        public static object PageLoadTime(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance || {};
                var pageLoadTime = perfData.timing.loadEventEnd - perfData.timing.navigationStart;   
                return pageLoadTime");
        }

        public static object DomRendering(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance || {};
                var pageLoadTime = perfData.timing.domComplete- perfData.timing.domLoading;   
                return pageLoadTime");
        }

        public static object RequestTime(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance || {};
                var pageLoadTime =   perfData.timing.responseStart - perfData.timing.requestStart;   
                return pageLoadTime");
        }

        public static object ResponseTime(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance || {};
                var pageLoadTime =  perfData.timing.responseEnd - perfData.timing.responseStart ;   
                return pageLoadTime");
        }

        public static object WholeRequestTime(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance || {};
                var pageLoadTime =  perfData.timing.responseEnd - perfData.timing.requestStart ;   
                return pageLoadTime");
        }
    }
}
