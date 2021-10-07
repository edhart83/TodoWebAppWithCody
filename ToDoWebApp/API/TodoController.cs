using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApp.DAL;
using TodoWebApp.CORE;

namespace ToDoWebApp.API
{    
    
    [ApiController]
    public class TodoController : ControllerBase
    {
        ITodoService theTodoControlService;

        public TodoController(ITodoService tds)
        {
            theTodoControlService = tds;
        }
        [HttpGet("/api/TodoItems")]
        public ActionResult<List<TodoItem>> GetAllTodoItems()
        {
            return theTodoControlService.GetTodoItems();
        }
        [HttpGet("/api/TodoItem/{id}")]
        public ActionResult<TodoItem> GetTodoItem(int id)
        {
            return theTodoControlService.GetTodoItem(id);
        }
        [HttpPost("/api/MarkTodoItem/{id}")]
        public ActionResult MarkTodoItem(int id)
        {
            theTodoControlService.MarkTodoItemComplete(id);
            return Ok();
        }
        [HttpPost("/api/AddTodoItem")]
        public ActionResult AddTodoItem(TodoItem tdim)
        {
            if (this.ModelState.IsValid)
            {
                theTodoControlService.AddTodoItem(tdim);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
