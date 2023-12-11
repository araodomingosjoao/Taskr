using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Models
{
    public class Priority : Base
    {
        public int PriorityId { get; set; }
        public string Name { get; set; }
    }
}
