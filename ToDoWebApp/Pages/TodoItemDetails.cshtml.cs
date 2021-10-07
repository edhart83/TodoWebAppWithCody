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
    public class TodoItemDetailsModel : PageModel
    {
        ITodoService theTodoService;

        public TodoItem theTodoItem;
        public TodoItemDetailsModel(ITodoService tds)
        {
            theTodoService = tds;
        }
        public IActionResult OnGet(int id)
        {
            theTodoItem = theTodoService.GetTodoItem(id);
            if(theTodoItem == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            theTodoService.MarkTodoItemComplete(id);
            return RedirectToPage("TodoItem");
        }
    }
}
