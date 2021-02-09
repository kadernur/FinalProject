using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //productla ilgili veri tabanında yapacağim operasyonları içerir.

    public interface IProductDal
    {
        List<Product> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        //Ürünleri category'e göre filtreleme 
        List<Product> GetAllByCategory(int categoryId);


    }
}
