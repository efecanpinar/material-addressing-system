using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICabinetService
    {
        IDataResult<Cabinet> GetById(int cabinetId);
        IDataResult<List<Cabinet>> GetList();
        IResult Add(Cabinet cabinet);
        IResult Update(Cabinet cabinet);
        IResult Delete(Cabinet cabinet);
    }
}
