using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnisuperExercise.UnisuperUtilities
{
    public static class ToDoMVCHelper
    {
            static IWebDriver driver;
        public static void WaitTillControlLoads(String property, String propertyValue)
        {
            try
            {
                WebDriverWait myWait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                if (property.Equals(("Id"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.Id(propertyValue)));
                else if (property.Equals(("Name"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.Name(propertyValue)));
                else if (property.Equals(("ClassName"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(propertyValue)));
                else if (property.Equals(("CssSelector"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(propertyValue)));
                else if (property.Equals(("LinkText"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(propertyValue)));
                else if (property.Equals(("PartialLinkText"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(propertyValue)));
                else if (property.Equals(("Xpath"), StringComparison.OrdinalIgnoreCase))
                    myWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(propertyValue)));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
            //Close and clean up the driver object
            public static void closebrowser(IWebDriver driver)
            {
                driver.Quit();
                driver.Dispose();
            }

        }
    }


