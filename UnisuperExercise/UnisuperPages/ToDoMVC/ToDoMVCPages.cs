using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnisuperExercise.UnisuperPages.ToDoMVC
{
    public class ToDoMVCPages
    {
        IWebDriver driver;      
        public ToDoMVCPages(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='examples/angularjs']")]
        private IWebElement AngularPage;
        [FindsBy(How = How.Id, Using = "new-todo")]
        private IWebElement ToDoItem; 
        [FindsBy(How = How.ClassName, Using = "ng-binding")]
        private IWebElement Item1display;
        [FindsBy(How = How.CssSelector, Using = ".edit")]
        private IWebElement Item1edit;
        [FindsBy(How = How.CssSelector, Using = ".toggle")]
        private IWebElement TocompleteItem1; 
        [FindsBy(How = How.Id, Using = "clear-completed")]
        private IWebElement CompletedItem;
        [FindsBy(How = How.Id, Using = "toggle-all")]
        private IWebElement MarkAll;
        [FindsBy(How = How.XPath, Using = "//a[@href='#/completed']")]
        private IWebElement CompletedBtn;
        [FindsBy(How = How.ClassName, Using = "destroy")]
        private IWebElement CloseBtn;


        public void LaunchToDoMVCPage()
        {
            String env = ConfigurationManager.AppSettings["Environment"];
            if (env.ToLower().Equals("dev"))
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ToDoMVCDevURL"]);
            else if (env.ToLower().Equals("stage"))
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ToDoMVCStageURL"]);
            else if (env.ToLower().Equals("prod"))
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ToDoMVCProdURL"]);
            else
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ToDoMVCProdURL"]);
        }
        public void Clickangularjs()
        {
            AngularPage.Click();
        }
        public bool ConfirmAngularpage()
        {
            return ToDoItem.Enabled;
        }
        public void Additem1()
        {
            ToDoItem.SendKeys("Item1");
            ToDoItem.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                
        }
        public bool ConfirmItem1()
        {
            return Item1display.Enabled;
        }
        public void EditItem1()
        {
            Actions act = new Actions(driver);
            act.DoubleClick(Item1display).Build().Perform();
            Item1edit.Clear();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Item1edit.SendKeys("Item1edited");
            Item1edit.SendKeys(Keys.Enter);
        }
        public void CompleteItem1()
        {
            TocompleteItem1.Click();
        }
        public bool ConfirmItemcompleted()
        {
            return CompletedItem.Enabled;
        }

        public void ReactivateItem1()
        {
            TocompleteItem1.Click();
        }

        public bool ConfirmItemReactivated()
        {
            return Item1display.Enabled;
        }

        public void AddSecondItem()
        {
            ToDoItem.SendKeys("Item2");
            ToDoItem.SendKeys(Keys.Enter);
        }
        
        public void MarkAllComplete()
        {
            MarkAll.Click();
        }

        public void FilterCompletedItems()
        {
            CompletedBtn.Click();
        }

        public void ClearToDoItem()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(Item1display).Build().Perform();
            CloseBtn.Click();
        }

        public void ClearCompletedToDoItems()
        {
            CompletedItem.Click();
        }
    
    }

    }
