using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class MemberService : BaseService<Member>, IMemberService
    {
        public readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
            : base(memberRepository)
        {
            _memberRepository = memberRepository;
        }
    }
}
