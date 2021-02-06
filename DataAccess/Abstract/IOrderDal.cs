using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //will be in/carry sql statements
    public interface IOrderDal:IEntityRepository<Order>
    {
    }
}
