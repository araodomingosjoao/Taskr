using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskr.Domain.Core.Interfaces.Repositorys;
using Taskr.Domain.Core.Interfaces.Services;

namespace Taskr.Domain.Service.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> Repository)
        {
            _repository = Repository;
        }
        public virtual T FindById(Guid id)
        {
            return _repository.FindById(id);
        }
        public virtual IEnumerable<T> FindAll()
        {
            return _repository.FindAll();
        }
        public virtual void Create(T obj)
        {
            _repository.Create(obj);
        }
        public virtual void Update(T obj)
        {
            _repository.Update(obj);
        }
        public virtual void Delete(T obj)
        {
            _repository.Delete(obj);
        }
    }
}
