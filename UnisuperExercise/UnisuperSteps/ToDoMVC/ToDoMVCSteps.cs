using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnisuperExercise.UnisuperPages.ToDoMVC;
using UnisuperExercise.UnisuperUtilities;

namespace UnisuperExercise.UnisuperSteps.ToDoMVC
{
    [Binding]
    public class ToDoMVCSteps
    {
        static IWebDriver driver = TestSetup.BringMyDriver();
        ToDoMVCPages _givepage = new ToDoMVCPages(driver);
        
        [Given(@"I am on AngularJS page")]
        public void GivenIAmOnAngularJSPage()
        {
            _givepage.LaunchToDoMVCPage();
            _givepage.Clickangularjs();
            Assert.IsTrue(_givepage.ConfirmAngularpage());
        }

        [When(@"I choose to add ToDo Item")]
        public void WhenIChooseToAddToDoItem()
        {
            _givepage.Additem1();
        }

        [Then(@"Item should be displayed")]
        public void ThenItemShouldBeDisplayed()
        {
            Assert.IsTrue(_givepage.ConfirmItem1());
            //ToDoMVCHelper.closebrowser(driver);
        }
        [When(@"I choose to edit content of First Item")]
        public void WhenIChooseToEditContentOfFirstItem()
        {
            _givepage.Additem1();
            _givepage.EditItem1();
        }
        [When(@"I choose to complete an Item")]
        public void WhenIChooseToCompleteAnItem()
        {
            _givepage.Additem1();
            _givepage.CompleteItem1();
        }

        [Then(@"Item should be marked as completed")]
        public void ThenItemShouldBeMarkedAsCompleted()
        {
            Assert.IsTrue(_givepage.ConfirmItemcompleted());
            //ToDoMVCHelper.closebrowser(driver);
        }

        [When(@"I choose to reactivate an completed Item")]
        public void WhenIChooseToReactivateAnCompletedItem()
        {
            _givepage.Additem1();
            _givepage.CompleteItem1();
            _givepage.ReactivateItem1();
        }

        [Then(@"Item should be reactivated")]
        public void ThenItemShouldBeReactivated()
        {
           Assert.IsTrue(_givepage.ConfirmItemReactivated());
            //ToDoMVCHelper.closebrowser(driver);
        }

        [When(@"I choose to add second ToDO Item")]
        public void WhenIChooseToAddSecondToDOItem()
        {
            _givepage.Additem1();
            _givepage.AddSecondItem();
        }

        [When(@"I choose to mark all ToDo Items as Completed")]
        public void WhenIChooseToMarkAllToDoItemsAsCompleted()
        {
            _givepage.Additem1();
            _givepage.AddSecondItem();
            _givepage.MarkAllComplete();
        }

        [When(@"I choose to filter by Completed Items")]
        public void WhenIChooseToFilterByCompletedItems()
        {
            _givepage.Additem1();
            _givepage.AddSecondItem();
            _givepage.CompleteItem1();
            _givepage.FilterCompletedItems();
        }

        [Then(@"Completed Items should be displayed")]
        public void ThenCompletedItemsShouldBeDisplayed()
        {
           Assert.IsTrue(_givepage.ConfirmItemcompleted());
            
        }

        [When(@"I choose to click the close icon of first ToDo Item")]
        public void WhenIChooseToClickTheCloseIconOfFirstToDoItem()
        {
            _givepage.Additem1();
            _givepage.AddSecondItem();
            _givepage.ClearToDoItem();
        }

        [Then(@"First ToDoItem should be cleared")]
        public void ThenFirstToDoItemShouldBeCleared()
        {
            Assert.IsTrue(_givepage.ConfirmItem1());
        }

        [When(@"I choose to click the Clear Completed button")]
        public void WhenIChooseToClickTheClearCompletedButton()
        {
            _givepage.Additem1();
            _givepage.AddSecondItem();
            _givepage.CompleteItem1();
            _givepage.ClearCompletedToDoItems();
        }
        public void ThenAllCompletedToDoItemsShouldBeCleared()
        {
            Assert.IsTrue(_givepage.ConfirmItem1());
        }





    }
}
