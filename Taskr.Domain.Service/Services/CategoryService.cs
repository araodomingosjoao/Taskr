using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;
using Taskr.Domain.Models;

namespace Taskr.Domain.Service.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
            : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
