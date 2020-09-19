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
    public class HallManager : IHallService
    {
        private IHallDal _hallDal;
        
        public HallManager(IHallDal hallDal)
        {
            _hallDal = hallDal;
        }

        public IDataResult<Hall> GetById(int hallId)
        {
            return new SuccessDataResult<Hall>(_hallDal.Get(c => c.HallId == hallId));
        }

        public IDataResult<List<Hall>> GetList()
        {
            return new SuccessDataResult<List<Hall>>(_hallDal.GetList().ToList());
        }

        public IResult Add(Hall hall)
        {
            _hallDal.Add(hall);
            return new SuccessResult(Messages.HallAdded);
        }

        public IResult Update(Hall hall)
        {
            _hallDal.Update(hall);
            return new SuccessResult(Messages.HallUpdated);
        }

        public IResult Delete(Hall hall)
        {
            _hallDal.Delete(hall);
            return new SuccessResult(Messages.HallDeleted);
        }
    }
}
