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
                var page_load_time = now - performance.timing.navigationStart;    
                return page_load_time");
        }

        public static object PageLoadTime(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(
                @"var perfData = window.performance.timing; 
                var pageLoadTime = perfData.loadEventEnd - perfData.navigationStart;   
                return pageLoadTime");
        }

    }
}
