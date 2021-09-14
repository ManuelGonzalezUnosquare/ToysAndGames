using AutoMapper;
using DAL;
using DAL.DbModels;
using DAL.ViewModels;
using RepositoryLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ToysGamesContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(ToysGamesContext context, IMapper mapper) : base(context, mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ResultViewModel<ProductViewModel>> Add(ProductViewModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Name))
                {
                    throw new Exception("Invalid product name");
                }

                model.Name = model.Name.ToLower().Trim();

                if (model.Price <= 0)
                {
                    throw new Exception("Invalid product price");
                }

                Company company = _context.Companies.FirstOrDefault(f => f.Guid == model.Company.Guid);

                if (company == null)
                {
                    throw new Exception("Invalid company");
                }

                Product existingProduct = _context.Products.FirstOrDefault(f => f.Name == model.Name && f.CompanyId == company.Id);

                if (existingProduct != null)
                {
                    throw new Exception("This product already exists for this company");
                }

                if(model.AgeRestriction <= 0 || model.AgeRestriction > 100)
                {
                    throw new Exception("Invalid Age restriction");
                }

                if (!string.IsNullOrEmpty(model.Description))
                {
                    model.Description = model.Description.ToLower().Trim();
                }

                Product prod = _mapper.Map<Product>(model);
                return new ResultViewModel<ProductViewModel>(_mapper.Map<ProductViewModel>(Add(prod)));

            }
            catch (Exception ex)
            {
                return new ResultViewModel<ProductViewModel>(ex);
            }
        }

        public Task<ResultViewModel<ProductViewModel>> Delete(Guid guid, bool isPermanent)
        {
            throw new NotImplementedException();
        }

        public async Task<ListResultViewModel<ProductViewModel>> GetAllProducts(SearchViewModel search)
        {
            int count = CountByParams(search);
            return new ListResultViewModel<ProductViewModel>(_mapper.Map<List<Product>, List<ProductViewModel>>(FindByParams(search)), count, search);
        }

        public async Task<ResultViewModel<ProductViewModel>> GetProductById(Guid guid)
        {
            return new ResultViewModel<ProductViewModel>(_mapper.Map<Product, ProductViewModel>(FindByGuid(guid)));
        }

        public async Task<ResultViewModel<ProductViewModel>> Update(ProductViewModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Name))
                {
                    throw new Exception("Invalid product name");
                }
                model.Name = model.Name.ToLower();

                Product existingProduct = _context.Products.FirstOrDefault(f => f.Guid == model.Guid);

                if (existingProduct != null)
                {
                    throw new Exception("Already exists a product with that name");
                }

                Product product = FindByGuid(model.Guid);
                Product newProdValues = _mapper.Map<Product>(model);
                newProdValues.Id = product.Id;
                newProdValues.Guid = product.Guid;
                return new ResultViewModel<ProductViewModel>(_mapper.Map<ProductViewModel>(Update(newProdValues)));
            }
            catch (Exception ex)
            {
                return new ResultViewModel<ProductViewModel>(ex);
            }
        }
    }
}
