using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Contracts;
using System;
using System.Threading.Tasks;

namespace ToysAndGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public Task<ListResultViewModel<ProductViewModel>> GetAll([FromQuery] SearchViewModel search)
        {
            return _productRepository.GetAllProducts(search);
        }
        [HttpGet("{guid}")]
        public Task<ResultViewModel<ProductViewModel>> GetOne(Guid guid)
        {
            return _productRepository.GetProductById(guid);
        }
        [HttpPost]
        public Task<ResultViewModel<ProductViewModel>> Add(ProductViewModel model)
        {
            return _productRepository.Add(model);
        }
        [HttpPut]
        public Task<ResultViewModel<ProductViewModel>> Update(ProductViewModel model)
        {
            return _productRepository.Update(model);
        }
        [HttpDelete]
        public Task<ResultViewModel<ProductViewModel>> Delete(Guid guid, bool isPermanent)
        {
            return _productRepository.Delete(guid, isPermanent);
        }
    }
}
