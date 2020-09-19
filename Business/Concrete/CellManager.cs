using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CellManager : ICellService
    {
        private ICellDal _cellDal;

        public CellManager(ICellDal cellDal)
        {
            _cellDal = cellDal;
        }


        public IDataResult<Cell> GetById(int cellId)
        {
            return new SuccessDataResult<Cell>(_cellDal.Get(c => c.CellId == cellId));
        }

        public IDataResult<List<Cell>> GetList()
        {
            return new SuccessDataResult<List<Cell>>(_cellDal.GetList().ToList());
        }

        public IResult Add(Cell cell)
        {
            _cellDal.Add(cell);
            return new SuccessResult(Messages.CellAdded);
        }

        public IResult Update(Cell cell)
        {
            _cellDal.Update(cell);
            return new SuccessResult(Messages.CellUpdated);
        }

        public IResult Delete(Cell cell)
        {
            _cellDal.Delete(cell);
            return new SuccessResult(Messages.CellDeleted);
        }
    }
}
