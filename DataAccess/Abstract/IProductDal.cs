﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //productla ilgili veri tabanında yapacağim operasyonları içerir.

    public interface IProductDal:IEntityRepository<Product>
    {

        //IEntityRepository'i Product için yapılandırdım.

        //ürünün detaylarını getir.
        List<ProductDetailDto> GetProductDetails();



    }
}
//Code refactoring