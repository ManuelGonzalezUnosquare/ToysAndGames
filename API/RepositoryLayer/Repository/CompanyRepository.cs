using AutoMapper;
using DAL;
using DAL.DbModels;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Company newEntity = new Company()
            {
                Name = companyName
            };
            return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Add(newEntity)));
        }

        public async Task<ResultViewModel<CompanyViewModel>> Delete(CompanyViewModel model)
        {
            Company newEntity = _mapper.Map<Company>(model);
            return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Delete(newEntity)));
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
            Company newEntity = _mapper.Map<Company>(model);
            return new ResultViewModel<CompanyViewModel>(_mapper.Map<CompanyViewModel>(Update(newEntity)));
        }
    }
}
