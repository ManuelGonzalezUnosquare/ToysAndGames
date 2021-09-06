using DAL.DbModels;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Contracts;
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
        public Task<IEnumerable<Company>> GetAll()
        {
            try
            {
                return _companyRepository.GetAll();
            }
            catch (System.Exception ex)
            {
                var a = ex;
                return null;
            }
        }
    }
   
}
