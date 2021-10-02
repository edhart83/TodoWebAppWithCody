using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebApp.CORE;
using TodoWebApp.DAL;

namespace ToDoWebApp.Pages
{
    public class TodoItemModel : PageModel
    {

        ITodoService theTodoService;

        public List<TodoItem> todoList = new List<TodoItem>();

        public TodoItemModel(ITodoService tds)
        {
            theTodoService = tds;
        }
        public void OnGet()
        {
            todoList = theTodoService.GetTodoItems();
        }
    }
}
