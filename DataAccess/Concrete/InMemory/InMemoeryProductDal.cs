using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoeryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoeryProductDal()
        {
            _products = new List<Product>{
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=31},
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=15},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);      
        }

        public void Delete(Product product)
        {
            var item = _products.SingleOrDefault(x=>x.ProductId==product.ProductId);
            if (item != null) _products.Remove(item);
        }

        public void Update(Product product)
        {
            var item = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            if (item != null)
            {
                item.UnitPrice = product.UnitPrice;
                item.UnitsInStock = product.UnitsInStock;
                item.CategoryId = product.CategoryId;
                item.ProductName = product.ProductName;
            }
            
            
        }

        List<Product> IEntityRepository<Product>.GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Puan()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
