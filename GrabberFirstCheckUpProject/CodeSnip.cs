using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabberFirstCheckUpProject
{
    class CodeSnip
    {
        /*            HtmlAgilityPack.HtmlDocument doc = new HtmlWeb().Load("http://www.besoft.hr/informatika/index.php/kontakt-i-lokacija");

          //foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//form[@class=\"form-horizontal\"]"))
          //{
          //    if (node.HasChildNodes)
          //    {
          //        IEnumerable<HtmlNode> nodes = node.ChildNodes;
          //    } 


          //}

          //var nodes = doc.DocumentNode.SelectNodes("//form//input");
          //var inputs = doc.DocumentNode.Descendants("input");

          IEnumerable<HtmlNode> forms = doc.DocumentNode.Descendants("input");



          //foreach (HtmlNode formchild in forms)
          //{
          HtmlNode formchild = doc.DocumentNode.SelectSingleNode("//input[@name='jform[contact_name]']");
          String outer = formchild.OuterHtml;
              String value = formchild.InnerText;
              String name = formchild.Name;
              String originalName = formchild.OriginalName;
              String id = formchild.Id;

          //}

        //////////////////My web Browser//////////////////////////////////////

            //IWebElement query = FindElement(searchContext.findElements, By.Name("q"), 10);
            //    // driver.FindElement(By.Name("q"));

            //// Enter something to search for
            //query.SendKeys("Cheese");

           
            //query.Submit();

            

            //// Should see: "Cheese - Google Search"
            //System.Console.WriteLine("Page title is: " + driver.Title);

            ////Close the browser
            //driver.Quit();



           //public static IWebElement FindElement(this ISearchContext context, By by, uint timeout, bool displayed = false)
        //{
        //    var wait = new DefaultWait<ISearchContext>(context);
        //    wait.Timeout = TimeSpan.FromSeconds(timeout);
        //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //    return wait.Until(ctx => {
        //        var elem = ctx.FindElement(by);
        //        if (displayed && !elem.Displayed)
        //            return null;

        //        return elem;
        //    });
        //}

        //////////////////////driver event handler//////////////////////

          //var eventDriver = new EventFiringWebDriver(driver);
            //eventDriver.ElementClicked += new EventHandler<WebElementEventArgs>(MyElementClickedHandler);
           // eventDriver.ElementClicked += new EventHandler<WebElementEventArgs>(MyElementClickedHandler);
           // eventDriver.ElementValueChanged += new EventHandler<WebElementEventArgs>(MyElementClickedHandler);

            driver = eventDriver;


          static void MyElementClickedHandler(object sender, WebElementEventArgs e)
        {
            return;
            if (sender != null)
            {
                IWebDriver driver = (IWebDriver)sender;
                var emailInputField = driver.FindElement(By.Id("jform_contact_emailmsg"));
                var email = emailInputField.GetAttribute("value");
                emailInputField.Clear();
                var empty = driver.FindElement(By.Id(email)).GetAttribute("value");

                MessageBox.Show(e.Element.ToString());
            }//if (sender != null)
        }

*/
    }
}
