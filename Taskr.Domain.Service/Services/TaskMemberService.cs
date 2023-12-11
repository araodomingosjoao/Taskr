using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class TaskMemberService : BaseService<TaskMember>, ITaskMemberService
    {
        public readonly ITaskMemberRepository _taskMemberRepository;

        public TaskMemberService(ITaskMemberRepository taskMemberRepository)
            : base(taskMemberRepository)
        {
            _taskMemberRepository = taskMemberRepository;
        }
    }
}
