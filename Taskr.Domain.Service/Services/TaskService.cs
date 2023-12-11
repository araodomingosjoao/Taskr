using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class TaskService : BaseService<Models.Task>, ITaskService
    {
        public readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
            : base(taskRepository)
        {
            _taskRepository = taskRepository;
        }

    }
}
