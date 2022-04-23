using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
            Console.WriteLine("Ürün Eklendi");
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
            Console.WriteLine("Ürün Silindi");
        }

        public List<Product> GetAll()
        {
            //iş kodları var ise 
            //Yetkisi varmı?

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
            Console.WriteLine("Ürün Güncellendi");
        }
    }
}
