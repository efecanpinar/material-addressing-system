using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IHallService
    {
        IDataResult<Hall> GetById(int hallId);
        IDataResult<List<Hall>> GetList();
        IResult Add(Hall hall);
        IResult Update(Hall hall);
        IResult Delete(Hall hall);
    }
}
