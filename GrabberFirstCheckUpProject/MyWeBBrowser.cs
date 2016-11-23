using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Data.SqlClient;
using OpenQA.Selenium.Interactions;

namespace GrabberFirstCheckUpProject
{
    class MyWeBBrowser
    {        

        public static void getData(IWebDriver driver) {


            //SqlConnection conn = GeneralSQL.CatchDatabase();

            if (driver != null) {

                var element = driver.FindElement(By.Id("B111"));

                var innerHtml = TextAttributeValueByCssSelector(By.Id("B111"), driver);//element.GetAttribute("innerHTML");
              
                MessageBox.Show(innerHtml);
            }
        
        }

        public static string TextAttributeValueByCssSelector(By by, IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(drv => drv.FindElement(by)).GetAttribute("value");
        }

        public static IWebDriver returnDriver(String link) {

            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driverService.HideCommandPromptWindow = true;
            driverService.SuppressInitialDiagnosticInformation = true;         
          
            var driver = new FirefoxDriver(driverService, new FirefoxOptions(), TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl(link);         

            return driver;

        }
        public static void WindowsHandle(IWebDriver driver) {

            IReadOnlyCollection<string> tabs = driver.WindowHandles;
           // driver.SwitchTo().
        }



    }//  class MyWeBBrowser

}//namespace GrabberFirstCheckUpProject
