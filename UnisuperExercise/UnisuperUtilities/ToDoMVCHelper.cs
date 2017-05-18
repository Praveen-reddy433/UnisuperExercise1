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
       
            //Close and clean up the driver object
            public static void closebrowser(IWebDriver driver)
            {
                driver.Quit();
                driver.Dispose();
            }

        }
    }


