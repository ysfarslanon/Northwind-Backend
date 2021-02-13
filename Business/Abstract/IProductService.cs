using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);// Kategori id sine göre filitreleme
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);// fiyat aralığına göre filitreleme
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);//o ürünle ilgili detaylar için product(entity) yazıldı
        IResult Add(Product product);

    }
}
