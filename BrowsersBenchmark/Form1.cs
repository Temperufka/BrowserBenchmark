using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Remote;

namespace BrowsersBenchmark
{

    public partial class Form1 : Form
    {
        private string url;
        private string loadPageTime;


        public Form1()
        {
            InitializeComponent();
        }


        public void OpenBrowser(IWebDriver _driver, string browserName)
        {
            try
            {
                IWebDriver driver = _driver;
                var tests = new Tests(driver, browserName);
                tests.LargePhotoTest();
                tests.GifTest();
                tests.LocalGameTest();
                tests.ExternalWebSiteTest();
                tests.ThreeDimensionsModel();
                tests.InsertionSortTest();

                driver.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PageURL_TextChanged(object sender, EventArgs e)
        {
            url = PageURL.Text;
        }

        private void FirefoxButton_Click(object sender, EventArgs e)
        {
            FirefoxOptions options = new FirefoxOptions();

            options.LogLevel = FirefoxDriverLogLevel.Trace;
            options.AddArgument("--private");
            IWebDriver driver = new FirefoxDriver(options);
            driver.Manage().Cookies.DeleteAllCookies();

            OpenBrowser(driver, "Firefox");
        }

        private void ChromeButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 5; i++)
            //{
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("incognito");
                IWebDriver driver = new ChromeDriver(options);
                driver.Manage().Cookies.DeleteAllCookies();
                OpenBrowser(driver, "Chrome");
            //}
        }

        private void ExplorerButton_Click(object sender, EventArgs e)
        {
            var options = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                IgnoreZoomLevel = true,
                BrowserCommandLineArguments = "-private"
            };

            IWebDriver driver = new InternetExplorerDriver(options);
            driver.Manage().Cookies.DeleteAllCookies();

            OpenBrowser(driver, "InternetExplorer");
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            EdgeOptions options = new EdgeOptions();
            options.AddAdditionalCapability("IE_SWITCHES", "-private");

            IWebDriver driver = new EdgeDriver();
            driver.Manage().Cookies.DeleteAllCookies();

            OpenBrowser(driver, "Edge");
        }
    }
}
