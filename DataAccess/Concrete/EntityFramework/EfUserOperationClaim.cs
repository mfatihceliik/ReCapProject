using Core.DataAccess.Entityframework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaim : EfEntityRepositoryBase<UserOperationClaim, EfRentACarContext>, IUserOperationClaimDal
    {

    }
}
