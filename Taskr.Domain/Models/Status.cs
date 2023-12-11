using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Models
{
    public class Status : Base
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}
