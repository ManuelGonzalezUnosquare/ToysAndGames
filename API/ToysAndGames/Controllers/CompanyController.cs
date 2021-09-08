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
        public ListResultViewModel<CompanyViewModel> GetAll([FromQuery] SearchViewModel search)
        {
            try
            {
                return _companyRepository.GetAllCompanies(search).Result;
            }
            catch (System.Exception ex)
            {
                return new ListResultViewModel<CompanyViewModel>(ex);
            }
        }
        [HttpGet("{guid}")]
        public ResultViewModel<CompanyViewModel> GetOne([FromQuery] Guid guid)
        {
            try
            {
                return _companyRepository.GetCompanyById(guid).Result;
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }
        [HttpPost]
        public ResultViewModel<CompanyViewModel> Add([FromBody] string companyName)
        {
            try
            {
                return _companyRepository.Add(companyName).Result;
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }
        [HttpPut]
        public ResultViewModel<CompanyViewModel> Update([FromBody] CompanyViewModel model)
        {
            try
            {
                return _companyRepository.Update(model).Result;
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }
        [HttpDelete]
        public ResultViewModel<CompanyViewModel> Delete([FromBody] CompanyViewModel model)
        {
            try
            {
                return _companyRepository.Delete(model).Result;
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }
    }

}
