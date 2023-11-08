using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace todo_backend.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [Key]
       public int Id { get; set; }

        public int IsDeleted { get; set; }

        public int IsCompleted { get; set; }

        
    }
}