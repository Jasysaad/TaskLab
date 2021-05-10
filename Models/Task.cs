using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLab.Models
{
    public class Task
    {
        

            public int Id { get; set; }
            public string TaskName { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public IdentityUser User { get; set; }
            public bool IsDone { get; set; }

        
    }
}
