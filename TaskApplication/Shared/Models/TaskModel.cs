using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApplication.Shared.Models
{
    public class TaskModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string description { get; set; }
        public bool isCompleted { get; set; }
    }
}
