using DAL.DbModels;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contracts
{
    public interface ICompanyRepository : IAsyncRepository<Company>
    {
     //   public Task<ResultListModel<CompanyViewModel>> GetAllCompanies();
    }
}
