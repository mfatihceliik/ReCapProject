using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByRentalId(int rentalId);
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult<Rental> GetByCustomerId(int customerId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
