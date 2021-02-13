﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetBrandById(int id);
       

        IResult Add(Brand brand);
        IResult Delete(Brand brand);

        IResult Update(Brand brand);
    }
}
