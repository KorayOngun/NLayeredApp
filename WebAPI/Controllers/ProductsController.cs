using Business.Concrete;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // => attribute 
    public class ProductsController : ControllerBase
    { 

        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IDataResult<List<Product>> Get()
        {
            var result = _productService.GetAll();
            return result;
        }
    }
}
