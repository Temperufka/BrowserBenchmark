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


        public void OpenBrowser(IWebDriver _driver)
        {
            try
            {
                IWebDriver driver = _driver;
                var tests = new Tests(driver);
                tests.GifTest();


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
            IWebDriver driver = new FirefoxDriver();
            OpenBrowser(driver);
        }


        private void ChromeButton_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            OpenBrowser(driver);
        }

        private void ExplorerButton_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new InternetExplorerDriver(new InternetExplorerOptions() { IgnoreZoomLevel = true });
            OpenBrowser(driver);
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new EdgeDriver();
            OpenBrowser(driver);
        }
    }
}
