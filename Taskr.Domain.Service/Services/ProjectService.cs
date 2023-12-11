using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        public readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
            : base(projectRepository)
        {
            _projectRepository = projectRepository;
        }
    }
}
