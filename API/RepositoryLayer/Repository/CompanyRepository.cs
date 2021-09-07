using DAL;
using DAL.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class CompanyRepository : AsyncRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ToysGamesContext context) : base(context) { }
    }
}
