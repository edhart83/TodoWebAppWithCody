using System;
using System.ComponentModel.DataAnnotations;

namespace TodoWebApp.CORE
{
    public class TodoItem
    {
        [Key]
        public int TodoID { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
