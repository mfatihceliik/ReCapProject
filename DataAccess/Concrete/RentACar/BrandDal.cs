﻿using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.RentACar
{
    public class BrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        
    }
}
