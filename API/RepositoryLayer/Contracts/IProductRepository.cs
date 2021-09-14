using DAL.ViewModels;
using System;
using System.Threading.Tasks;

namespace RepositoryLayer.Contracts
{
    public interface IProductRepository
    {
        public Task<ListResultViewModel<ProductViewModel>> GetAllProducts(SearchViewModel search);
        public Task<ResultViewModel<ProductViewModel>> GetProductById(Guid guid);
        public Task<ResultViewModel<ProductViewModel>> Add(ProductViewModel model);
        public Task<ResultViewModel<ProductViewModel>> Update(ProductViewModel model);
        public Task<ResultViewModel<ProductViewModel>> Delete(Guid guid, bool isPermanent);
    }
}
