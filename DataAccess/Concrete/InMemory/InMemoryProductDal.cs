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
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            new Product {ProductId = 1,CategoryId = 1,ProductName="Bardak",UnitPrice=15,UnitsInStock=20},
            new Product {ProductId = 2,CategoryId = 1,ProductName="Telefon",UnitPrice=2600,UnitsInStock=500},
            new Product {ProductId = 3,CategoryId = 2,ProductName="Bilgisayar",UnitPrice=10000,UnitsInStock=200},
            new Product {ProductId = 4,CategoryId = 2,ProductName="Mouse",UnitPrice=50,UnitsInStock=620},
            new Product {ProductId = 5,CategoryId = 2,ProductName="Klavye",UnitPrice=75,UnitsInStock=820},
            new Product {ProductId = 6,CategoryId = 2,ProductName="Ekran Kartı",UnitPrice=1500,UnitsInStock=120},
            new Product {ProductId = 7,CategoryId = 2,ProductName="SSD Hard Disk",UnitPrice=500,UnitsInStock=200}

            }; 
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId);


            _products.Remove(productToDelete);
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
           return _products.Where(p =>p.CategoryId == categoryId).ToList();
        }

         
          

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
