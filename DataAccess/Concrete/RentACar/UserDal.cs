using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.RentACar
{
    public class UserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {

    }
}
