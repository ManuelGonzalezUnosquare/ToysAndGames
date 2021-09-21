using AutoMapper;
using DAL;
using DAL.DbModels;
using DAL.ViewModels;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ToysGamesContext _context;
        private readonly IMapper _mapper;

        public BaseRepository(ToysGamesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public T Add(T model)
        {
            model.Guid = Guid.NewGuid();
            var res =_context.Set<T>().Add(model);
            _context.SaveChanges();
            return res.Entity;
        }

        public int CountByParams(SearchViewModel search)
        {
            var query = from v in _context.Set<T>()
                        select v;
            if (search.Guid.HasValue)
            {
                query = from v in query
                        where v.Guid == search.Guid.Value
                        select v;
            }
            if (search.Active.HasValue)
            {
                query = from v in query
                        where v.Active == search.Active.Value
                        select v;
            }
            return query.Count();
        }

        public T Delete(T model)
        {
            _context.Set<T>().Remove(model);
            _context.SaveChanges();
            return model;
        }
        public T FindByGuid(Guid guid)
        {
            return _context.Set<T>().FirstOrDefault(e => e.Guid == guid);
        }

        public List<T> FindByParams(SearchViewModel search)
        {
            var query = from v in _context.Set<T>()
                        select v;
            if (search.Guid.HasValue)
            {
                query = from v in query
                        where v.Guid == search.Guid.Value
                        select v;
            }
            if (search.Active.HasValue)
            {
                query = from v in query
                        where v.Active == search.Active.Value
                        select v;
            }

            query = (from v in query
                     select v)
                     .OrderBy(f => f.Id)
                      .Skip((search.Page - 1) * search.PerPage)
                      .Take(search.PerPage);

            return query.ToList();
        }
        public List<T> FindByParams(Func<T, bool> expression, SearchViewModel search)
        {
            var query = from v in _context.Set<T>()
                        select v;

            query = query.Where(expression).AsQueryable();

            if (search.Guid.HasValue)
            {
                query = from v in query
                        where v.Guid == search.Guid.Value
                        select v;
            }
            if (search.Active.HasValue)
            {
                query = from v in query
                        where v.Active == search.Active.Value
                        select v;
            }

            query = (from v in query
                     select v)
                     .OrderBy(f => f.Id)
                      .Skip((search.Page - 1) * search.PerPage)
                      .Take(search.PerPage);

            return query.ToList();
        }
        public T Update(T model)
        {
            var res =_context.Set<T>().Update(model);
            _context.SaveChanges();
            return res.Entity;
        }
    }
}
