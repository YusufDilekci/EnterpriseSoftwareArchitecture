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
    //Tekrar düzenleme yapılacak
    public class InMemoryProductDal : IProductDal
    {
        public List<Product> _products;

        public InMemoryProductDal()
        {
            _products= new List<Product>()
            {
                new Product() {ProductId=1, CategoryId=1, ProductName="Phone", UnitPrice=7000, UnitsInStock=50},
                new Product() {ProductId=2, CategoryId=1, ProductName="Laptop", UnitPrice=15000, UnitsInStock=20},
                new Product() {ProductId=3, CategoryId=2, ProductName="ToothBrush", UnitPrice=60, UnitsInStock=2},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var deletedProduct = _products.FirstOrDefault(p => p.ProductId== product.ProductId);

            if (deletedProduct!=null)
            {
                _products.Remove(deletedProduct);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            var products = _products.Where(i => i.CategoryId == categoryId).ToList();

            return products;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var updatedProduct = _products.FirstOrDefault(p =>p.ProductId== product.ProductId);
            if (updatedProduct!=null)
            {
                updatedProduct.CategoryId= product.CategoryId;
                updatedProduct.ProductName = product.ProductName;
                updatedProduct.UnitPrice = product.UnitPrice;
                updatedProduct.UnitsInStock = product.UnitsInStock;
            }
        }
    }
}
