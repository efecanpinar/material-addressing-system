using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICellService
    {
        IDataResult<Cell> GetById(int cellId);
        IDataResult<List<Cell>> GetList();
        IResult Add(Cell cell);
        IResult Update(Cell cell);
        IResult Delete(Cell cell);
    }
}
