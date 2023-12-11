using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Models;

namespace Taskr.Domain.Core.Interfaces.Repositorys
{
    public interface ITaskRepository : IBaseRepository<Models.Task>
    {
    }
}
