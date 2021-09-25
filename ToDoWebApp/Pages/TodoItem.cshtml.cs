using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoWebApp.Pages
{
    public class TodoItemModel : PageModel
    {
        public Dictionary<string, TodoItem> TodoList { get; set; }

        public TodoItemModel()
        {
            this.TodoList = new Dictionary<string, TodoItem>();
            this.TodoList.Add("Task1", new TodoItem() {Name = "Code", IsComplete = false });
            this.TodoList.Add("Task2", new TodoItem() { Name = "Eat", IsComplete = false });
            this.TodoList.Add("Task3", new TodoItem() { Name = "Sleep", IsComplete = false });
        }
        public void OnGet()
        {
        }
    }
}
