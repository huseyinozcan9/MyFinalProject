using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=1,CategoryId=1,ProductName="Kamera",UnitPrice=150,UnitsInStock=3},
                new Product{ProductId=1,CategoryId=1,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=1,CategoryId=1,ProductName="Klavye",UnitPrice=105,UnitsInStock=65}};
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product deletedProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if (deletedProduct != null)
            {
                _products.Remove(deletedProduct);
            }
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product updatedProduct = _products.FirstOrDefault( p => p.ProductId == product.ProductId);
            updatedProduct.CategoryId = product.CategoryId;
            updatedProduct.ProductName = product.ProductName;   
            updatedProduct.ProductId = product.ProductId;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
            
        }

        public List<Product> GetCategoryById(int id)
        {
            return _products.Where(i => i.CategoryId == id).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
