using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.RentACar
{
    public class CustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {

    }
}
