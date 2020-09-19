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
    public class ShelfManager : IShelfService
    {
        private readonly IShelfDal _shelfDal;

        public ShelfManager(IShelfDal shelfDal)
        {
            _shelfDal = shelfDal;
        }
        public IDataResult<Shelf> GetById(int shelfId)
        {
            return new SuccessDataResult<Shelf>(_shelfDal.Get(s => s.ShelfId == shelfId));
        }

        public IDataResult<List<Shelf>> GetList()
        {
            return new SuccessDataResult<List<Shelf>>(_shelfDal.GetList().ToList());
        }

        public IResult Add(Shelf shelf)
        {
            _shelfDal.Add(shelf);
            return new SuccessResult(Messages.ShelfAdded);
        }

        public IResult Update(Shelf shelf)
        {
            _shelfDal.Update(shelf);
            return new SuccessResult(Messages.ShelfUpdated);
        }

        public IResult Delete(Shelf shelf)
        {
            _shelfDal.Delete(shelf);
            return new SuccessResult(Messages.ShelfDeleted);
        }
    }
}
