using AutoMapper;
using DAL;
using DAL.DbModels;
using DAL.ViewModels;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        private readonly ToysGamesContext _context;
        private readonly IMapper _mapper;
        public CompanyRepository(ToysGamesContext context, IMapper mapper) : base(context, mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ResultViewModel<CompanyViewModel>> Add(string companyName)
        {
            try
            {
                if (string.IsNullOrEmpty(companyName))
                {
                    throw new Exception("Invalid company name");
                }
                companyName = companyName.ToLower().Trim();

                Company existingCompany = _context.Companies.FirstOrDefault(f => f.Name == companyName);

                if (existingCompany != null)
                {
                    throw new Exception("Already exists a company with that name");
                }

                Company newEntity = new Company()
                {
                    Name = companyName
                };
                return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Add(newEntity)));
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }

        public async Task<ResultViewModel<CompanyViewModel>> Delete(Guid guid, bool isPermanent)
        {
            try
            {
                Company company = FindByGuid(guid);
                if (isPermanent)
                {
                    return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Delete(company)));
                }
                else
                {
                    company.Active = false;
                    return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Update(company)));
                }
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }

        public async Task<ListResultViewModel<CompanyViewModel>> GetAllCompanies(SearchViewModel search)
        {
            int count = CountByParams(search);
            return new ListResultViewModel<CompanyViewModel>(_mapper.Map<List<Company>, List<CompanyViewModel>>(FindByParams(search)), count, search);
        }

        public async Task<ResultViewModel<CompanyViewModel>> GetCompanyById(Guid guid)
        {
            return new ResultViewModel<CompanyViewModel>(_mapper.Map<Company, CompanyViewModel>(FindByGuid(guid)));
        }

        public async Task<ResultViewModel<CompanyViewModel>> Update(CompanyViewModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Name))
                {
                    throw new Exception("Invalid company name");
                }
                model.Name = model.Name.ToLower();

                Company existingCompany = _context.Companies.FirstOrDefault(f => f.Name == model.Name);

                if (existingCompany != null)
                {
                    throw new Exception("Already exists a company with that name");
                }

                Company company = FindByGuid(model.Guid);
                company.Name = model.Name.ToLower().Trim();
                return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Update(company)));
            }
            catch (Exception ex)
            {
                return new ResultViewModel<CompanyViewModel>(ex);
            }
        }
    }
}
