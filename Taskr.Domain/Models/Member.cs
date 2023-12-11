using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Models
{
    public class Member : Base
    {
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
