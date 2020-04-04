using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTestNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="nhnturan@gmail.com" && txtPassword.Text=="12345")
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://google.com");
                driver.FindElement(By.Name("q")).SendKeys("Paulo Coelho" +
                    "");
                driver.FindElement(By.Name("q")).Submit();
                IReadOnlyCollection<IWebElement> results = driver.FindElements(By.CssSelector("h3"));
                foreach (var result in results)
                {
                    var title = result.Text;
                    lstBxResults.Items.Add(title);
                }

                IWebElement page = driver.FindElement(By.ClassName("r"));
                page.Click();
            }
        }
    }
}

