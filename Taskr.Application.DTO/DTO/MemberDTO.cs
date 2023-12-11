using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Application.DTO.DTO
{
    public class MemberDTO
    {
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ProjectName { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public Guid? UserId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
