using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Models
{
    public class User : Base
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
