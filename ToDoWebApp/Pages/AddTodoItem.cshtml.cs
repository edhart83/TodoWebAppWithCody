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
    public class AddTodoItemModel : PageModel
    {
        ITodoService theTodoService;

        [BindProperty]
        public TodoItem TodoItems { get; set; }
        public AddTodoItemModel(ITodoService tds)
        {
            theTodoService = tds;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            if (this.ModelState.IsValid)
            {
                theTodoService.AddTodoItem(TodoItems);
                return RedirectToPage("TodoItem");
            }
            else 
            {
                return BadRequest();
            }
        }
    }
}
