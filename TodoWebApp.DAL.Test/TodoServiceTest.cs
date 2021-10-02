using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoWebApp.CORE;

namespace TodoWebApp.DAL.Test
{
    [TestClass]
    public class TodoServiceTest
    {
        [TestMethod]
        public void TestGetTodoItems()
        {
            TodoService testTodoService = new TodoService();
            
            Assert.AreEqual(testTodoService.GetTodoItems().Count, 2);
        }
        [TestMethod]
        public void TestGetTodoItemsStatusComplete()
        {
            TodoService testTodoService = new TodoService();

            Assert.AreEqual(testTodoService.GetTodoItemsByStatus(TodoStatus.Complete).Count, 1);
        }
        [TestMethod]
        public void TestGetTodoItemsStatusNotComplete()
        {
            TodoService testTodoService = new TodoService();

            Assert.AreEqual(testTodoService.GetTodoItemsByStatus(TodoStatus.NotComplete).Count, 1);
        }
        [TestMethod]
        public void TestGetTodoItem()
        {
            TodoService testTodoService = new TodoService();

            Assert.AreEqual(testTodoService.GetTodoItem(1).TodoID, 1);
        }
        //[TestMethod]
        //public void TestAddTodoItem()
        //{
        //    TodoService testTodoService = new TodoService();
        //    TodoItem itemToAdd = new TodoItem();
        //    itemToAdd.Name = "Promote Synergy";
        //    //testTodoService.AddTodoItem(itemToAdd);
        //    Assert.AreEqual(testTodoService.GetTodoItems().Count, 2);
        //}
        //[TestMethod]
        //public void TestDeleteTodoItem()
        //{
        //    TodoService testTodoService = new TodoService();
        //    testTodoService.DeleteTodoItem(3);

        //}
        [TestMethod]
        public void TestMarkTodoItemComplete()
        {
            TodoService testTodoService = new TodoService();
            testTodoService.MarkTodoItemComplete(2);
            Assert.AreEqual(testTodoService.GetTodoItem(2).IsComplete, true);
        }
    }
}
