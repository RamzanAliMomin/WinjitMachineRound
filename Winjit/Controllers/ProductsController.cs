using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Winjit.Model;
using Winjit.Reposistory;

namespace Winjit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IUnitOfWork uow;
        public ProductsController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return uow.ProductRepo.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductId(int id)
        {
            var product= uow.ProductRepo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            uow.ProductRepo.Add(product);
            uow.SaveChanges();
        }

        [HttpPut("{id}")]
        public void UpdateProduct(int id, Product product)
        {
            uow.ProductRepo.Modify(product);
            uow.SaveChanges();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var product = uow.ProductRepo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            uow.ProductRepo.Delete(product);
            uow.SaveChanges();
            return product;
        }
    }
}
