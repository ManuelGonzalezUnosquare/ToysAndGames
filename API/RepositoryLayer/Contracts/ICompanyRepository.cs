using DAL.DbModels;
using DAL.ViewModels;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Contracts
{
    public interface ICompanyRepository
    {
        public Task<ListResultViewModel<CompanyViewModel>> GetAllCompanies(SearchViewModel search);
        public Task<ResultViewModel<CompanyViewModel>> GetCompanyById(Guid guid);
        public Task<ResultViewModel<CompanyViewModel>> Add(string companyName);
        public Task<ResultViewModel<CompanyViewModel>> Update(CompanyViewModel model);
        public Task<ResultViewModel<CompanyViewModel>> Delete(CompanyViewModel model);
    }
}
