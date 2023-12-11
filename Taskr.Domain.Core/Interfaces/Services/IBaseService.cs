using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Taskr.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T>
    {
        IEnumerable<T> FindAll();
        T FindById(Guid id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
