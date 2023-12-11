using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Models
{
    public class Category : Base
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
