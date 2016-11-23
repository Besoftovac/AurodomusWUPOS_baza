using System;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace GrabberFirstCheckUpProject
{
    public partial class GrabberMainForm : Form
    {

        IWebDriver driver = null;

        public GrabberMainForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
  

        private void GrabberMainForm_Load(object sender, EventArgs e)
        {
            // String link = "http://www.besoft.hr/informatika/index.php/kontakt-i-lokacija";
            String link = "https://mobile.overseas.hr/OSEBP/";
            driver = MyWeBBrowser.returnDriver(link);
            tm.Interval = 5000; // specify interval time as you want
            tm.Tick += new EventHandler(timer_Tick);
            tm.Start();
        }
        public  void timer_Tick(object sender, EventArgs e)
        {
           if (!Exists(By.Id("B111")))
              return;

            MyWebBrowser_CatchButtonClick.ClickScript(driver, "B111");
        }

        public bool Exists(By by)
        {
            if (driver.FindElements(by).Count!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGetGrabberData_Click(object sender, EventArgs e)
        {
            MyWeBBrowser.getData(driver);
        }

    }//   public partial class GrabberMainForm : Form

    
}           
           





    
   
  

