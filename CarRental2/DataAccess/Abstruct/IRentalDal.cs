﻿using Core.DataAccess;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstruct
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetByRentDetail();
    }
}
