using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabberFirstCheckUpProject
{
    class MyWebBrowser_CatchButtonClick
    {
        public static void ClickScript(IWebDriver driver, String  ElementID) {

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("$(\"#"+ ElementID + "\").click(function(){ "
                                                      + "alert(\"pero\");"
                                                      + " }) ");
        }
     
    }
}
