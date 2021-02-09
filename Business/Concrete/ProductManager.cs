using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //injection olayı
        IProductDal _productDal;
        //daha sonraki zamanlarda alternatifleri kullanmamızı sağlar.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?
            return _productDal.GetAll();
        }
    }
}
