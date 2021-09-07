using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contracts
{
    public interface IBaseRepository<T>
    {
        public T FindByGuid(Guid guid);
        public List<T> FindByParams(SearchViewModel search);
        public int CountByParams(SearchViewModel search);
        public T Add(T model);
        public T Update(T model);
        public T Delete(T model);

    }
}
