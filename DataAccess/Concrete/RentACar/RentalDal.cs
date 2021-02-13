﻿using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.RentACar
{
    public class RentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                              join c in context.Cars
                              on r.CarId equals c.CarId
                              join b in context.Brands
                              on c.BrandId equals b.BrandId
                              join cu in context.Customers
                              on r.CustomerId equals cu.CustomerId
                              join u in context.Users
                              on cu.UserId equals u.UserId
                              select new RentalDetailDto 
                              { 
                                  CarName = b.BrandName,
                                  CustomerName = u.FirstName+ " " +u.LastName,
                                  RentDate = r.RentDate, 
                                  ReturnDate = r.ReturnDate
                              };

                return result.ToList();
            }
        }
    }
}
