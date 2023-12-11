using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
