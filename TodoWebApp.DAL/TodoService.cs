using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWebApp.CORE;

namespace TodoWebApp.DAL
{
    public class TodoService : ITodoService
    {
        TodoWebAppDbContext ServiceDbContext = new TodoWebAppDbContext();

        
        public List<TodoItem> GetTodoItems()
        {
            return ServiceDbContext.TodoItems.ToList<TodoItem>();
        }
        public List<TodoItem> GetTodoItemsByStatus(TodoStatus status)
        {
            if (status == TodoStatus.NotComplete)
            {
                return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.IsComplete == false).ToList<TodoItem>();
            }
            else 
            { 
                return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.IsComplete == true).ToList<TodoItem>();
            }
        }
        public TodoItem GetTodoItem(int id)
        {
            return ServiceDbContext.TodoItems.Where(thisTodo => thisTodo.TodoID == id).FirstOrDefault();
        }
        public void AddTodoItem(TodoItem newItem)
        {
            ServiceDbContext.TodoItems.Add(newItem);
            ServiceDbContext.SaveChanges();
        }
        public void DeleteTodoItem(int id)
        {
            ServiceDbContext.TodoItems.Remove(GetTodoItem(id));
            ServiceDbContext.SaveChanges();
        }
        public void MarkTodoItemComplete(int id)
        {
            this.GetTodoItem(id).IsComplete = true;
            ServiceDbContext.SaveChanges();
        }
    }
}
