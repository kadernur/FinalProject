using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //SQL cümleciklerini tutar.
  public   interface IOrderDal:IEntityRepository<Order>
    {

    }
}
