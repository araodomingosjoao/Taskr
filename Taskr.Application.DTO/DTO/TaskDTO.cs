using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Application.DTO.DTO
{
    public class TaskDTO
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid ProjectId { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
    }
}
