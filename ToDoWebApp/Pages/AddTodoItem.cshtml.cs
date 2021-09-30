using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebApp.CORE;

namespace ToDoWebApp.Pages
{
    public class AddTodoItemModel : PageModel
    {
        [BindProperty]
        public TodoItem TodoItems { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
