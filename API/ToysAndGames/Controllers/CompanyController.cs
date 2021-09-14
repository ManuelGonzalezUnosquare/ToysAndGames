using DAL.DbModels;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToysAndGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        [HttpGet]
        public Task<ListResultViewModel<CompanyViewModel>> GetAll([FromQuery] SearchViewModel search)
        {
            return _companyRepository.GetAllCompanies(search);
        }
        [HttpGet("{guid}")]
        public Task<ResultViewModel<CompanyViewModel>> GetOne(Guid guid)
        {
            return _companyRepository.GetCompanyById(guid);
        }
        [HttpPost]
        public Task<ResultViewModel<CompanyViewModel>> Add(CompanyViewModel company)
        {
            return _companyRepository.Add(company.Name);
        }
        [HttpPut]
        public Task<ResultViewModel<CompanyViewModel>> Update(CompanyViewModel model)
        {
            return _companyRepository.Update(model);
        }
        [HttpDelete]
        public Task<ResultViewModel<CompanyViewModel>> Delete(Guid guid, bool isPermanent)
        {
            return _companyRepository.Delete(guid, isPermanent);
        }
    }

}
